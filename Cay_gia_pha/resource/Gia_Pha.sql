CREATE DATABASE [QL_Gia_Pha]
USE [QL_Gia_Pha]
GO
/****** Object:  Table [dbo].[DANG_NHAP_TK]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANG_NHAP_TK](
	[TenTK] [nchar](10) NULL,
	[MK] [nchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGHE_NGHIEP]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGHE_NGHIEP](
	[maNN] [nchar](10) NOT NULL,
	[TenNN] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_NNGHIEP] PRIMARY KEY CLUSTERED 
(
	[maNN] ASC,
	[TenNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NN_DD_KET_THUC]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NN_DD_KET_THUC](
	[MaTV] [nchar](10) NOT NULL,
	[NgayGio] [datetime] NULL,
	[NguyenNhan] [nvarchar](50) NOT NULL,
	[DD] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUAN_HE]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUAN_HE](
	[MaQH] [nchar](10) NOT NULL,
	[TenQH] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUE_QUAN]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUE_QUAN](
	[MaQQ] [nchar](5) NOT NULL,
	[TenQQ] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_QQUAN] PRIMARY KEY CLUSTERED 
(
	[MaQQ] ASC,
	[TenQQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANH_TICH]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANH_TICH](
	[MaTT] [nchar](10) NOT NULL,
	[TenTT] [nvarchar](30) NOT NULL,
	[NgayGN] [datetime] NOT NULL,
 CONSTRAINT [PK_TTICH1] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC,
	[TenTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONG_TIN_TV]    Script Date: 4/24/2023 8:29:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONG_TIN_TV](
	[MaTV] [nchar](10) NOT NULL,
	[TenTV] [nvarchar](35) NULL,
	[NgayGSinh] [date] NULL,
	[GT] [tinyint] NULL,
	[NgayPSinh] [date] NULL,
	[DC] [nvarchar](50) NULL,
	[Doi] [int] NULL,
	[MaTT] [nchar](10) NULL,
	[MaNN] [nchar](10) NULL,
	[MaQQ] [nchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DANG_NHAP_TK]  WITH CHECK ADD  CONSTRAINT [FK_DANG_NHAP_TK_THONG_TIN_TV] FOREIGN KEY([TenTK])
REFERENCES [dbo].[THONG_TIN_TV] ([MaTV])
GO
ALTER TABLE [dbo].[DANG_NHAP_TK] CHECK CONSTRAINT [FK_DANG_NHAP_TK_THONG_TIN_TV]
GO
ALTER TABLE [dbo].[NN_DD_KET_THUC]  WITH CHECK ADD  CONSTRAINT [FK_NN_DD_KET_THUC_THONG_TIN_TV] FOREIGN KEY([MaTV])
REFERENCES [dbo].[THONG_TIN_TV] ([MaTV])
GO
ALTER TABLE [dbo].[NN_DD_KET_THUC] CHECK CONSTRAINT [FK_NN_DD_KET_THUC_THONG_TIN_TV]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã Nghề Nghiệp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NGHE_NGHIEP', @level2type=N'COLUMN',@level2name=N'maNN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên Nghề Nghiệp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NGHE_NGHIEP', @level2type=N'COLUMN',@level2name=N'TenNN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã Thành Viên' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NN_DD_KET_THUC', @level2type=N'COLUMN',@level2name=N'MaTV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày Giờ Mất' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NN_DD_KET_THUC', @level2type=N'COLUMN',@level2name=N'NgayGio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nguyên Nhân' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NN_DD_KET_THUC', @level2type=N'COLUMN',@level2name=N'NguyenNhan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Địa điểm mai táng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NN_DD_KET_THUC', @level2type=N'COLUMN',@level2name=N'DD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã Quan Hệ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QUAN_HE', @level2type=N'COLUMN',@level2name=N'MaQH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên Quan Hệ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QUAN_HE', @level2type=N'COLUMN',@level2name=N'TenQH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã Quê Quán' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QUE_QUAN', @level2type=N'COLUMN',@level2name=N'MaQQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên Quê Quán' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QUE_QUAN', @level2type=N'COLUMN',@level2name=N'TenQQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã Thành Tích' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THANH_TICH', @level2type=N'COLUMN',@level2name=N'MaTT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên Thành Tích' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THANH_TICH', @level2type=N'COLUMN',@level2name=N'TenTT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày Ghi Nhận' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THANH_TICH', @level2type=N'COLUMN',@level2name=N'NgayGN'
GO

INSERT INTO [dbo].[THONG_TIN_TV]
           ([MaTV]
           ,[TenTV]
           ,[NgayGSinh]
           ,[GT]
           ,[NgayPSinh]
           ,[DC]
           ,[Doi]
           ,[MaTT]
           ,[MaNN]
           ,[MaQQ])
     VALUES
           ('TV01'
           ,N'Nguyễn Đức Ân'
           ,'12-08-2003'
           ,'0'
           ,'12-26-2100'
           ,N'13 Đỗ Xuân Hợp, P.Bình Trưng Đông'
           ,'3'
           ,'111'
           ,'111'
           ,'111')
GO



INSERT INTO [dbo].[DANG_NHAP_TK]
           ([TenTK]
           ,[MK])
     VALUES
           ('TV01','14082003')
GO

