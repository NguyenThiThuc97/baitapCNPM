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
    public partial class Form1 : Form
    {
        BAL_KH_SP_Phieu kh = new BAL_KH_SP_Phieu();
        DataSet ds = new DataSet();
        String temp;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //lay du lieu 
            ds = kh.DsKhachHang();
            DaViewDsKHTK.DataSource = ds.Tables[0];
            //
            ds = kh._sp_DsLoaiTB();
            DaViewLoaiTB.DataSource = ds.Tables[0];

            //Phieu
            ds = kh._TongHopPhieu();
            DaViewDsPhieu.DataSource = ds.Tables[0];
            Txt_MaPhieu.Text=temp;
        }

        private void DaViewDsKHTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaViewDsKHTK.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.TxtMaKH2.Text =
            DaViewDsKHTK.Rows[r].Cells[0].Value.ToString();
            TxtKH.Text =
            DaViewDsKHTK.Rows[r].Cells[1].Value.ToString();
            this.TxtSoDienThoai2.Text =
            DaViewDsKHTK.Rows[r].Cells[2].Value.ToString();
            //
            string t = "Nữ";
           if( DaViewDsKHTK.Rows[r].Cells[3].Value.ToString()==t)
                 RaBtnNu.Checked = true;
            else
                RaBtnNam.Checked = true;
            //

            this.TxtDiaChi.Text =
            DaViewDsKHTK.Rows[r].Cells[4].Value.ToString();

            try
            {
                if (TxtMaKH2.Text != null )
                {

                    ds = kh._TimKiemDsTBKH(TxtMaKH2.Text);
                    DaViewDSThietBiKH.DataSource = ds.Tables[0];
                }
                else
                {
                    
                        MessageBox.Show("bạn cần nhập thông tin!");
                }
            }
            catch
            {

            }

        }

        private void DaViewDSThietBiKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DaViewDSThietBiKH.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.TxtMaThietBi.Text =
            DaViewDSThietBiKH.Rows[r].Cells[0].Value.ToString();
            TxtTenTB.Text =
            DaViewDSThietBiKH.Rows[r].Cells[1].Value.ToString();
            this.lbLoaiSP.Text =
            DaViewDSThietBiKH.Rows[r].Cells[2].Value.ToString();
            //
            string t = "Bảo hành";
            if (DaViewDSThietBiKH.Rows[r].Cells[3].Value.ToString() == t)
                RaBtnBaoHanh.Checked = true;
            else
                RaBtnSuaChua.Checked = true;
            //

           String Bien = DaViewDSThietBiKH.Rows[r].Cells[4].Value.ToString();
            TxtDatimeDeadLIne.Text = Bien;
         
        
            //String t = DPickerHetHan.Value.ToString("dd/mm/yyyy");
        }

        private void DaViewLoaiTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = DaViewLoaiTB.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.lbLoaiSP.Text =
            DaViewLoaiTB.Rows[r].Cells[0].Value.ToString();
        }

        private void BtnOK_Click(object sender, EventArgs e)
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
                trangthai = kh.ThemKhachHang(TxtMaKH2.Text, TxtKH.Text, TxtSoDienThoai2.Text, Bien2, TxtDiaChi.Text, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (trangthai)
            {
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh.DsKhachHang();
                DaViewDsKHTK.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnOKTBKH_Click(object sender, EventArgs e)
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
                if (RaBtnSuaChua.Checked)
                {
                    trangthai = kh.ThemDSThietBiKH(TxtMaThietBi.Text, TxtTenTB.Text, TxtMaKH2.Text,
                   lbLoaiSP.Text, Bien2, "", ref err);
                }
                else
                {
                    trangthai = kh.ThemDSThietBiKH(TxtMaThietBi.Text, TxtTenTB.Text, TxtMaKH2.Text,
                        lbLoaiSP.Text, Bien2, TxtDatimeDeadLIne.Text, ref err);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (trangthai)
            {
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               ds = kh._DSThietBiKH();
                DaViewDSThietBiKH.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void BtnLapPhieu_Click(object sender, EventArgs e)
        {
           
          
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.ThemPhieuHen(Txt_MaPhieu.Text,TxtMaKH2.Text,Txt_MaNV.Text,TxtNgayTra.Text,ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (trangthai)
            {
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh._TongHopPhieu();
                DaViewDsPhieu.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnChiTietPhieu_Click(object sender, EventArgs e)
        {
            //add vao chi tiet phieu
            string err1 = "";
            bool trangthai1 = false;
            try
            {
                trangthai1 = kh.ThemChiTietPhieuHen(Txt_MaPhieu.Text, TxtMaThietBi.Text, ref err1);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (trangthai1)
            {
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh._TongHopChiTietPhieuDK(Txt_MaPhieu.Text);
                DaViewDsChiTietHoaDon.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            
           
                ds = kh.TimKiemKhacHang(TxtSoDienThoai.Text);
                DaViewDsKHTK.DataSource = ds.Tables[0];

        }

        private void TxtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDatimeDeadLIne_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (RaBtnBaoHanh.Checked)
                {
                    ds = kh.SoNgayConLai(TxtMaThietBi.Text);
                    String t = ds.Tables[0].Rows[0][0].ToString();
                    int t1 = int.Parse(t.ToString());
                    MessageBox.Show("Thiết bị còn bảo hành " + t1 + "Ngày.");
                }
            }
            catch { }
        }

        private void Btn_CapNhatThietBI_Click(object sender, EventArgs e)
        {
            string err = "";
            bool trangthai = false;
            try
            {
                trangthai = kh.SuaDSThietBiKH(TxtMaThietBi.Text,"Sửa chữa", TxtDatimeDeadLIne.Text, ref err);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (trangthai)
            {
                MessageBox.Show("Sữa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds = kh._DSThietBiKH();
                DaViewDSThietBiKH.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không sữa được dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //in phieu.
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
