using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuNhe
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnKH_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void BtnHD_Click(object sender, EventArgs e)
        {
            FromLapHoaDon f = new FromLapHoaDon();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmKhachHang f = new FrmKhachHang();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmThietBiKhachhang f = new FrmThietBiKhachhang();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPhieu f = new FrmPhieu();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmXuLiHoaDon f = new FrmXuLiHoaDon();
            f.ShowDialog();
        }
    }
}
