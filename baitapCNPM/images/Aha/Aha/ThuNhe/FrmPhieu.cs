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
using ThuNhe.BALPlayer;
namespace ThuNhe
{
    public partial class FrmPhieu : Form
    {
        BAL_Phieu kh = new BAL_Phieu();
        DataSet ds = new DataSet();
        public FrmPhieu()
        {
            InitializeComponent();
        }

        private void FrmPhieu_Load(object sender, EventArgs e)
        {
            ds = kh.DsPhieu();
            DaViewDSPhieu.DataSource = ds.Tables[0];
        }

        private void DaViewDSPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaViewDSPhieu.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.Txt_MaPhieu.Text =
            DaViewDSPhieu.Rows[r].Cells[1].Value.ToString();

            this.Txt_NgayTra.Text =
          DaViewDSPhieu.Rows[r].Cells[5].Value.ToString();
            //
            try
            {

               // int Vitri = DaViewDSPhieu.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
               // String t =
               // DaViewDSPhieu.Rows[Vitri].Cells[1].Value.ToString();
                ds = kh._TimKiemPhieuCT(Txt_MaPhieu.Text);
                    DaViewDSCTP.DataSource = ds.Tables[0];
                
            }
            catch
            {

            }
            //
            // xoa
            if (e.RowIndex > -1)
            {
                string command = DaViewDSPhieu.Columns[e.ColumnIndex].Name;
                if (command == "BtnXoa") // colbtn là tên cột chứa button
                {
                    try
                    {
                        //lấy hàng cần xóa
                        int r1 = DaViewDSPhieu.CurrentCell.RowIndex;
                        //lfấy mã khách hàng
                        string MaPhieu = DaViewDSPhieu.Rows[r1].Cells[1].Value.ToString();
                        //hỏi xem có muốn xóa không
                        DialogResult traloi;
                        traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            string err = "";
                            bool trangthai = kh.XoaKH(Txt_MaPhieu.Text, ref err);
                            if (trangthai)
                            {

                                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds = kh.DsPhieu();
                                DaViewDSPhieu.DataSource = ds.Tables[0];
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

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_MaPhieu.Text == null || Txt_NgayTra.Text == null)
                {
                    MessageBox.Show("Bạn nên nhâp thông tin vào!");
                }
                else
                {

                    ds = kh.TimKiemPhieu(Txt_MaPhieu.Text);
                    DaViewDSPhieu.DataSource = ds.Tables[0];
                }
            }
            catch
            {

            }
        }

        private void BtnCHinhSua_Click(object sender, EventArgs e)
        {
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.CapNhatKH(Txt_MaPhieu.Text,Txt_NgayTra.Text, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (trangthai)
            {
                MessageBox.Show("Sữa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh.DsPhieu();
                DaViewDSPhieu.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không sữa được dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnQuayLoai_Click(object sender, EventArgs e)
        {
            ds = kh.DsPhieu();
            DaViewDSPhieu.DataSource = ds.Tables[0];
        }

        private void DaViewDSCTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // xoa
            if (e.RowIndex > -1)
            {
                string command = DaViewDSCTP.Columns[e.ColumnIndex].Name;
                if (command == "Btn_Xoa2") // colbtn là tên cột chứa button
                {
                    try
                    {
                        //lấy hàng cần xóa
                        int r1 = DaViewDSCTP.CurrentCell.RowIndex;
                        //lfấy mã khách hàng
                        string MaPhieu = DaViewDSCTP.Rows[r1].Cells[1].Value.ToString();
                    string MaTB = DaViewDSCTP.Rows[r1].Cells[2].Value.ToString();
                       
                        //hỏi xem có muốn xóa không
                        DialogResult traloi;
                        traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            string err = "";
                            bool trangthai = kh.sp_XoaCHiTietPhieuHen(MaPhieu, MaTB, ref err);
                            if (trangthai)
                            {

                                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds = kh._TimKiemPhieuCT(Txt_MaPhieu.Text);
                                DaViewDSCTP.DataSource = ds.Tables[0];
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
    }
}
