using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitapCNPM.BAL;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace baitapCNPM
{
    public partial class RP_ThongKeTonKho : Form
    {
        BL_SanPham sanpham = new BL_SanPham();
        DataSet ds = new DataSet();
        public RP_ThongKeTonKho()
        {
            InitializeComponent();
        }

        private void RP_ThongKeTonKho_Load(object sender, EventArgs e)
        {

            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ds = sanpham.SPTonKho(int.Parse(txtNam.Text));
            DataTable dt = ds.Tables[0];

            ReportDataSource datasource = new ReportDataSource("dsTonKho", ds.Tables[0]);
            this.rp_TKTonKho.LocalReport.DataSources.Clear();
            this.rp_TKTonKho.LocalReport.DataSources.Add(datasource);
            
            this.rp_TKTonKho.RefreshReport();
            


            
        }
    }
}
