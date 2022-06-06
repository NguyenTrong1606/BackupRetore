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
using System.Data.SqlClient;

namespace frmmain
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Program.id = txtTK.Text.Trim();
            Program.pw = txtMK.Text.Trim();
            if(Program.id.Length == 0 || Program.pw.Length == 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Program.connString= @"Data Source="+Program.servername+";User ID="+Program.id+";Password="+Program.pw+ ";Connection Timeout=5";
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng!\nVui lòng nhập lại.\n ", "Thông Báo");
            }
            else
            {
                new frmmain().Show();
                this.Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Program.servername;
        }
    }
}