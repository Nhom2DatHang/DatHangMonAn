create database DatHangMonAn
Go
USE [DatHangMonAn]
GO
/****** Object:  Database [DatHangMonAn]    Script Date: 3/22/2017 12:32:28 PM ******/
CREATE DATABASE [DatHangMonAn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DatHangMonAn', FILENAME = N'D:\BT\C# - CSDL\DatHangMonAn.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DatHangMonAn_log', FILENAME = N'D:\BT\C# - CSDL\DatHangMonAn_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DatHangMonAn] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DatHangMonAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DatHangMonAn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DatHangMonAn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DatHangMonAn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DatHangMonAn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DatHangMonAn] SET ARITHABORT OFF 
GO
ALTER DATABASE [DatHangMonAn] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DatHangMonAn] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DatHangMonAn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DatHangMonAn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DatHangMonAn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DatHangMonAn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DatHangMonAn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DatHangMonAn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DatHangMonAn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DatHangMonAn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DatHangMonAn] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DatHangMonAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DatHangMonAn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DatHangMonAn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DatHangMonAn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DatHangMonAn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DatHangMonAn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DatHangMonAn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DatHangMonAn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DatHangMonAn] SET  MULTI_USER 
GO
ALTER DATABASE [DatHangMonAn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DatHangMonAn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DatHangMonAn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DatHangMonAn] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DatHangMonAn]
GO
/****** Object:  StoredProcedure [dbo].[SP_ChonTaiKhoan]    Script Date: 3/22/2017 12:32:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ChonTaiKhoan]
as
	select MaTaiKhoan, TenTaiKhoan
	from TaiKhoan
	where TinhTrang = 1
GO
/****** Object:  StoredProcedure [dbo].[SP_ChucNang_Combobox]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ChucNang_Combobox]
@mataikhoan int
as
	select MaChucNang, TenChucNang
	from ChucNang
	where TinhTrang = 1 and MaChucNang not in (select MaChucNang from  PhanQuyen where MaTaiKhoan=@mataikhoan)

GO
/****** Object:  StoredProcedure [dbo].[SP_PhanQuyen_Insert]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_PhanQuyen_Insert]
@machucnang int,
@mataikhoan int,
@giatriquyen int
as
	if exists (select 1 from PhanQuyen where MaTaiKhoan = @mataikhoan and MaChucNang = @machucnang)
		begin
			update PhanQuyen
			set GiaTriQuyen = @giatriquyen
			where MaTaiKhoan = @mataikhoan and MaChucNang = @machucnang
		end
	else
		begin
			insert into PhanQuyen(MaChucNang, MaTaiKhoan, GiaTriQuyen)
			values(@machucnang, @mataikhoan, @giatriquyen)
		end

GO
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDonDatHang](
	[MaDDH] [varchar](10) NOT NULL,
	[MaMonAn] [varchar](10) NOT NULL,
	[SoLuongDat] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[MaChucNang] [int] NOT NULL,
	[TenChucNang] [nvarchar](100) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDDH] [varchar](10) NOT NULL,
	[NgayLapDDH] [date] NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](100) NULL,
	[SDTKH] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[CMND] [int] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [varchar](10) NOT NULL,
	[TenMonAn] [nvarchar](100) NULL,
	[DVT] [nvarchar](20) NULL,
	[DonGia] [int] NOT NULL,
	[HinhAnh] [image] NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDTNV] [varchar](20) NULL,
	[TaiKhoan] [varchar](20) NULL,
	[MatKhau] [varbinary](128) NULL,
	[MaTaiKhoan] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaChucNang] [int] NOT NULL,
	[MaTaiKhoan] [int] NOT NULL,
	[GiaTriQuyen] [int] NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC,
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 3/22/2017 12:32:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [int] NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietDonDatHang] ([MaDDH], [MaMonAn], [SoLuongDat], [DonGiaBan]) VALUES (N'DDH01', N'MMA02', 2, 760000)
INSERT [dbo].[ChiTietDonDatHang] ([MaDDH], [MaMonAn], [SoLuongDat], [DonGiaBan]) VALUES (N'DDH01', N'MMA04', 3, 870000)
INSERT [dbo].[ChiTietDonDatHang] ([MaDDH], [MaMonAn], [SoLuongDat], [DonGiaBan]) VALUES (N'DDH02', N'MMA01', 2, 500000)
INSERT [dbo].[ChiTietDonDatHang] ([MaDDH], [MaMonAn], [SoLuongDat], [DonGiaBan]) VALUES (N'DDH03', N'MMA09', 4, 720000)
INSERT [dbo].[ChiTietDonDatHang] ([MaDDH], [MaMonAn], [SoLuongDat], [DonGiaBan]) VALUES (N'DDH04', N'MMA03', 1, 380000)
INSERT [dbo].[ChiTietDonDatHang] ([MaDDH], [MaMonAn], [SoLuongDat], [DonGiaBan]) VALUES (N'DDH05', N'MMA07', 2, 860000)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [TinhTrang]) VALUES (1, N'Đăng xuất', 1)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [TinhTrang]) VALUES (3, N'Đổi mật khẩu', 1)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [TinhTrang]) VALUES (4, N'Phân quyền', 1)
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang], [TinhTrang]) VALUES (5, N'Nhân viên', 1)
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLapDDH], [MaNV], [MaKH]) VALUES (N'DDH01', CAST(N'2017-01-02' AS Date), N'NV02', N'KH01')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLapDDH], [MaNV], [MaKH]) VALUES (N'DDH02', CAST(N'2017-01-05' AS Date), N'NV01', N'KH02')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLapDDH], [MaNV], [MaKH]) VALUES (N'DDH03', CAST(N'2016-12-13' AS Date), N'NV03', N'KH04')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLapDDH], [MaNV], [MaKH]) VALUES (N'DDH04', CAST(N'2017-01-02' AS Date), N'NV02', N'KH04')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLapDDH], [MaNV], [MaKH]) VALUES (N'DDH05', CAST(N'2017-02-02' AS Date), N'NV05', N'KH03')
INSERT [dbo].[DonDatHang] ([MaDDH], [NgayLapDDH], [MaNV], [MaKH]) VALUES (N'DDH06', CAST(N'2017-03-01' AS Date), N'NV04', N'KH05')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [Email], [CMND]) VALUES (N'KH01', N'Nguyễn Văn Vinh', N'Vũng Tàu', N'01236985478', N'vanvinh04@gmail.com', 212025486)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [Email], [CMND]) VALUES (N'KH02', N'Trịnh Minh Tâm', N'TPHCM', N'0863562564', N'minhtam1258@gmail.com', 232125203)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [Email], [CMND]) VALUES (N'KH03', N'Hoàng Thị Thùy Dung', N'Biên Hòa', N'01654258963', N'thuydung12@gmail.com', 232025212)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [Email], [CMND]) VALUES (N'KH04', N'Đinh Thị Kim Chi', N'Đồng Nai', N'0613586578', N'kimchi0128@gmail.com', 272524145)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChiKH], [SDTKH], [Email], [CMND]) VALUES (N'KH05', N'Hoàng Vũ Ngọc Như', N'Biên Hòa', N'092824528', N'ngocnhu312@gmail.com', 232425156)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA01', N'Cơm gà lá sen', N'Dĩa', 250000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA02', N'Gà nướng phô mai', N'Kg', 380000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA03', N'Gà ta nấu siêu', N'Suất', 380000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA04', N'Giò heo chiên giòn', N'Kg', 290000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA05', N'Súp hải sản', N'Tô', 200000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA06', N'Lẩu nấm hải sản', N'Suất', 450000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA07', N'Lẩu Thái', N'Suất', 430000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA08', N'Salad tôm', N'Dĩa', 180000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA09', N'Gỏi bò bóp thấu', N'Dĩa', 180000, NULL)
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DVT], [DonGia], [HinhAnh]) VALUES (N'MMA10', N'Cá diêu hồng sốt chanh dây', N'Dĩa', 190000, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [GioiTinh], [DiaChi], [SDTNV], [TaiKhoan], [MatKhau], [MaTaiKhoan]) VALUES (N'NV01', N'Nguyễn Minh Ngọc', N'Nữ', N'Đồng Nai', N'01235851245', N'minhngoc', 0x0200725AB00B7DA2E276EB8AE52FC3DF59D4F8FA5B15D8B03871BCA1F8F91F5664C6AF425348000592FF18BFAF8281BE4DF0DDF98E1A20C41B94A5D2DCD161F620F72BF1E9AD, 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [GioiTinh], [DiaChi], [SDTNV], [TaiKhoan], [MatKhau], [MaTaiKhoan]) VALUES (N'NV02', N'Trần Minh Nhật', N'Nam', N'TPHCM', N'0958214754', N'minhnhat', 0x0200725AB00B7DA2E276EB8AE52FC3DF59D4F8FA5B15D8B03871BCA1F8F91F5664C6AF425348000592FF18BFAF8281BE4DF0DDF98E1A20C41B94A5D2DCD161F620F72BF1E9AD, 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [GioiTinh], [DiaChi], [SDTNV], [TaiKhoan], [MatKhau], [MaTaiKhoan]) VALUES (N'NV03', N'Lại Hoàng Tuấn Anh', N'Nam', N'Bình Dương', N'01695687868', N'tuananh', 0x0200725AB00B7DA2E276EB8AE52FC3DF59D4F8FA5B15D8B03871BCA1F8F91F5664C6AF425348000592FF18BFAF8281BE4DF0DDF98E1A20C41B94A5D2DCD161F620F72BF1E9AD, 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [GioiTinh], [DiaChi], [SDTNV], [TaiKhoan], [MatKhau], [MaTaiKhoan]) VALUES (N'NV04', N'Đinh Hoàng Kiều Khanh', N'Nữ', N'Biên Hòa', N'01236854956', N'kieukhanh', 0x0200725AB00B7DA2E276EB8AE52FC3DF59D4F8FA5B15D8B03871BCA1F8F91F5664C6AF425348000592FF18BFAF8281BE4DF0DDF98E1A20C41B94A5D2DCD161F620F72BF1E9AD, 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [GioiTinh], [DiaChi], [SDTNV], [TaiKhoan], [MatKhau], [MaTaiKhoan]) VALUES (N'NV05', N'Vũ Hoàng Giang', N'Nam', N'TPHCM', N'01652358632', N'hoanggiang', 0x0200725AB00B7DA2E276EB8AE52FC3DF59D4F8FA5B15D8B03871BCA1F8F91F5664C6AF425348000592FF18BFAF8281BE4DF0DDF98E1A20C41B94A5D2DCD161F620F72BF1E9AD, 2)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [GioiTinh], [DiaChi], [SDTNV], [TaiKhoan], [MatKhau], [MaTaiKhoan]) VALUES (N'NV06', N'Nguyễn Vũ Duy', N'Nam', N'Vũng Tàu', N'01692235864', N'admin', 0x020070C5FD78AFCBB7091EB25AC52ECF47D79EDE7D48F70A72DA8EB86DA1FD79E2E371DF4E479C610CBAFD444963DCDB00696FCAB82DE7DA3F9499F7D18200B26F8A1E12AD73, 1)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (1, 1, 15)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (1, 2, 1)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (3, 1, 1)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (3, 2, 15)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (4, 1, 3)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (4, 2, 7)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (5, 1, 15)
INSERT [dbo].[PhanQuyen] ([MaChucNang], [MaTaiKhoan], [GiaTriQuyen]) VALUES (5, 2, 15)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (1, N'Admin', 1)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenTaiKhoan], [TinhTrang]) VALUES (2, N'User', 1)
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang] FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DonDatHang] ([MaDDH])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_MonAn]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_KhachHang]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_ChucNang]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_TaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [DatHangMonAn] SET  READ_WRITE 
GO
