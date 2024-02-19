using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace DAO
{
    public class AuthDAO
    {
        private static volatile AuthDAO instance;
        private static object key = new object();
        private AuthDAO() { }

        public static AuthDAO Instance { get {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new AuthDAO();
                    }
                }
                return instance;
            } }

        public bool AuthenticateUser(Auth account)
        {
            string query = @" EXEC AuthenticateUser @UserName , @CryptedPassword ";
            object[] parameters = new object[] { account.Username, account.Password };
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }

    }
}
