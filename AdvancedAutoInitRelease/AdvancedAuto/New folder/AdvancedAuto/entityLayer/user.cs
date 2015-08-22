using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class user
    {
        private String userName;
        private String role;
        private String password;
        private String fName;
        private String lName;
        private String address;
        private String telephone;
        private String nic;

        public user() { }

        public user(String userName, String role, String password, String fName,
            String lName, String address, String telephone, String nic)
        {
            this.userName = userName;
            this.role = role;
            this.password = password;
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.telephone = telephone;
            this.nic = nic;
        }

        public String Username
        {
            get { return userName; }
            set { userName = value; }
        }

        public String Role
        {
            get { return role; }
            set { role = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String First_Name
        {
            get { return fName; }
            set { fName = value; }
        }

        public String Last_Name
        {
            get { return lName; }
            set { lName = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public String NIC
        {
            get { return nic; }
            set { nic = value; }
        }
    }
}
