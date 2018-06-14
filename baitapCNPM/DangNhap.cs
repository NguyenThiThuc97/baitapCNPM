using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitapCNPM.DAL;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Win32;
using System.Data.Sql;
namespace baitapCNPM
{
    public partial class DangNhap : Form
    {
        DBMain db = new DBMain();

        public DangNhap()
        {
            InitializeComponent();
            txtPass.Properties.PasswordChar = '*';
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool test = db.accesssDB(txtUser.Text, txtPass.Text);
            if(test)
            {
                CuaHang main = new CuaHang();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Lỗi!!");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9)
                btnOK.PerformClick();
        }
    }
}
