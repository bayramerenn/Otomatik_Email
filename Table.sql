USE [BTH]
GO

/****** Object:  Table [dbo].[Zamanlayici]    Script Date: 28.10.2018 15:17:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Zamanlayici](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ZamanAdi] [nvarchar](50) NULL,
	[ZamanTuru] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
	[YinelenenTur] [nvarchar](50) NULL,
	[Gunluk] [int] NULL,
	[Haftalik] [int] NULL,
	[Aylik] [int] NULL,
	[HaftaGunleri] [nvarchar](50) NULL,
	[AyGunu] [int] NULL,
	[AyTuru] [int] NULL,
	[CalismaTipi] [bit] NULL,
	[BirKereCalis] [datetime] NULL,
	[CalismaSikligi] [int] NULL,
	[CalismaTuru] [nvarchar](50) NULL,
	[CalismaBaslangic] [time](0) NULL,
	[CalismaBiris] [time](0) NULL,
	[ZamanBaslangic] [date] NULL,
	[ZamanBitis] [date] NULL,
	[ZamanTip] [bit] NULL,
 CONSTRAINT [PK_Zamanlayici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


