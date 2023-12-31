create database [CuaHangDoAnNhanh]
go
USE [CuaHangDoAnNhanh]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_DoanhThuTheoThang]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[fn_DoanhThuTheoThang] (@thang int, @nam int)
RETURNS @DoanhThu TABLE (
    Ngay DATE,
    DoanhThu FLOAT
)
AS
BEGIN
    DECLARE @StartDate DATE
    DECLARE @EndDate DATE
    SET @StartDate = CAST(CAST(@nam AS VARCHAR) + '-' + CAST(@thang AS VARCHAR) + '-01' AS DATE)
    SET @EndDate = DATEADD(DAY, -1, DATEADD(MONTH, 1, @StartDate))
    
    INSERT INTO @DoanhThu (Ngay, DoanhThu)
    SELECT CONVERT(DATE, NgayNhap) AS Ngay, SUM(tongTien) AS DoanhThu
    FROM HoaDon
    WHERE NgayNhap BETWEEN @StartDate AND @EndDate
    GROUP BY CONVERT(DATE, NgayNhap)
    
    RETURN
END
GO
/****** Object:  Table [dbo].[ChiTiethoaDon]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTiethoaDon](
	[MaHoaDon] [char](10) NULL,
	[MaMonAn] [char](10) NULL,
	[soLuong] [int] NULL,
	[DonGia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiTietHoaDonBan]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHoaDonBan](
	[idChiTietHoaDonBan] [char](10) NULL,
	[idSanPham] [char](10) NULL,
	[soLuong] [int] NULL,
	[giaBan] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiTietHoaDonNhap]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHoaDonNhap](
	[idHoaDonNhap] [char](10) NULL,
	[idSanpham] [char](10) NULL,
	[soluong] [int] NULL,
	[DonGia] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [char](10) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](10) NOT NULL,
	[MaKhahHang] [char](10) NULL,
	[NgayNhap] [date] NULL,
	[loaiHoaDon] [nvarchar](50) NULL,
	[GiChu] [nvarchar](100) NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonBan]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonBan](
	[idHoaDonBan] [char](10) NOT NULL,
	[idNhanVien] [char](10) NULL,
	[idKhachHang] [char](10) NULL,
	[ngayBan] [date] NULL,
	[tongTien] [float] NULL,
 CONSTRAINT [PK_hoaDonBan] PRIMARY KEY CLUSTERED 
(
	[idHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonNhap]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonNhap](
	[idHoaDonNhap] [char](10) NOT NULL,
	[idNhanVien] [char](10) NOT NULL,
	[idNhaCC] [char](10) NOT NULL,
	[ngayNhap] [date] NOT NULL,
	[tongTien] [float] NOT NULL,
 CONSTRAINT [PK_hoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[idHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachHang]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachHang](
	[idKhachHang] [char](10) NOT NULL,
	[tenKhachHang] [nvarchar](50) NULL,
	[sdtKhachHang] [nchar](50) NULL,
 CONSTRAINT [PK_khachHang] PRIMARY KEY CLUSTERED 
(
	[idKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [char](10) NOT NULL,
	[tenMonAn] [nvarchar](50) NULL,
	[donGia] [int] NULL,
	[DonVi] [nvarchar](50) NULL,
	[MaDanhMuc] [char](10) NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhaCC]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhaCC](
	[idNhaCC] [char](10) NOT NULL,
	[tenNhaCC] [nvarchar](50) NULL,
	[sdtNhaCC] [char](12) NULL,
	[diaChiNhaCC] [nchar](10) NULL,
 CONSTRAINT [PK_nhaCC] PRIMARY KEY CLUSTERED 
(
	[idNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [char](10) NULL,
	[hoTen] [nvarchar](100) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[ngaySinh] [date] NULL,
	[SDT] [nchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RauCu]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RauCu](
	[idSanPham] [char](10) NOT NULL,
	[tenSanPham] [nvarchar](50) NULL,
	[loaiSanPham] [nvarchar](50) NULL,
	[donVi] [nvarchar](50) NULL,
	[giaBan] [int] NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_RauCu] PRIMARY KEY CLUSTERED 
(
	[idSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [char](100) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[MatKhau] [char](100) NULL,
	[quyen] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTiethoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiethoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTiethoaDon] CHECK CONSTRAINT [FK_ChiTiethoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTiethoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiethoaDon_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[ChiTiethoaDon] CHECK CONSTRAINT [FK_ChiTiethoaDon_MonAn]
GO
ALTER TABLE [dbo].[chiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHoaDonBan_hoaDonBan] FOREIGN KEY([idChiTietHoaDonBan])
REFERENCES [dbo].[hoaDonBan] ([idHoaDonBan])
GO
ALTER TABLE [dbo].[chiTietHoaDonBan] CHECK CONSTRAINT [FK_chiTietHoaDonBan_hoaDonBan]
GO
ALTER TABLE [dbo].[chiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHoaDonBan_RauCu] FOREIGN KEY([idSanPham])
REFERENCES [dbo].[RauCu] ([idSanPham])
GO
ALTER TABLE [dbo].[chiTietHoaDonBan] CHECK CONSTRAINT [FK_chiTietHoaDonBan_RauCu]
GO
ALTER TABLE [dbo].[chiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHoaDonNhap_hoaDonNhap] FOREIGN KEY([idHoaDonNhap])
REFERENCES [dbo].[hoaDonNhap] ([idHoaDonNhap])
GO
ALTER TABLE [dbo].[chiTietHoaDonNhap] CHECK CONSTRAINT [FK_chiTietHoaDonNhap_hoaDonNhap]
GO
ALTER TABLE [dbo].[chiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHoaDonNhap_RauCu] FOREIGN KEY([idSanpham])
REFERENCES [dbo].[RauCu] ([idSanPham])
GO
ALTER TABLE [dbo].[chiTietHoaDonNhap] CHECK CONSTRAINT [FK_chiTietHoaDonNhap_RauCu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_khachHang] FOREIGN KEY([MaKhahHang])
REFERENCES [dbo].[khachHang] ([idKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_khachHang]
GO
ALTER TABLE [dbo].[hoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_hoaDonBan_khachHang] FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[khachHang] ([idKhachHang])
GO
ALTER TABLE [dbo].[hoaDonBan] CHECK CONSTRAINT [FK_hoaDonBan_khachHang]
GO
ALTER TABLE [dbo].[hoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_hoaDonNhap_nhaCC] FOREIGN KEY([idNhaCC])
REFERENCES [dbo].[nhaCC] ([idNhaCC])
GO
ALTER TABLE [dbo].[hoaDonNhap] CHECK CONSTRAINT [FK_hoaDonNhap_nhaCC]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_DanhMuc] FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_DanhMuc]
GO
/****** Object:  StoredProcedure [dbo].[sp_xoaSP]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xoa
CREATE PROCEDURE [dbo].[sp_xoaSP] @MaHoaDon char(10),@MaSanPham char(10)
as
BEGIN
 SET NOCOUNT ON;
    DECLARE @SoLuong INT ,@GiaSanPham INT

 -- Thêm dữ liệu vào bảng tblChiTietHoaDon
  select @SoLuong=SoLuong ,@GiaSanPham=DonGia FROM ChiTiethoaDon WHERE MaHoaDon = @MaHoaDon AND MaMonAn = @MaSanPham
    
  -- Cập nhật tổng tiền trong bảng tblHoaDon
  UPDATE HoaDon SET TongTien = TongTien -@GiaSanPham WHERE MaHoaDon = @MaHoaDon
  DELETE FROM ChiTiethoaDon WHERE MaHoaDon = @MaHoaDon AND MaMonAn = @MaSanPham
  
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDonban]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemHoaDonban]
    @MaHoaDon char(10),
    @MaSanPham char(10),
    @SoLuong INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE  @TongTienMoi FLOAT;
	select @TongTienMoi = @SoLuong * giaBan  from dbo.RauCu where idSanpham = @MaSanPham
	
	

    IF EXISTS (SELECT 1 FROM chiTietHoaDonBan WHERE idChiTietHoaDonBan = @MaHoaDon AND idSanpham = @MaSanPham)
    BEGIN
	
		UPDATE dbo.chiTietHoaDonBan set soluong = soluong+@SoLuong  ,giaBan =giaBan+@TongTienMoi  where idChiTietHoaDonBan =@MaHoaDon AND idSanpham = @MaSanPham
		UPDATE dbo.hoaDonNhap set tongTien = tongTien+ @TongTienMoi where idHoaDonNhap =@MaHoaDon
		UPDATE dbo.RauCu set soLuong = soLuong- @SoLuong where idSanpham = @MaSanPham

    END
    ELSE
    BEGIN

		insert into dbo.chiTietHoaDonBan(idChiTietHoaDonBan,idSanpham,soluong,giaBan) values(@MaHoaDon,@MaSanPham,@SoLuong,@TongTienMoi)
		UPDATE dbo.hoaDonBan set tongTien = tongTien+ @TongTienMoi where idHoaDonBan =@MaHoaDon
		UPDATE dbo.RauCu set soLuong = soLuong- @SoLuong where idSanpham = @MaSanPham

        
    END
END

GO
/****** Object:  StoredProcedure [dbo].[ThemHoaDonNhap]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ThemHoaDonNhap]
    @MaHoaDon char(10),
    @MaSanPham char(10),
    @SoLuong INT,
    @Gia FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE  @TongTienMoi FLOAT;

	
	

    IF EXISTS (SELECT 1 FROM chiTietHoaDonNhap WHERE idHoaDonNhap = @MaHoaDon AND idSanpham = @MaSanPham)
    BEGIN
	
		UPDATE dbo.chiTietHoaDonNhap set soluong = soluong+@SoLuong  ,DonGia =DonGia+@Gia  where idHoaDonNhap =@MaHoaDon AND idSanpham = @MaSanPham
		UPDATE dbo.hoaDonNhap set tongTien = tongTien+ @Gia where idHoaDonNhap =@MaHoaDon
		UPDATE dbo.RauCu set soLuong = soLuong+ @SoLuong where idSanpham = @MaSanPham

    END
    ELSE
    BEGIN

		insert into dbo.chiTietHoaDonNhap(idHoaDonNhap,idSanpham,soluong,DonGia) values(@MaHoaDon,@MaSanPham,@SoLuong,@Gia)
		UPDATE dbo.hoaDonNhap set tongTien = tongTien+ @Gia where idHoaDonNhap =@MaHoaDon
		UPDATE dbo.RauCu set soLuong = soLuong+ @SoLuong where idSanpham = @MaSanPham

        
    END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemSp]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemSp]
@maHD char(10), @MaSp char(10) , @SoLuong int
AS 
BEGIN
		DECLARE @GiaSanPham FLOAT
		SELECT @GiaSanPham = donGia FROM dbo.MonAn WHERE MaMonAn = @MaSp
		IF EXISTS (SELECT 1 FROM ChiTiethoaDon WHERE MaHoaDon = @maHD AND MaMonAn = @MaSp)
		  BEGIN
		  UPDATE ChiTiethoaDon set SoLuong=SoLuong + @SoLuong ,DonGia = DonGia+ @GiaSanPham * @SoLuong
		   -- Cập nhật tổng tiền trong bảng tblHoaDon
		  UPDATE HoaDon SET TongTien = TongTien + (@GiaSanPham * @SoLuong) WHERE MaHoaDon = @maHD
		  end
		   ELSE
		  BEGIN
		  -- Thêm dữ liệu vào bảng tblChiTietHoaDon
		  INSERT INTO ChiTiethoaDon(MaHoaDon, MaMonAn, SoLuong,DonGia )
		  VALUES(@maHD, @MaSp, @SoLuong, @GiaSanPham * @SoLuong)
    
	
		  -- Cập nhật tổng tiền trong bảng tblHoaDon
		  UPDATE HoaDon SET TongTien = TongTien + (@GiaSanPham * @SoLuong) WHERE MaHoaDon = @maHD
		  END


 

	
END

GO
/****** Object:  StoredProcedure [dbo].[xoaHoaDonBan]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[xoaHoaDonBan]
    @MaHoaDon char(10),
    @MaSanPham char(10)

AS
BEGIN

	DECLARE  @TongTien FLOAT,@SoLuong int;
	select @TongTien = giaBan  ,@SoLuong=soluong from dbo.chiTietHoaDonBan where idChiTietHoaDonBan = @MaHoaDon AND idSanpham = @MaSanPham
	
		UPDATE dbo.hoaDonBan set tongTien = tongTien- @TongTien where idHoaDonBan =@MaHoaDon
		UPDATE dbo.RauCu set soLuong = soLuong+ @SoLuong where idSanpham = @MaSanPham
		delete from dbo.chiTietHoaDonBan where idChiTietHoaDonBan = @MaHoaDon AND idSanpham = @MaSanPham
	 
   
	

END

GO
/****** Object:  StoredProcedure [dbo].[xoaHoaDonNhap]    Script Date: 5/27/2023 5:22:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[xoaHoaDonNhap]
    @MaHoaDon char(10),
    @MaSanPham char(10)

AS
BEGIN

	DECLARE  @TongTien FLOAT,@SoLuong int;
	select @TongTien = DonGia  ,@SoLuong=soluong from dbo.chiTietHoaDonNhap where idHoaDonNhap = @MaHoaDon AND idSanpham = @MaSanPham
	
		UPDATE dbo.hoaDonNhap set tongTien = tongTien- @TongTien where idHoaDonNhap =@MaHoaDon
		UPDATE dbo.RauCu set soLuong = soLuong- @SoLuong where idSanpham = @MaSanPham
		delete from dbo.chiTietHoaDonNhap where idHoaDonNhap = @MaHoaDon AND idSanpham = @MaSanPham
	 
   
	

END

GO

insert into TaiKhoan(HoTen,TenDangNhap,MatKhau,quyen) values ('admin','admin','admin',0)

go
insert into DanhMuc(MaDanhMuc,TenDanhMuc) values ('1','Tất cả')
go
