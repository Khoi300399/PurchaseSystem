using DevExpress.XtraBars;
using PurchaseSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PurchaseSystem
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private ucStorekeeper ucStorekeeper;
        public frmMain()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            if (ucStorekeeper == null)
            {
                ucStorekeeper = new ucStorekeeper();
                ucStorekeeper.Dock = DockStyle.Fill;
                ucStorekeeper.BringToFront();

                mainContainer.Controls.Add(ucStorekeeper);

            }
            else
                ucStorekeeper.BringToFront();
        }
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
           


        }

      

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }
    }
}
