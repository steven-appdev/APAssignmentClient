using APAssignmentClient.DataService;
using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ModelMocs
{
    public class AccountMoc : IAccountModel
    {
        public int UserID { set; get; }
        public int UserType { set; get; }

        public String Username { set; get; }
        public String Password { set; get; }
        public String Fullname { set; get; }
        public String Address { set; get; }
        public String Email { set; get; }
        public String Contact { set; get; }

        bool IAccountModel.Login(string username, string password)
        {
            Username = username;
            Password = password;
            return false;
        }

        public void Register(string username, string password, string fullname, string address, string email, string contact)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
            Address = address;
            Email = email;
            Contact = contact;
        }

        public Client RetrieveClient()
        {
            throw new NotImplementedException();
        }
    }
}
