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
using ThuNhe.DALPlayer;
namespace ThuNhe
{
    public partial class FrmKhachHang : Form
    {
        BAL_DSKH kh = new BAL_DSKH();
        DataSet ds = new DataSet();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            ds = kh.DsKhachHang();
            DaViewDsKH.DataSource = ds.Tables[0];
        }

        private void DaViewDsKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaViewDsKH.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.TxtMaKH2.Text =
            DaViewDsKH.Rows[r].Cells[1].Value.ToString();
            TxtKH.Text =
            DaViewDsKH.Rows[r].Cells[2].Value.ToString();
            this.TxtSoDienThoai2.Text =
            DaViewDsKH.Rows[r].Cells[3].Value.ToString();
            //
            string t = "Nữ";
            if (DaViewDsKH.Rows[r].Cells[4].Value.ToString() == t)
                RaBtnNu.Checked = true;
            else
                RaBtnNam.Checked = true;
            //

            this.TxtDiaChi.Text =
            DaViewDsKH.Rows[r].Cells[5].Value.ToString();
            //
            if (e.RowIndex > -1)
            {
                string command = DaViewDsKH.Columns[e.ColumnIndex].Name;
                if (command == "BtnXoa") // colbtn là tên cột chứa button
                {
                    try
                    {
                        //lấy hàng cần xóa
                        int r1 = DaViewDsKH.CurrentCell.RowIndex;
                        //lfấy mã khách hàng
                        string makh = DaViewDsKH.Rows[r1].Cells[1].Value.ToString();
                        //hỏi xem có muốn xóa không
                        DialogResult traloi;
                        traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (traloi == DialogResult.OK)
                        {
                            string err = "";
                            bool trangthai = kh.XoaKH(makh, ref err);
                            if (trangthai)
                            {

                                MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds = kh.DsKhachHang();
                                DaViewDsKH.DataSource = ds.Tables[0];
                                TxtDiaChi.ResetText();
                                TxtKH.ResetText();
                                TxtMaKH2.ResetText();
                                TxtSoDienThoai2.ResetText();

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

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSoDienThoai2.Text == null || TxtKH.Text == null)
                {
                    MessageBox.Show("Bạn nên nhâp thông tin vào!");
                }
                else
                {
                   
                    ds = kh.TimKiemKhacHang(TxtSoDienThoai2.Text);
                    DaViewDsKH.DataSource = ds.Tables[0];
                }
            }
            catch
            {

            }
        }

        private void BtnChinhSua_Click(object sender, EventArgs e)
        {
            String Bien2 = "";
            if (RaBtnNu.Checked)
                Bien2 = "Nữ";
            else
            {
                if (RaBtnNam.Checked)
                {
                    Bien2 = "Nam";
                }
            }
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.CapNhatKH(TxtMaKH2.Text, TxtKH.Text, TxtSoDienThoai2.Text, Bien2, TxtDiaChi.Text, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (trangthai)
            {
                MessageBox.Show("Sữa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh.DsKhachHang();
                DaViewDsKH.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không sữa được dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnQuayLoai_Click(object sender, EventArgs e)
        {
            ds = kh.DsKhachHang();
            DaViewDsKH.DataSource = ds.Tables[0];
        }

        private void BtnExe_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    KetNoiExcel _excel = new KetNoiExcel(saveFileDialog1.FileName);
                    String sqlHeader = "create table [DsKhachHang]([MaKH] nvarchar(50),[TenKH] nvarchar(50),[SodienThoai] nvarchar(50),[GioiTinh] nvarchar(50),[DiaCHi] nvarchar(50))";
                    _excel.ExecuteNonQuery(sqlHeader);
                    for (int i = 0; i < DaViewDsKH.Rows.Count; i++)
                    {
                        String sql = "insert into [DsKhachHang] values ('" + DaViewDsKH.Rows[i].Cells["MaKH"].Value.ToString() + "','" + DaViewDsKH.Rows[i].Cells["TenKH"].Value.ToString() + "','" + DaViewDsKH.Rows[i].Cells["SodienThoai"].Value.ToString() + "','" + DaViewDsKH.Rows[i].Cells["GioiTinh"].Value.ToString() + "','" + DaViewDsKH.Rows[i].Cells["DiaCHi"].Value.ToString() + "')";
                        _excel.ExecuteNonQuery(sql);
                    }
                    MessageBox.Show("Xuat thanh cong");
                }
            }
            catch 
            {
            }
        }
    }
}
