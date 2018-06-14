create procedure [dbo].[LoadDsKH] as
begin
	select * from DsKhachHang
end
go
--------------------
create PROC [dbo].[sp_XoaKhachHang]
		@MaKH NvarCHAR(50)
		AS
		BEGIN
		declare @MaPhieu  nvarchar(50),@MaHD nvarchar(50),@MaThietBiKH nvarchar(50)
		select @MaPhieu=MaPhieu from Phieu where MaKH=@MaKH
		select @MaHD=MaHD from HoaDon where MaKH=@MaKH
		
		delete from ChiTietPhieu where MaPhieu=@MaPhieu
	delete from CHiTietHoaDon where MaHD=@MaHD
	delete from Phieu where MaPhieu=@MaPhieu
		delete from HoaDon where MaHD=@MaHD
		delete from DSThietBiKH where MaKH=@MaKH
	delete from DsKhachHang where MaKH=@MaKH	
		END
		go
---------------------------------
		create PROCEDURE [dbo].[SuaKhachHang]
	 @MaKH nvarchar(50), 
	 @TenKH nvarchar(50), 
	 @SoDienThoai numeric(18,0),
	   @GioiTinh nvarchar(50),
	 @DiaChi nvarchar(50)
	AS
	BEGIN
		UPDATE DsKhachHang SET TenKH=@TenKH, SoDienThoai=@SoDienThoai,DiaChi=@DiaChi,GioiTinh=@GioiTinh
							 WHERE  MaKH=@MaKH
    END
	go
	--------------------------------------------
	create proc [dbo].[_DsTBKH_]
	as
	begin
	select* from DSThietBiKH
	end
	go
	--
	create PROCEDURE [dbo].[sp_XoaThietBiKH]
		@MaThietBiKH NvarCHAR(50)
		AS
		BEGIN
			DELETE from ChiTietPhieu where MaThietBiKH=@MaThietBiKH
			DELETE from ChiTietHoaDon where MaThietBiKH=@MaThietBiKH
			DELETE from DSThietBiKH where MaThietBiKH=@MaThietBiKH
		END
	go
	--------------------------
	create PROCEDURE [dbo].[SuaDSThietBiKH]
	@MaThietBiKH nvarchar(50), 
	@TenThietBiKH nvarchar(50),
	@MaKH nvarchar(50),
	@MaChuyen char(10),
@ThuocNhom nvarchar(50),
	@NgayHetHanBaoHanh date
	AS
		BEGIN
				UPDATE DSThietBiKH SET  TenThietBiKH=@TenThietBiKH,MaKH=@MaKH,
				MaChuyen=@MaChuyen,ThuocNhom=@ThuocNhom,NgayHetHanBaoHanh=@NgayHetHanBaoHanh WHERE MaThietBiKH=@MaThietBiKH 
		end
		go
		---
		 create proc [dbo].[_TongHopPhieu]
