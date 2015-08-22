using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

using entityLayer;
using dataAccessLayer;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace businessLayer
{
    public class appValidater
    {
        private RSAParameters privKey;
        private RSAParameters pubKey;
        private RSACryptoServiceProvider rsaCSP;
        private static readonly ILog logger = LogManager.GetLogger(typeof(appValidater));
        public appValidater() { }

        public Boolean appSerializer(double noOfTrialDays)
        {
            Boolean trialStatus = false;
            if (checkSerializerFileExists())
            {
                trialStatus = existingSerializer(noOfTrialDays);
            }
            else
            {
                freshSerializer();
                trialStatus = existingSerializer(noOfTrialDays);
            }
            return trialStatus;
        }

        public Boolean verifySerial(string serial)
        {
            Boolean serialStatus = true;
            try
            {
                char[] array = serial.ToCharArray();
                if (!checkCharInRange('J', 10, array[0].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkIntInRange(2, 8, array[1]))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('E', 10, array[2].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('T', 6, array[3].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('J', 8, array[4].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('H', 18, array[5].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkIntInRange(20, 60, array[6] + array[7]))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('D', 12, array[8].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('O', 8, array[9].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('E', 13, array[10].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('P', 10, array[11].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('M', 5, array[12].ToString()))
                {
                    serialStatus = false;
                }
                if (!checkIntInRange(1, 6, array[13]))
                {
                    serialStatus = false;
                }
                if (!checkIntInRange(4, 9, array[14]))
                {
                    serialStatus = false;
                }
                if (!checkCharInRange('B', 24, array[15].ToString()))
                {
                    serialStatus = false;
                }
            }
            catch (Exception err)
            {
                //Console.WriteLine(err.ToString());
                logger.Error("\n UI Error in appValidater.verifySerial: " + err.ToString());
            }
            return serialStatus;
        }

        private Boolean checkCharInRange(Char startChar, int count, string charValue)
        {
            char[] alphabet = Enumerable.Range(startChar, count).Select(x => (char)x).ToArray();
            return charValue.IndexOfAny(alphabet) != -1;
        }

        private Boolean checkIntInRange(int startIntIndex, int endIntIndex, int value)
        {
            return Enumerable.Range(startIntIndex, endIntIndex).Contains(value);
        }

        public void updateAppSerial(string validSerial)
        {
            string[] serializerFileData = readSerializerFile();
            rsaCSP = new RSACryptoServiceProvider(2048);
            privKey = getRSAKey(serializerFileData[2]);
            pubKey = getRSAKey(serializerFileData[3]);
            string encryptedValidSerial = rsaEncryption(validSerial);
            writeSerial(encryptedValidSerial);
        }

        private void writeSerial(string serial)
        {
            string serializerFilePath = getSerializerFilePath();
            int lineNo = 0;
            int lineCount = 0;
            using (StreamReader file = new StreamReader(serializerFilePath))
            {
                while ((file.ReadLine()) != null)
                {
                    String line = file.ReadLine();
                    if (line == "***Data***")
                    {
                        lineNo++;
                    }
                    if (lineNo == 4)
                    {
                        lineCount++;
                        break;
                    }
                    lineCount++;
                }
            }

            string[] lines = File.ReadAllLines(serializerFilePath);
            using (StreamWriter writer = new StreamWriter(serializerFilePath))
            {
                for (int currentLine = 1; currentLine <= lines.Length; currentLine++)
                {
                    if (currentLine == lineCount)
                    {
                        writer.WriteLine(serial);
                        break;
                    }
                }
            }
        }

        private Boolean existingSerializer(double noOfTrialDays)
        {
            Boolean trialStatus = true;
            string serializerFilePath = getSerializerFilePath();
            string[] serialData = readSerializerFile();
            privKey = getRSAKey(serialData[2]);
            pubKey = getRSAKey(serialData[3]);
            string installationDate = rsaDecryption(serialData[0]);
            double dateDiff = calculateDateDiff(Convert.ToDateTime(installationDate), getCurrentDateTime());
            if (dateDiff > noOfTrialDays)
            {
                trialStatus = false;
                string serial = rsaDecryption(serialData[1]);
                trialStatus = verifySerial(serial);
            }
            return trialStatus;
        }

        private void freshSerializer()
        {
            rsaCSP = new RSACryptoServiceProvider(2048);
            privKey = rsaCSP.ExportParameters(true);
            pubKey = rsaCSP.ExportParameters(false);
            string appDirectory = createAppSerializerDataDirectory();
            DateTime currentTimeStamp = getCurrentDateTime();
            string installationDateEncrypt = rsaEncryption(currentTimeStamp.ToString());
            string serialKeyEncrypt = rsaEncryption("None");
            string rsaPrivateKey = getRSAKeyString(privKey);
            string rsaPublicKey = getRSAKeyString(pubKey);
            string[] serilizerFileData = new string[] {installationDateEncrypt, 
                serialKeyEncrypt, rsaPrivateKey, rsaPublicKey};
            writeSerializerFile(serilizerFileData);
        }

        private Boolean checkSerializerFileExists()
        {
            Boolean Exists = false;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string serializerFolder = Path.Combine(folder, "stockControl");
            string filePath = Path.Combine(serializerFolder, "serializer.txt");
            if (File.Exists(filePath))
            {
                Exists = true;
            }
            return Exists;
        }

        private String getSerializerFilePath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string serializerFolder = Path.Combine(folder, "stockControl");
            return Path.Combine(serializerFolder, "serializer.txt");
        }

        private string createAppSerializerDataDirectory()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string serializerFolder = Path.Combine(folder, "stockControl");
            if (!Directory.Exists(serializerFolder))
            {
                Directory.CreateDirectory(serializerFolder);
            }
            return serializerFolder;
        }

        private void writeSerializerFile(String[] serilizerFileData)
        {
            string serializerFilePath = getSerializerFilePath();
            using (StreamWriter writer = new StreamWriter(serializerFilePath))
            {
                writer.WriteLine("***Data***");
                writer.WriteLine(serilizerFileData[0]);
                writer.WriteLine("***Data***");
                writer.WriteLine(serilizerFileData[1]);
                writer.WriteLine("***Data***");
                writer.WriteLine(serilizerFileData[2]);
                writer.WriteLine("***Data***");
                writer.WriteLine(serilizerFileData[3]);
            }
        }

        private string[] readSerializerFile()
        {
            string serializerFilePath = getSerializerFilePath();
            string[] serilizerFileData = new string[4];
            int lineNo = -1;
            using (StreamReader file = new StreamReader(serializerFilePath))
            {
                String line;
                while ((line = file.ReadLine()) != null)
                {
                    if (!(line == "***Data***"))
                    {
                        serilizerFileData[lineNo] += line;
                    }
                    else
                    {
                        lineNo++;
                    }
                }
            }
            return serilizerFileData;
        }

        private DateTime getCurrentDateTime()
        {
            return DateTime.Now;
        }


        private byte[] sha1Encrypt(String key, String value)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(key);
            HMACSHA1 hmacsha1 = new HMACSHA1(keyByte);
            byte[] valueBytes = encoding.GetBytes(value);
            return hmacsha1.ComputeHash(valueBytes);
        }


        private String rsaEncryption(String data)
        {
            rsaCSP = new RSACryptoServiceProvider();
            rsaCSP.ImportParameters(pubKey);
            byte[] bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(data);
            byte[] bytesCypherText = rsaCSP.Encrypt(bytesPlainTextData, false);
            return Convert.ToBase64String(bytesCypherText);
        }

        private String rsaDecryption(String cypherText)
        {
            byte[] bytesCypherText = Convert.FromBase64String(cypherText);
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            rsaCSP.ImportParameters(privKey);
            byte[] bytesPlainTextData = rsaCSP.Decrypt(bytesCypherText, false);
            return System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
        }


        private string getRSAKeyString(RSAParameters Key)
        {
            StringWriter sw = new System.IO.StringWriter();
            XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, Key);
            return sw.ToString();
        }

        private RSAParameters getRSAKey(string keyString)
        {
            StringReader sr = new StringReader(keyString);
            XmlSerializer xs = new XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }


        private byte[] string2ByteArray(String value)
        {
            return Encoding.UTF8.GetBytes(value);
        }

        private string byteArray2String(byte[] value)
        {
            return Encoding.UTF8.GetString(value);
        }

        private double calculateDateDiff(DateTime StartDate, DateTime EndDate)
        {
            return (EndDate - StartDate).TotalDays;
        }
    }
}
