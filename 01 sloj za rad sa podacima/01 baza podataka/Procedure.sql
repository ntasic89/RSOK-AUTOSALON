CREATE PROCEDURE [DodajNovogProizvodjaca]
( 
@IDProizvodjaca nvarchar(10),
@NazivProizvodjaca nvarchar(10),
@Tip nvarchar(100)
)
AS
BEGIN
Insert into PROIZVODJAC(IDProizvodjaca, NazivProizvodjaca, Tip) values (@IDProizvodjaca, @NazivProizvodjaca, @Tip)
END
GO

CREATE PROCEDURE [DodajNoviModel]
( 
@IDModela nvarchar(10),
@NazivModela nvarchar(100),
@Motor nvarchar(100),
@Godina nvarchar(100),
@SifraBoje nvarchar(10),
@SifraProizvodjaca nvarchar(10)
)
AS
BEGIN
Insert into MODEL(IDModela, NazivModela, Motor,Godina, SifraBoje, SifraProizvodjaca) values (@IDModela, @NazivModela, @Motor, @Godina, @SifraBoje, @SifraProizvodjaca)
END
GO


CREATE PROCEDURE [DajSveProizvodjace]
AS
select * from PROIZVODJAC
GO

CREATE PROCEDURE [DajProizvodjacaPoNazivu]
(
@NazivProizvodjaca nvarchar(100)
)
AS
select * from PROIZVODJAC where NazivProizvodjaca=@NazivProizvodjaca
GO

CREATE PROCEDURE [DajSveModeleIProizvodjaca]
AS
select Model.IDModela, Model.NazivModela, Proizvodjac.NazivProizvodjaca, Model.Motor, Model.Godina, Model.SifraBoje, Proizvodjac.Tip from Model inner join Proizvodjac on Model.SifraProizvodjaca=Proizvodjac.IDProizvodjaca
GO

CREATE PROCEDURE [DajSveModeleINazivProizv]
AS
select Model.IDModela, Model.NazivModela, Proizvodjac.NazivProizvodjaca, Model.Motor, Model.Godina, Model.SifraBoje from Model inner join Proizvodjac on Model.SifraProizvodjaca=Proizvodjac.IDProizvodjaca
GO


CREATE PROCEDURE [DajSveModele]
AS
select * from MODEL
GO

CREATE PROCEDURE [DajModelPoNazivu]
(
@NazivModela nvarchar(100)
)
AS
select * from MODEL where NazivModela=@NazivModela
GO


CREATE PROCEDURE [ObrisiModel](
@IDModela nvarchar(10))
AS
BEGIN
Delete from MODEL where IDModela=@IDModela
END
GO

CREATE PROCEDURE [IzmeniModel](
@StariIDModela nvarchar(10),
@IDModela nvarchar(10),
@NazivModela nvarchar(100),
@Motor nvarchar(100),
@Godina nvarchar(100)
AS
BEGIN
Update MODEL set IDModela=@IDModela, NazivModela=@NazivModela, Motor=@Motor,Godina=@Godina where IDModela=@StariIDModela
END
GO

CREATE PROCEDURE [DajModeleIProizvodjacaPoSifriModela]
(
@IDModela nvarchar(10)
)
AS
select Model.IDModela, Model.NazivModela, Model.Motor, Model.Godina, Model.SifraBoje from Model inner join PROIZVODJAC on Model.SifraProizvodjaca=PROIZVODJAC.IDProizvodjaca where MODEL.IDModela=@IDModela
GO

CREATE PROCEDURE [DajKorisnikePoKISifri]
(
@KorisnickoIme nvarchar(300),
@Sifra nvarchar(30)
)
AS
select * from Korisnik where KorisnickoIme=@KorisnickoIme and Sifra=@Sifra
GO


