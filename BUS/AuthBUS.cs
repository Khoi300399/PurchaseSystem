using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class AuthBUS
    {

        private static volatile AuthBUS instance;
        private static object key = new object();
        private AuthBUS() { }

        public static AuthBUS Instance
        {
            get

            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new AuthBUS();
                    }
                }
                return instance;
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            Auth account = new Auth(username, password);
            return AuthDAO.Instance.AuthenticateUser(account);
        }
    }
}
