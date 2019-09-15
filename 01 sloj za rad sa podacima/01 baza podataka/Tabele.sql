CREATE DATABASE [SALONAUTOMOBILA_IP2018]
GO
USE [SALONAUTOMOBILA_IP2018]
GO
CREATE TABLE [dbo].[MODEL](
	[IDModela] [nvarchar](10) NOT NULL PRIMARY KEY,
	[NazivModela] [nvarchar](100) NOT NULL,
	[Motor] [nvarchar](100) NOT NULL,
	[Boja] [nvarchar](100) NOT NULL,
	[SifraProizvodjaca] [nvarchar](10) NOT NULL
	
)
GO
CREATE TABLE [dbo].[PROIZVODJAC](
	[IDProizvodjaca] [nvarchar](10) NOT NULL PRIMARY KEY,
	[NazivProizvodjaca] [nvarchar](100) NOT NULL,
	[Tip] [nvarchar](100) NOT NULL
	
)
GO
ALTER TABLE [dbo].[MODEL] ADD CONSTRAINT
[FK_Model_Proizvodjac] FOREIGN KEY([SifraProizvodjaca])
REFERENCES [dbo].[PROIZVODJAC] ([IDProizvodjaca])
ON UPDATE CASCADE
GO

CREATE TABLE [dbo].[KORISNIK](
	[KorisnickoIme] [nvarchar] (300) NOT NULL PRIMARY KEY,
	[Sifra] [nvarchar](30) NOT NULL,
	[Prezime] [nvarchar](30)  NOT NULL,
	[Ime] [nvarchar](30)  NOT NULL,
	[Status] [nvarchar](30) NOT NULL
)
GO