as
begin
select  * from Phieu
 end
 go
 -------------------
 create proc [dbo].[DsTB_MaKH]
		@MaKH nvarchar(50)
		as
		begin
		select MaThietBiKH,TenThietBiKH,MaChuyen,ThuocNhom,NgayHetHanBaoHanh from DsKhachHang, DSThietBiKH
		 where DSThietBiKH.MaKH =@MaKH
		 group by DSThietBiKH.MaKH, MaThietBiKH, TenThietBiKH, MaChuyen, ThuocNhom, NgayHetHanBaoHanh
		end
		go
		---------------------
		create PROCEDURE [dbo].[ThemKhachHang]
	 @MaKH nvarchar(50), 
	 @TenKH nvarchar(50), 
	 @SoDienThoai numeric(18,0),
	  @GioiTinh nvarchar(50),
	  @DiaChi nvarchar(50)
	AS
		BEGIN
			INSERT INTO DsKhachHang VALUES  (@MaKH,@TenKH,@SoDienThoai,@GioiTinh,@DiaChi)       
		END
		go
		--------------------
		create PROCEDURE [dbo].[ThemDSThietBiKH]
	@MaThietBiKH nvarchar(50), 
	@TenThietBiKH nvarchar(50),
	@MaKH nvarchar(50),
	@MaLoaiTB nvarchar(50),
	@ThuocNhom nvarchar(50),
	@NgayHetHanBaoHanh date
	AS
		BEGIN
			INSERT INTO DSThietBiKH VALUES  (@MaThietBiKH,@TenThietBiKH,@MaKH,@MaLoaiTB,@ThuocNhom,@NgayHetHanBaoHanh)       
		END
		go
		----------------------
		create PROCEDURE [dbo].[ThemPhieuHen]
	@MaPhieu nvarchar(50), 
	@MaKH nvarchar(50),
	@MaNhanVien nvarchar(50),
	@NgayTra date
	AS
		BEGIN
		declare @NgayLap datetime
		set @NgayLap=getdate()
			INSERT INTO Phieu VALUES  (@MaPhieu,@MaKH,@MaNhanVien,@NgayLap,@NgayTra)          
		END
		go
		------------------
		create PROCEDURE [dbo].[ThemChiTietPhieu]
	@MaPhieu nvarchar(50), 
	@MaThietBiKH nvarchar(50)
	AS
		BEGIN
			INSERT INTO ChiTietPhieu VALUES  (@MaPhieu,@MaThietBiKH)       
		END
		go
		------------------
		create function [dbo].[ThoiGianConLai](@MaTB nvarchar(50))
		returns int 
		as
		 begin
		 declare @ConLai int,@ngayHetHan datetime
		 select @ngayHetHan= NgayHetHanBaoHanh from DSThietBiKH where MaThietBiKH=@MaTB
			if(convert(int,@ngayHetHan)-convert(int,getdate())>=0)
				set @Conlai=0;
			else
				set @Conlai=convert(int,getdate())-convert(int,@ngayHetHan);
			return @Conlai;
		 end
		 go
		 -----------------------
		 create PROCEDURE [dbo].[Update_DsThietBiKH_ThoiHan]
	@MaThietBiKH nvarchar(50), 
	@ThuocNhom nvarchar(50),
	@NgayHetHanBaoHanh datetime
	AS
	BEGIN
	
		UPDATE DSThietBiKH SET ThuocNhom=@ThuocNhom,NgayHetHanBaoHanh=@NgayHetHanBaoHanh
							 WHERE  MaThietBiKH=@MaThietBiKH
    END
	go

	--------------
	create PROCEDURE [dbo].[sp_ThemChiTietHDHoaDon]
