USE [WebBanGiayData]
GO
/****** Object:  Table [dbo].[CHITIETDONDATHANG]    Script Date: 08/04/2024 8:03:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONDATHANG](
	[MaDonHang] [varchar](50) NOT NULL,
	[Magiay] [varchar](50) NOT NULL,
	[Soluong] [int] NULL,
	[Dongia] [money] NULL,
 CONSTRAINT [PK_CHITIETDONDATHANG] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC,
	[Magiay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONDATHANG]    Script Date: 08/04/2024 8:03:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDATHANG](
	[MaDonHang] [varchar](50) NOT NULL,
	[Dathanhtoan] [bit] NOT NULL,
	[Tinhtranggiaohang] [nvarchar](50) NULL,
	[Ngaydat] [date] NOT NULL,
	[Ngaygiao] [date] NULL,
	[MaKH] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DONDATHANG] PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAY]    Script Date: 08/04/2024 8:03:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAY](
	[Magiay] [varchar](50) NOT NULL,
	[Tengiay] [nvarchar](200) NOT NULL,
	[Size] [int] NOT NULL,
	[Giagiay] [money] NOT NULL,
	[Mota] [nvarchar](2000) NULL,
	[Anhbia] [nvarchar](200) NULL,
	[Ngaycapnhat] [date] NOT NULL,
	[Soluongton] [int] NOT NULL,
	[Maloai] [varchar](50) NOT NULL,
	[Hot] [bit] NULL,
	[MaSX] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Giay] PRIMARY KEY CLUSTERED 
(
	[Magiay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIGIAY]    Script Date: 08/04/2024 8:03:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIGIAY](
	[Maloai] [varchar](50) NOT NULL,
	[Tenloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAIGIAY] PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHASANXUAT]    Script Date: 08/04/2024 8:03:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHASANXUAT](
	[MaSX] [varchar](50) NOT NULL,
	[TenSX] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Dienthoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NHASANXUAT] PRIMARY KEY CLUSTERED 
(
	[MaSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 08/04/2024 8:03:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[IDtaikhoan] [varchar](50) NOT NULL,
	[IDtendangnhap] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[LoaiTK] [varchar](50) NOT NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[IDtaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'2', N'PK09', 20, 688000.0000, N'VIP', N'sp7.png', CAST(N'2024-03-23' AS Date), 56, N'ML02', NULL, N'NXS01')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'3', N'PK03', 44, 700000.0000, N'V', N'sp10.png', CAST(N'2024-03-23' AS Date), 20, N'ML01', NULL, N'NXS01')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'5', N'PK09', 22, 2000000.0000, N'newbalance', N'sp2.png', CAST(N'2024-03-30' AS Date), 20, N'ML03', 1, N'NSX2')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'7', N'PK44', 20, 7000000.0000, N'VIP', N'sp12.png', CAST(N'0001-01-01' AS Date), 70, N'ML03', 1, N'NSX03')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'PK22', N'Giày màu hồng', 0, 400000.0000, N'Đẹp vcl', N'sp4.png', CAST(N'2024-03-25' AS Date), 20, N'ML03', 1, N'NSX03')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'PK29', N'Giày da', 60, 2000000.0000, N'vip', N'sp5.png', CAST(N'2024-03-25' AS Date), 200000, N'ML02', 1, N'NSX03')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'sp11', N'Giày bitis 11', 40, 500000.0000, NULL, N'sp11.png', CAST(N'2024-04-08' AS Date), 20, N'ML01', 1, N'NSX2')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'sp3', N'Giày thể thao 3', 40, 700000.0000, NULL, N'sp3.png', CAST(N'0001-01-01' AS Date), 20, N'ML03', 1, N'NSX2')
INSERT [dbo].[GIAY] ([Magiay], [Tengiay], [Size], [Giagiay], [Mota], [Anhbia], [Ngaycapnhat], [Soluongton], [Maloai], [Hot], [MaSX]) VALUES (N'sp9', N'Giày bitis 9', 40, 200000.0000, NULL, N'sp9.png', CAST(N'2024-04-08' AS Date), 20, N'ML01', NULL, N'NXS01')
GO
INSERT [dbo].[LOAIGIAY] ([Maloai], [Tenloai]) VALUES (N'ML01', N'Bitis')
INSERT [dbo].[LOAIGIAY] ([Maloai], [Tenloai]) VALUES (N'ML02', N'Giày da')
INSERT [dbo].[LOAIGIAY] ([Maloai], [Tenloai]) VALUES (N'ML03', N'Thể thao')
GO
INSERT [dbo].[NHASANXUAT] ([MaSX], [TenSX], [Diachi], [Dienthoai]) VALUES (N'NSX03', N'PULMA', N'France', N'888888999')
INSERT [dbo].[NHASANXUAT] ([MaSX], [TenSX], [Diachi], [Dienthoai]) VALUES (N'NSX2', N'NIKE', N'France', N'0374966843')
INSERT [dbo].[NHASANXUAT] ([MaSX], [TenSX], [Diachi], [Dienthoai]) VALUES (N'NXS01', N'ADIDAS', N'America', N'0374966843')
GO
INSERT [dbo].[TAIKHOAN] ([IDtaikhoan], [IDtendangnhap], [Password], [LoaiTK], [Hoten], [Email], [Diachi]) VALUES (N'TK01', N'Admin     ', N'123', N'Admin', N'Lê Thọ Khải', N'lethokhai0@gmail.com', N'Quận 2')
INSERT [dbo].[TAIKHOAN] ([IDtaikhoan], [IDtendangnhap], [Password], [LoaiTK], [Hoten], [Email], [Diachi]) VALUES (N'TK02', N'Nhân viên ', N'123', N'Nhân viên', N'Đổng Anh Thư', N'anhthu@gmail.com', N'Bình Tân')
INSERT [dbo].[TAIKHOAN] ([IDtaikhoan], [IDtendangnhap], [Password], [LoaiTK], [Hoten], [Email], [Diachi]) VALUES (N'TK03', N'thu2322   ', N'123', N'Admin', N'Đổng Anh Thư', N'dinhanhvnn@gmail.com', N'bình tân')
INSERT [dbo].[TAIKHOAN] ([IDtaikhoan], [IDtendangnhap], [Password], [LoaiTK], [Hoten], [Email], [Diachi]) VALUES (N'TK05', N'NHANVIEN05', N'123', N'Nhân viên', N'Lê Thọ Khải', N'lethokhai0@gmail.com', N'Quận 2')
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDONDATHANG_DONDATHANG] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DONDATHANG] ([MaDonHang])
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG] CHECK CONSTRAINT [FK_CHITIETDONDATHANG_DONDATHANG]
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDONDATHANG_Giay] FOREIGN KEY([Magiay])
REFERENCES [dbo].[GIAY] ([Magiay])
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG] CHECK CONSTRAINT [FK_CHITIETDONDATHANG_Giay]
GO
ALTER TABLE [dbo].[DONDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_DONDATHANG_TAIKHOAN] FOREIGN KEY([MaKH])
REFERENCES [dbo].[TAIKHOAN] ([IDtaikhoan])
GO
ALTER TABLE [dbo].[DONDATHANG] CHECK CONSTRAINT [FK_DONDATHANG_TAIKHOAN]
GO
ALTER TABLE [dbo].[GIAY]  WITH CHECK ADD  CONSTRAINT [FK_Giay_LOAIGIAY] FOREIGN KEY([Maloai])
REFERENCES [dbo].[LOAIGIAY] ([Maloai])
GO
ALTER TABLE [dbo].[GIAY] CHECK CONSTRAINT [FK_Giay_LOAIGIAY]
GO
ALTER TABLE [dbo].[GIAY]  WITH CHECK ADD  CONSTRAINT [FK_GIAY_NHASANXUAT] FOREIGN KEY([MaSX])
REFERENCES [dbo].[NHASANXUAT] ([MaSX])
GO
ALTER TABLE [dbo].[GIAY] CHECK CONSTRAINT [FK_GIAY_NHASANXUAT]
GO
