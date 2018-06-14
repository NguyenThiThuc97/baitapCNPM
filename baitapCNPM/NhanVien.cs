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

namespace baitapCNPM
{
    public partial class NhanVien : Form
    {
        MemoryStream ms;
        byte[] arrImage;
        BL_NhanVien nhanvien = new BL_NhanVien();
        DataSet ds = new DataSet();
        DataSet dscmbChuyen = new DataSet();
        DataSet dscmbQuyen = new DataSet();
        DataSet dsNV = new DataSet();
        bool f;
        public NhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;

                btnHuy.Enabled = false;
                btnRefresh.Enabled = false;
                panelSearch.Enabled = true;
                panelInfor.Enabled = false;
                ds = nhanvien.LayNhanVien();
                dgvNhanVien.DataSource = ds.Tables[0];
                LoadChuyen();
                LoadQuyen();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn không có quyền truy cập");
                this.Close();
            }
            //btnTimKiem.Enabled = true;
            //btnSelectImg.Enabled = false;
            //txtMaNV_Search.Enabled = true;
            //txtMaVN.Enabled = false;
            //txtHo_ChuLot.Enabled = false;
            //txtTen.Enabled = false;
            //txtSDT.Enabled = false;
            //txtMatKhau.Enabled = false;
            //rbNam.Enabled = false;
            //rbNu.Enabled = false;
            //dtpNgaySinh.Enabled = false;
            //cmbChuyen.Enabled = false;


        }
        void LoadChuyen()
        {
            try
            {

                dscmbChuyen = nhanvien.LayChuyen();
                cmbChuyen.DataSource = dscmbChuyen.Tables[0];
                cmbChuyen.DisplayMember = "chucnang";
                cmbChuyen.ValueMember = "machuyen";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadQuyen()
        {
            try
            {

                dscmbQuyen = nhanvien.LayQuyen();
                cmbQuyen.DataSource = dscmbQuyen.Tables[0];
                cmbQuyen.DisplayMember = "tenquyen";
                cmbQuyen.ValueMember = "maquyen";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadData();
            panelInfor.Enabled = true;
            txtMaVN.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            f = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadData();
            panelInfor.Enabled = true;
            txtMaVN.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            f = false;

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dsNV = nhanvien.TimKiem(txtMaNV_Search.Text);
                dgvNhanVien.DataSource = dsNV.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "D:\\DATA";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                ptbImage.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                ptbImage.Image.Save(ms, ptbImage.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                int r = dgvNhanVien.CurrentCell.RowIndex;
                
                string MaNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    string err = "";
                    bool trangthai = nhanvien.XoaNhanVien(MaNV, ref err);
                    if (trangthai)
                    {

                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string chuyenchuyen = "";
            if (cmbChuyen.Text == "Ti Vi")
            {
                chuyenchuyen = "Chuyen1";
            }
            else
            {
                if (cmbChuyen.Text == "Smart Phone")
                {
                    chuyenchuyen = "Chuyen2";

                }
                else
                {
                    if (cmbChuyen.Text == "Điện lạnh")
                    {
                        chuyenchuyen = "Chuyen3";

                    }
                    else
                    {
                        if (cmbChuyen.Text == "Điện gia dụng")
                        {
                            chuyenchuyen = "Chuyen4";

                        }
                        else
                        {

                            if (cmbChuyen.Text == "Thiết bị khác")
                            {
                                chuyenchuyen = "Chuyen5";

                            }
                            else
                            {

                                chuyenchuyen = "Chuyen6";

                            }

                        }
                    }
                }
            }
            string quyenquyen = "";
            if (cmbQuyen.Text == "Chức năng của tiếp tân 1")
            {
                quyenquyen = "Quyen1";
            }
            else
            {
                quyenquyen = "Quyen2";
            }
            int GioiTinh = 0;
            if (rbNam.Checked)
                GioiTinh = 0;
            else
                GioiTinh = 1;
            try
            {
                if (f)
                {
                    string err = "";
                    bool trangthai = false;
                    bool trangthai_ = false;

                    try
                    {
                        trangthai = nhanvien.ThemNhanVien(txtMaVN.Text, txtHo_ChuLot.Text, txtTen.Text, GioiTinh, dtpNgaySinh.Value.ToString("MM/dd/yyyy"), double.Parse(txtSDT.Text), arrImage, txtMatKhau.Text, chuyenchuyen, ref err);
                        trangthai_ = nhanvien.ThemQuyen(txtMaVN.Text, quyenquyen, ref err);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (trangthai)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!!! \n " + txtMaVN.Text+"\n" + txtHo_ChuLot.Text + "\n" + txtTen.Text + "\n" + GioiTinh + "\n" + dtpNgaySinh.Value.ToString("MM/dd/yyyy") + "\n" + double.Parse(txtSDT.Text) + "\n" + txtMatKhau.Text + "\n" + chuyenchuyen + "\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    if (trangthai_)
                    {
                        MessageBox.Show("Thêm quyền thành công!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("Thêm quyền thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    string err = "";
                    bool trangthai = false;
                    bool trangthai_ = false;
                    try
                    {
                        trangthai = nhanvien.SuaNhanVien(txtMaVN.Text, txtHo_ChuLot.Text, txtTen.Text, GioiTinh, dtpNgaySinh.Value.ToString("MM/dd/yyyy"), double.Parse(txtSDT.Text), arrImage, txtMatKhau.Text, chuyenchuyen, ref err);
                        trangthai_ = nhanvien.SuaQuyen(txtMaVN.Text, quyenquyen, ref err);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    if (trangthai)
                    {
                        MessageBox.Show("UPDATE nhân viên Successfull !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Can not  UPDATE nhân viên !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    if (trangthai_)
                    {
                        MessageBox.Show("UPDATE quyền thành công!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("UPDATE quyền thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            this.txtMaVN.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtHo_ChuLot.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtTen.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            if (bool.Parse(dgvNhanVien.Rows[r].Cells[3].Value.ToString()) == true)
                rbNu.Checked = true;
            else
            {
                rbNam.Checked = true;
            }

            this.dtpNgaySinh.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtSDT.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            

            this.ptbImage.Image = (System.Drawing.Image)dgvNhanVien.Rows[r].Cells[6].FormattedValue;
            this.txtMatKhau.Text = dgvNhanVien.Rows[r].Cells[7].Value.ToString();
            this.cmbChuyen.Text = dgvNhanVien.Rows[r].Cells[8].Value.ToString();
            this.cmbQuyen.Text= dgvNhanVien.Rows[r].Cells[9].Value.ToString();
        }
    }
}