@MaHD nvarchar(50),
@MaThietBiKH nvarchar(50) ,
@MaThietBiCY char(10) ,
@MaNHanVienSuaChua  char(10) ,
@TinhTrangTB nvarchar(50) ,
@ChiTietSuaCHua nvarchar(50) ,
@DonGia varchar(50) ,
@SoLuong nvarchar(50) ,
@ThanhTien Money ,--=Soluong*DonGia
@GhiChu nvarchar(50),
@TrucTrac nvarchar(50)
	AS
		BEGIN
			
			INSERT INTO ChiTietHoaDon VALUES  (@MaHD,@MaThietBiKH,@MaThietBiCY,@MaNHanVienSuaChua,@TinhTrangTB,@ChiTietSuaCHua,@DonGia,@SoLuong,@ThanhTien,@GhiChu,@TrucTrac)          
		END
		go
		-------------
		create PROCEDURE [dbo].[sp_ThemHoaDon]
	@MaHD nvarchar(50), 
	@MaKH nvarchar(50),
	@MaNhanVienHD nvarchar(50),
	@ChiPhiChinhSua Money ,
	@ChiPhiLinhKien Money,
	@TongChiPhi Money
	AS
		BEGIN
			INSERT INTO HoaDon VALUES  (@MaHD,@MaKH,@MaNhanVienHD,getdate(),@ChiPhiChinhSua,@ChiPhiLinhKien,@TongChiPhi)          
		END
		go
		------------------
		create function [dbo].[TinhHoaDon](@MaHD nvarchar(50))------lay
		returns Money 
		as
		 begin
		 declare @Tien Money=0,@TB nvarchar(50),@SoTB int=0,@LinhKien money=0,@ThietBiBaoHanh nvarchar(50),@TrucTrac nvarchar(50)
		 declare @DeDemSoTB int,@DeDemTrucTrac int,@DemTB int,@Dem2 int,@Dem3 int,@a int,@b int,@TienCT money,@TienCT1 money,@TienCT2 money,@TienCT3 money
		select @DeDemSoTB=count(MaThietBiKH) from ChiTietHoaDon where MaHD=@MaHD 
			select @DeDemTrucTrac=count(TrucTrac) from ChiTietHoaDon where MaHD=@MaHD and TrucTrac=''-- sua chua hay bao hanh.
			select @TB =MaThietBiKH from ChiTietHoaDon where MaHD=@MaHD 
			--
			select @TienCT= sum(ThanhTien) from ChiTietHoaDon,DSThietBiKH where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and ThuocNhom =N'Bảo hành' and TrucTrac =''
			 --
			if exists(select * from DSThietBiKH,ChiTietHoaDon where MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and ThuocNhom =N'Sửa chữa')
			begin
				select @TienCT3=sum(ThanhTien) from ChiTietHoaDon,DSThietBiKH where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and ThuocNhom =N'Sửa chữa'
			end 
			else
				set @TienCT3=0;
			 --
			 select @TienCT1=sum(ThanhTien) from ChiTietHoaDon where MaHD=@MaHD 
			 --
			 set @TienCT2=@TienCT1-@TienCT;
			if(@DeDemSoTB=@DeDemTrucTrac)
			begin
				select @DemTB= count(ChiTietHoaDon.MaThietBiKH) from DSThietBiKH,ChiTietHoaDon  where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and  ThuocNhom=N'Bảo hành'
				set @Dem2=@DeDemSoTB-@DemTB--dem sua chua.
				set @Tien=@Dem2*10+@TienCT3;
			end
			else
				--if(@DeDemSoTB>@DeDemTrucTrac)
				begin
					set @Dem3=@DeDemSoTB-@DeDemTrucTrac;--3-2=1
					select @DemTB= count(ChiTietHoaDon.MaThietBiKH) from DSThietBiKH,ChiTietHoaDon  where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and  ThuocNhom =N'Sửa chữa'--1
					set @a=@DemTB+@Dem3--dem sua chua.  1+1
					
					set @Tien=@a*10+@TienCT2;
				end
			return @Tien;
		 end

