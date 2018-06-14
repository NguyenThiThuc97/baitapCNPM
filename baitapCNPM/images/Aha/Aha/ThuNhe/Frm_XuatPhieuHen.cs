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
    public partial class Frm_XuatPhieuHen : Form
    {
        public Frm_XuatPhieuHen()
        {
            InitializeComponent();
        }
     public   String temp;
        private void Frm_XuatPhieuHen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoHanh_SChuaDataSet.ChiTietPhieu' table. You can move, or remove it, as needed.
            this.ChiTietPhieuTableAdapter.Fill(this.BaoHanh_SChuaDataSet.ChiTietPhieu, temp);
            // TODO: This line of code loads data into the 'BaoHanh_SChuaDataSet.Phieu' table. You can move, or remove it, as needed.
            this.PhieuTableAdapter.Fill(this.BaoHanh_SChuaDataSet.Phieu,temp);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
