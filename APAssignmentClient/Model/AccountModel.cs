using APAssignmentClient.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using APAssignmentClient.Data_Service;
using System.Data.SqlTypes;

namespace APAssignmentClient.Model
{
    public class AccountModel : IAccountModel
    {
        private static AccountModel _instance = null;
        private IDataAccess access;
        private User user;

        private AccountModel()
        {
            user = new User();
            access = new DataAccess();
        }

        public static AccountModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AccountModel();
            }
            return _instance;
        }

        public int UserID
        {
            set { user.UserID = value; }
            get { return user.UserID; }
        }

        public int UserType
        {
            set { user.UserType = value; }
            get { return user.UserType; }
        }

        public bool Login(String username, String password)
        {
            byte[] hash = HashPassword(password);
            if (access.CheckAccountExist(username))
            {
                user = access.RetrieveUserInformation(username);

                byte[] retrievedHash = user.UserPassword;
                if (retrievedHash.SequenceEqual(hash))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public void Register(String username, String password)
        {
            byte[] hash = HashPassword(password);
            User user = new User
            {
                UserName = username,
                UserPassword = hash,
                UserType = 1
            };
            access.RegisterAccount(user);
        }

        public Client RetrieveClient()
        {
            return access.RetrieveClient(UserID);
        }

        private byte[] HashPassword(String password)
        {
            String salt = "kf7014ap";
            String newPassword = password + salt;

            SHA256 sha256 = SHA256Managed.Create();
            UTF8Encoding utf8 = new UTF8Encoding();
            return sha256.ComputeHash(utf8.GetBytes(newPassword));
        }
    }
}
