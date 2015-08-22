using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entityLayer;
using dataAccessLayer;

namespace businessLayer
{
    public class userDataManipulations
    {
        public Boolean authenticateUser(user User)
        {
            UserDataAccess uda1 = new UserDataAccess();
            user tmpAuthenticatedUser = uda1.getAuthenticatedUser(User.Username, User.Password);
            if (User.Username == tmpAuthenticatedUser.Username && User.Password == tmpAuthenticatedUser.Password)
            {
                wrapperDataBuffer.WrapperObject.User1 = tmpAuthenticatedUser;
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean validateUserName(String userName)
        {
            return true;
            //UserDataAccess uda1 = new UserDataAccess();
            //user tmpAuthenticatedUser = uda1.getUsrByUsrname(userName);
            //if (userName == tmpAuthenticatedUser.UserName)
            //{
            //    return true;
            //}
            //else {
            //    return false;
            //}
        }

        public Boolean addNewUser(user User)
        {
            UserDataAccess uda1 = new UserDataAccess();
            int result = uda1.insertUser(User);
            if (result.Equals(1))
                return true;
            else
                return false;
        }

        public Boolean updateUser(user User)
        {
            return new UserDataAccess().updateUser(User);
        }

        public Boolean deleteUser(user User)
        {
            return new UserDataAccess().deleteUser(User);
        }

        public List<user> getAllUsers()
        {
            UserDataAccess uda1 = new UserDataAccess();
            return uda1.getAllUsers();
        }
    }
}
