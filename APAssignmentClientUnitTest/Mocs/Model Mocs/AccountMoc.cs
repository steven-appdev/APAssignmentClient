using APAssignmentClient.DataService;
using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
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

        bool IAccountModel.Login(string username, string password)
        {
            Username = username;
            Password = password;
            return false;
        }

        void IAccountModel.Register(string username, string password, string fullname, string address, string email, string contact)
        {
            throw new NotImplementedException();
        }

        Client IAccountModel.RetrieveClient()
        {
            throw new NotImplementedException();
        }
    }
}
