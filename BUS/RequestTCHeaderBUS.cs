using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace BUS
{
    public class RequestTCHeaderBUS
    {
        private static volatile RequestTCHeaderBUS instance;
        private static object key = new object();
        private RequestTCHeaderBUS() {}

        public static RequestTCHeaderBUS Instance { get
            {
                if (instance == null)
                
{
                    lock (key)
                    {
                        instance = new RequestTCHeaderBUS();
                    }
                }
                return instance;
            }
        }

        public void GetData(GridControl gcData)
        {
            gcData.DataSource = RequestTCHeaderDAO.Instance.GetData();
        }

        public bool DeleteDataById(GridView gvData) 
        {
            string id = gvData.GetRowCellValue(gvData.FocusedRowHandle, "id").ToString();

            return RequestTCHeaderDAO.Instance.DeleteDataById(id);
        }
    }
}
