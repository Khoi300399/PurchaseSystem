using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace PurchaseSystem.UI
{
    public partial class ucStorekeeper : UserControl
    {
        public ucStorekeeper()
        {
            InitializeComponent();
            load();
        }
        
        private void load()
        {
            RequestTCHeaderBUS.Instance.GetData(gcRequestTCHeader);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (RequestTCHeaderBUS.Instance.DeleteDataById(gvRequestTCHeader)) {
                MessageBox.Show("Xóa thành công!");
                load();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
    }
}