go
--------------
create function [dbo].[ChiPhiLK](@MaHD nvarchar(50))------lay
		returns Money 
		as
		 begin
		 declare @Tien Money=0,@TB nvarchar(50),@SoTB int=0,@LinhKien money=0,@ThietBiBaoHanh nvarchar(50),@TrucTrac nvarchar(50)
		 declare @DeDemSoTB int,@DeDemTrucTrac int,@DemTB int,@Dem2 int,@Dem3 int,@a int,@b int,@TienCT money,@TienCT1 money,@TienCT2 money,@TienCT3 money
		select @DeDemSoTB=count(MaThietBiKH) from ChiTietHoaDon where MaHD=@MaHD 
			select @DeDemTrucTrac=count(TrucTrac) from ChiTietHoaDon where MaHD=@MaHD and TrucTrac=''-- sua chua hay bao hanh.
			select @TB =MaThietBiKH from ChiTietHoaDon where MaHD=@MaHD 
			--
			select @TienCT= sum(ThanhTien) from ChiTietHoaDon,DSThietBiKH where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and ThuocNhom =N'Bảo hành' and TrucTrac =''
			 --
			if exists(select * from DSThietBiKH,ChiTietHoaDon where MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and ThuocNhom =N'Sửa chữa')
			begin
				select @TienCT3=sum(ThanhTien) from ChiTietHoaDon,DSThietBiKH where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and ThuocNhom =N'Sửa chữa'
			end 
			else
				set @TienCT3=0;
			 --
			 select @TienCT1=sum(ThanhTien) from ChiTietHoaDon where MaHD=@MaHD 
			 --
			 set @TienCT2=@TienCT1-@TienCT;
			if(@DeDemSoTB=@DeDemTrucTrac)
			begin
				
				set @Tien=@TienCT3;
			end
			else
				--if(@DeDemSoTB>@DeDemTrucTrac)
				begin	
					set @Tien=@TienCT2;
				end
			return @Tien;
		 end
		 go
		 ------------------------
		 create function [dbo].[CPSC](@MaHD nvarchar(50))------lay
		returns Money 
		as
		 begin
		 declare @Tien Money=0,@TB nvarchar(50),@SoTB int=0,@LinhKien money=0,@ThietBiBaoHanh nvarchar(50),@TrucTrac nvarchar(50)
		 declare @DeDemSoTB int,@DeDemTrucTrac int,@DemTB int,@Dem2 int,@Dem3 int,@a int,@b int,@TienCT money,@TienCT1 money,@TienCT2 money,@TienCT3 money
		select @DeDemSoTB=count(MaThietBiKH) from ChiTietHoaDon where MaHD=@MaHD 
			select @DeDemTrucTrac=count(TrucTrac) from ChiTietHoaDon where MaHD=@MaHD and TrucTrac=''-- sua chua hay bao hanh.
			select @TB =MaThietBiKH from ChiTietHoaDon where MaHD=@MaHD 
			if(@DeDemSoTB=@DeDemTrucTrac)
			begin
				select @DemTB= count(ChiTietHoaDon.MaThietBiKH) from DSThietBiKH,ChiTietHoaDon  where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and  ThuocNhom=N'Bảo hành'
				set @Dem2=@DeDemSoTB-@DemTB--dem sua chua.
				set @Tien=@Dem2*10;
			end
			else
				--if(@DeDemSoTB>@DeDemTrucTrac)
				begin
					set @Dem3=@DeDemSoTB-@DeDemTrucTrac;--3-2=1
					select @DemTB= count(ChiTietHoaDon.MaThietBiKH) from DSThietBiKH,ChiTietHoaDon  where 
			 MaHD=@MaHD and DSThietBiKH.MaThietBiKH=ChiTietHoaDon.MaThietBiKH and  ThuocNhom =N'Sửa chữa'--1
					set @a=@DemTB+@Dem3--dem sua chua.  1+1
					
					set @Tien=@a*10;
				end
			return @Tien;
		 end
		 go
		 -------------
		 create PROCEDURE [dbo].[SuaHoaDonIt]
	@MaHD nvarchar(50), 
	@ChiPhiSuaChua nvarchar(50) ,
	@ChiPhiLinhKien nvarchar(50),
	@TongChiPhi nvarchar(50)
	AS
	BEGIN
		UPDATE HoaDon SET ChiPhiSuaChua=@ChiPhiSuaChua,
				ChiPhiLinhKien=@ChiPhiLinhKien ,TongChiPhi=@TongChiPhi WHERE MaHD=@MaHD
    END
	go
	-----------
	create PROCEDURE [dbo].[sp_XoaPhieuHen]
		@MaPhieu NvarCHAR(50)
		AS
		BEGIN
			DELETE from ChiTietPhieu where MaPhieu=@MaPhieu
			DELETE from Phieu where MaPhieu=@MaPhieu
			print'xoa xong roi'	
		END
		exec sp_XoaKhachHang 'P1'
		go
		---------
		create PROCEDURE [dbo].[sp_XoaCHiTietPhieuHen]
		@MaPhieu NvarCHAR(50),
		@MaThietBiKH NvarCHAR(50)
		AS
		BEGIN
			DELETE from ChiTietPhieu where MaPhieu=@MaPhieu and MaThietBiKH=MaThietBiKH
			print'xoa xong roi'	
		END
		go
		----------
		create PROCEDURE [dbo].[SuaPhieuHen]
	@MaPhieu nvarchar(50), 
	@NgayTra datetime
	AS
		BEGIN
		UPDATE Phieu SET 
				NgayTra=@NgayTra WHERE @MaPhieu=MaPhieu
    END
	go
	-----------------
	create proc [dbo].[XoaHD]
		@MaHD nvarchar(50)
		as
		begin
		delete from ChiTietHoaDon where MaHD=@MaHD
		delete from HoaDon where MaHD=@MaHD
		end
		go
		---------------
		create proc [dbo].[XoaChiTietHD]
	@MaHD nvarchar(50),
	@MaThietBiKH nvarchar(50),
	@MaThietBiCY char(10)
	as
	begin
		 delete from ChiTietHoaDon  where MaHD=@MaHD and MaThietBiKH=@MaThietBiKH and MaThietBiCY=@MaThietBiCY
	end
	go