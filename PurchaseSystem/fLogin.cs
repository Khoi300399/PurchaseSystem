using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace PurchaseSystem
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

   


    

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (AuthBUS.Instance.AuthenticateUser(txtUsername.Text.ToString(), txtPassword.Text.ToString()))
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!","Cảnh báo!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}