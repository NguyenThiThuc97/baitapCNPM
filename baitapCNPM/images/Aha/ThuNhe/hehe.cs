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
    public partial class hehe : Form
    {
        public hehe()
        {
            InitializeComponent();
        }
        public String temp;
        private void hehe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoHanh_SChuaDataSet.XuatPhieu' table. You can move, or remove it, as needed.
            this.XuatPhieuTableAdapter.Fill(this.BaoHanh_SChuaDataSet.XuatPhieu,temp);

            this.reportViewer1.RefreshReport();
        }
    }
}
