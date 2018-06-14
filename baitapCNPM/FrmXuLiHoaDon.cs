using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using baitapCNPM.BAL;
namespace ThuNhe
{
    public partial class FrmXuLiHoaDon : Form
    {
        BAL_XuLyHoaDon kh = new BAL_XuLyHoaDon();
        DataSet ds = new DataSet();
        public FrmXuLiHoaDon()
        {
            InitializeComponent();
        }

        private void DaHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmXuLiHoaDon_Load(object sender, EventArgs e)
        {
            ds = kh.DsHoaDon();
            DaHD.DataSource = ds.Tables[0];
            //
            ds = kh.DsCTHoaDon();
            DaCTHD.DataSource = ds.Tables[0];
        }

        private void DaHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaHD.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            String Bien = DaHD.Rows[r].Cells[1].Value.ToString();
            // TxtDatimeDeadLIne.Text = Bien;
            ds = kh.DanhSachChiTietHD(Bien);
            DaCTHD.DataSource = ds.Tables[0];
            //
            if (e.RowIndex > -1)
            {
                string command = DaHD.Columns[e.ColumnIndex].Name;
                if (command == "BtnXoa") // colbtn là tên cột chứa button
                {
                    try
                    {
                        //lấy hàng cần xóa
                        int r1 = DaHD.CurrentCell.RowIndex;
                        //lfấy mã khách hàng
                        string MaHD = DaHD.Rows[r1].Cells[1].Value.ToString();
                        //hỏi xem có muốn xóa không
                        DialogResult traloi;
                        traloi = MessageBox.Show("Bạn có muốn xóa không? '"+MaHD+"'", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            string err = "";
                            bool trangthai = kh.XoaHD(MaHD, ref err);
                            if (trangthai)
                            {

                                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds = kh.DsHoaDon();
                                DaHD.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Không xóa được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {

                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
        }

        private void DaCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // Thứ tự dòng hiện hành 
            int r = DaCTHD.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            //   String Bien1 = DaCTHD.Rows[r].Cells[1].Value.ToString();
            String Bien = DaCTHD.Rows[r].Cells[1].Value.ToString();
            String Bien2 = DaCTHD.Rows[r].Cells[2].Value.ToString();
            String Bien3 = DaCTHD.Rows[r].Cells[3].Value.ToString();
            if (e.RowIndex > -1)
            {
                string command = DaCTHD.Columns[e.ColumnIndex].Name;
                if (command == "BtnXoaCt") // colbtn là tên cột chứa button
                {
                    try
                    {

                        DialogResult traloi;
                        traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            string err = "";
                            bool trangthai = kh.XoaHDCT(Bien, Bien2, Bien3, ref err);
                            if (trangthai)
                            {

                                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
                                ds = kh.DanhSachChiTietHD(Bien);
                                DaCTHD.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Không xóa được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {

                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void TxtHoaDon_TextChanged(object sender, EventArgs e)
        {
            ds = kh.TimKiemHoaDon(TxtHoaDon.Text);
            DaHD.DataSource = ds.Tables[0];
        }
    }
}
