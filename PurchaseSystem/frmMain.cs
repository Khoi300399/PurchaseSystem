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
        private ucPurchaseOrder ucMain;
        public frmMain()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            if (ucMain == null)
            {
                ucMain = new ucPurchaseOrder();
                ucMain.Dock = DockStyle.Fill;
                ucMain.BringToFront();

                mainContainer.Controls.Add(ucMain);

                stTitle.Caption = acePurchase.Text;

            }
            else
                ucMain.BringToFront();
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

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
