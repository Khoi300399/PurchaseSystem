using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RequestTCHeaderDAO
    {
        private static volatile RequestTCHeaderDAO instance;
        private static object key = new object();
        private RequestTCHeaderDAO() { }

        public static RequestTCHeaderDAO Instance
        {
            get
            {
                if (instance == null)

                {
                    lock (key)
                    {
                        instance = new RequestTCHeaderDAO();
                    }
                }
                return instance;
            }
        }

         public DataTable GetData()
        {
            string query = @"SELECT *
                             FROM RequestTCHeader";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DeleteDataById(string id)
        {
            string query = @"DELETE RequestTCHeader
                             WHERE id = @ID";

            object[] parameter = new object[]{ id };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0) {
                return true;
            }
            return false;
        }

    }
}
 