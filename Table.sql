USE [Deneme]
GO

/****** Object:  Table [dbo].[Zamanlayici]    Script Date: 29.10.2018 23:46:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Zamanlayici](
	[id] [int] NULL,
	[ZamanAdi] [nvarchar](50) NULL,
	[ZamanTuru] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
	[YinelenenId] [nvarchar](50) NULL,
	[CalismaTipi] [int] NULL,
	[Gunluk] [int] NULL,
	[Haftalik] [int] NULL,
	[Aylik] [int] NULL,
	[HaftaGunleri] [nvarchar](50) NULL,
	[AyGunu] [int] NULL,
	[AyTuru] [int] NULL,
	[BirKereCalis] [datetime] NULL,
	[CalismaSikligi] [int] NULL,
	[CalismaTuru] [int] NULL,
	[CalismaBaslangic] [time](7) NULL,
	[CalismaBiris] [time](7) NULL,
	[ZamanBaslangic] [date] NULL,
	[ZamanBitis] [date] NULL,
	[ZamanTip] [bit] NULL
) ON [PRIMARY]
GO


