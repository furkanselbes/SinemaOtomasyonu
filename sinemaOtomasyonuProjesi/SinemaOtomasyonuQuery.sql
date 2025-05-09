CREATE DATABASE [SinemaOtomasyonu];
GO
USE [SinemaOtomasyonu]
GO
/****** Object:  Table [dbo].[Biletler]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biletler](
	[biletId] [int] IDENTITY(1,1) NOT NULL,
	[bilet] [varchar](20) NOT NULL,
	[biletParasi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[biletId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciro]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciro](
	[ogrenciBiletToplamPara] [int] NOT NULL,
	[tamBiletToplamPara] [int] NOT NULL,
	[biletToplamPara] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filmler]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filmler](
	[filmId] [int] IDENTITY(1,1) NOT NULL,
	[filmAdi] [varchar](40) NOT NULL,
	[filmTuru] [varchar](20) NOT NULL,
	[yonetmen] [varchar](100) NOT NULL,
	[afis] [varchar](100) NOT NULL,
	[vizyonTarihi] [varchar](25) NOT NULL,
	[filmSesi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[filmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[hesapId] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](20) NOT NULL,
	[sifre] [varchar](20) NOT NULL,
	[yetkiId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[hesapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Misir]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Misir](
	[misir] [varchar](10) NOT NULL,
	[misirParasi] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[musteriId] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](20) NOT NULL,
	[soyad] [varchar](20) NOT NULL,
	[filmAdi] [varchar](40) NOT NULL,
	[bilet] [varchar](20) NOT NULL,
	[salonAdi] [varchar](20) NOT NULL,
	[tarih] [varchar](25) NOT NULL,
	[seans] [varchar](20) NOT NULL,
	[koltuk] [varchar](20) NULL,
	[biletParasi] [int] NULL,
	[misirParasi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[musteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salonlar]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salonlar](
	[salonId] [int] IDENTITY(1,1) NOT NULL,
	[salonAdi] [varchar](15) NOT NULL,
	[yatayKoltukSayisi] [int] NOT NULL,
	[dikeyKoltukSayisi] [int] NOT NULL,
 CONSTRAINT [PK__Salonlar__9E62E2CE6760DF8B] PRIMARY KEY CLUSTERED 
(
	[salonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seanslar]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seanslar](
	[seansId] [int] IDENTITY(1,1) NOT NULL,
	[filmId] [int] NOT NULL,
	[salonId] [int] NOT NULL,
	[tarih] [varchar](25) NOT NULL,
	[seans] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Seanslar] PRIMARY KEY CLUSTERED 
(
	[seansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turler]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turler](
	[turId] [int] IDENTITY(1,1) NOT NULL,
	[turAdi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[turAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetkiler]    Script Date: 8.06.2022 14:48:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkiler](
	[yetkiId] [int] IDENTITY(1,1) NOT NULL,
	[yetki] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[yetkiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Biletler] ON 

INSERT [dbo].[Biletler] ([biletId], [bilet], [biletParasi]) VALUES (2, N'Öğrenci', 45)
INSERT [dbo].[Biletler] ([biletId], [bilet], [biletParasi]) VALUES (3, N'Tam', 52)
SET IDENTITY_INSERT [dbo].[Biletler] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([hesapId], [kullaniciAdi], [sifre], [yetkiId]) VALUES (1, N'ömür', N'123', 1)
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
INSERT [dbo].[Misir] ([misir], [misirParasi]) VALUES (N'evet', 15)
GO
SET IDENTITY_INSERT [dbo].[Turler] ON 

INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (1, N'Aksiyon')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (9, N'Animasyon')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (10, N'Belgesel')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (7, N'Bilim Kurgu')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (11, N'Biyografi')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (12, N'Casusluk')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (13, N'Çizgi Roman')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (14, N'Dini')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (27, N'Dram')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (15, N'Erotik')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (16, N'Fantastik')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (17, N'Felaket')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (3, N'Festival')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (26, N'Gençlik')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (18, N'Gerilim')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (6, N'Gizem')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (2, N'Komedi')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (4, N'Korku')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (5, N'Macera')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (19, N'Müzikal')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (8, N'Romantik')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (20, N'Savaş')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (21, N'Spor')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (22, N'Tarihi')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (23, N'Uzay')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (24, N'Video Oyunu')
INSERT [dbo].[Turler] ([turId], [turAdi]) VALUES (25, N'Western')
SET IDENTITY_INSERT [dbo].[Turler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetkiler] ON 

INSERT [dbo].[Yetkiler] ([yetkiId], [yetki]) VALUES (1, N'yönetici')
INSERT [dbo].[Yetkiler] ([yetkiId], [yetki]) VALUES (2, N'personel')
SET IDENTITY_INSERT [dbo].[Yetkiler] OFF
GO
ALTER TABLE [dbo].[Seanslar]  WITH CHECK ADD  CONSTRAINT [FK_Seanslar_Filmler] FOREIGN KEY([filmId])
REFERENCES [dbo].[Filmler] ([filmId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seanslar] CHECK CONSTRAINT [FK_Seanslar_Filmler]
GO
ALTER TABLE [dbo].[Seanslar]  WITH CHECK ADD  CONSTRAINT [FK_Seanslar_Salonlar] FOREIGN KEY([salonId])
REFERENCES [dbo].[Salonlar] ([salonId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seanslar] CHECK CONSTRAINT [FK_Seanslar_Salonlar]
GO
