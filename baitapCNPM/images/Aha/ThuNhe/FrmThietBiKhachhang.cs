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
    public partial class FrmThietBiKhachhang : Form
    {
        BAL_DsTBKH kh = new BAL_DsTBKH();
        DataSet ds = new DataSet();
        public FrmThietBiKhachhang()
        {
            InitializeComponent();
        }

        private void FrmThietBiKhachhang_Load(object sender, EventArgs e)
        {
            ds = kh._DsTBKH_();
            DaViewDsTB.DataSource = ds.Tables[0];
            //
            ds = kh._sp_DsLoaiTB();
            DaViewLoaiTB.DataSource = ds.Tables[0];
        }

        private void DaViewLoaiTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = DaViewLoaiTB.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.lbLoaiSP.Text =
            DaViewLoaiTB.Rows[r].Cells[0].Value.ToString();
        }

        private void DaViewDsTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaViewDsTB.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.TxtMaThietBi.Text =
            DaViewDsTB.Rows[r].Cells[1].Value.ToString();

            TxtTenTB.Text =
            DaViewDsTB.Rows[r].Cells[2].Value.ToString();

            TxtMaKH.Text =
           DaViewDsTB.Rows[r].Cells[3].Value.ToString();

            this.lbLoaiSP.Text =
            DaViewDsTB.Rows[r].Cells[4].Value.ToString();
            //
            string t = "Bảo hành";
            if (DaViewDsTB.Rows[r].Cells[5].Value.ToString() == t)
                RaBtnBaoHanh.Checked = true;
            else
                RaBtnSuaChua.Checked = true;
            //

            String Bien = DaViewDsTB.Rows[r].Cells[6].Value.ToString();
            TxtDatimeDeadLIne.Text = Bien;
            if (e.RowIndex > -1)
            {
                string command = DaViewDsTB.Columns[e.ColumnIndex].Name;
                if (command == "BtnXoa") // colbtn là tên cột chứa button
                {
                    try
                    {
                        //lấy hàng cần xóa
                        int r1 = DaViewDsTB.CurrentCell.RowIndex;
                        //lfấy mã khách hàng
                        string MaThietBiKH = DaViewDsTB.Rows[r1].Cells[1].Value.ToString();
                        //hỏi xem có muốn xóa không
                        DialogResult traloi;
                        traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            string err = "";
                            bool trangthai = kh.XoaKH(TxtMaThietBi.Text, ref err);
                            if (trangthai)
                            {

                                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds = kh._DsTBKH_();
                                DaViewDsTB.DataSource = ds.Tables[0];
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

        private void BtnChinhSua_Click(object sender, EventArgs e)
        {
            String Bien2 = "";
            if (RaBtnBaoHanh.Checked)
                Bien2 = "Bảo hành";
            else
            {
                if (RaBtnSuaChua.Checked)
                {
                    Bien2 = "Sửa chữa";
                }
            }
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.SuaDSThietBiKH(TxtMaThietBi.Text, TxtTenTB.Text, TxtMaKH.Text, lbLoaiSP.Text, Bien2, TxtDatimeDeadLIne.Text, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (trangthai)
            {
                MessageBox.Show("Sữa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh._DsTBKH_();
                DaViewDsTB.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không sữa được dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (TxtMaThietBi.Text == null || lbLoaiSP.Text == null)
                {
                    MessageBox.Show("Bạn nên nhâp thông tin vào!");
                }
                else
                {

                    ds = kh.TimKiemThietBiKhacHang(TxtMaThietBi.Text);
                    DaViewDsTB.DataSource = ds.Tables[0];
                }
            }
            catch
            {

            }
        }

        private void BtnQuayLoai_Click(object sender, EventArgs e)
        {
            ds = kh._DsTBKH_();
            DaViewDsTB.DataSource = ds.Tables[0];
        }
    }
}
