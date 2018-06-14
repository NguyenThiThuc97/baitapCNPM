
------------------------------------------------------

create table DsKhachHang
(
MaKH nvarchar(50) primary key,
TenKH nvarchar(50) ,
SodienThoai nvarchar(50),
GioiTinh nvarchar(50),
DiaCHi nvarchar(50),
)
go

create table DSThietBiKH
(
MaThietBiKH nvarchar(50) primary key,
TenThietBiKH nvarchar(50),
MaKH nvarchar(50) ,
MaChuyen char(10),
ThuocNhom nvarchar(50),
NgayHetHanBaoHanh datetime,
constraint DsKhachHang_fkDSThietBiKH foreign key(MaKH)references DsKhachHang(MaKH),
constraint LoaiTB_fkDSDSThietBiKH foreign key(MaChuyen)references Chuyen(MaChuyen)
)

go

----------------------------------------------

create table HoaDon
(
MaHD nvarchar(50) primary key,
MaKH nvarchar(50) ,
MaNHanVienHD nvarchar(100),
NgayLap date,
ChiPhiSuaChua Money,
ChiPhiLinhKien Money,
TongChiPhi Money,
constraint NhanVien_fkHoaDon foreign key(MaNHanVienHD)references NhanVien(MaNV),
constraint DsKhachHang_fkHoaDon foreign key(MaKH)references DsKhachHang(MaKH)
)
go

--------------------------------------------------
create table ChiTietHoaDon
(
MaHD nvarchar(50),
MaThietBiKH nvarchar(50) ,
MaThietBiCY char(10) ,
MaNHanVienSuaChua  nvarchar(100) ,
TinhTrangTB nvarchar(50) ,
ChiTietSuaCHua nvarchar(50) ,
DonGia Money,
SoLuong int,
ThanhTien Money,
GhiChu nvarchar(50) ,
TrucTrac nvarchar(50) ,
primary key(MaHD,MaThietBiKH,MaThietBiCY),
constraint HoaDon_fkChiTietHoaDon foreign key(MaHD)references HoaDon(MaHD),
constraint DSThietBiCongTy_fkChiTietHoaDon foreign key(MaThietBiCY)references SanPham(MaSP),
constraint NhanVien_fkChiTietHoaDon foreign key(MaNHanVienSuaChua)references NhanVien(MaNV)
)
go


-----------------------------------------------------
create table Phieu
(
MaPhieu nvarchar(50) primary key,
MaKH nvarchar(50) ,
MaNhanVien  nvarchar(100),
NgayLap datetime,
Ngaytra datetime,
constraint DsKhachHang_fkPhieu foreign key(MaKH)references DsKhachHang(MaKH),
constraint NhanVien_fkPhieu foreign key(MaNhanVien)references NhanVien(MaNV)
)
go

-----------------------------------
create table ChiTietPhieu
(
MaPhieu nvarchar(50),
MaThietBiKH nvarchar(50) ,
primary key (MaPhieu,MaThietBiKH),
constraint Phieu_fkChiTietPhieu foreign key(MaPhieu)references Phieu(MaPhieu),
constraint DsThietBiKH_fkChiTietPhieu foreign key(MaThietBiKH)references DsThietBiKH(MaThietBiKH),
)
go
---------------------------------
