USE [master]
GO
/****** Object:  Database [WystawianieFS_prod]    Script Date: 15.01.2025 14:48:34 ******/
CREATE DATABASE [WystawianieFS_prod]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WystawianieFS_prod', FILENAME = N'C:\Users\borub\WystawianieFS_prod.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WystawianieFS_prod_log', FILENAME = N'C:\Users\borub\WystawianieFS_prod_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WystawianieFS_prod] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WystawianieFS_prod].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WystawianieFS_prod] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET ARITHABORT OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WystawianieFS_prod] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WystawianieFS_prod] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WystawianieFS_prod] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WystawianieFS_prod] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WystawianieFS_prod] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WystawianieFS_prod] SET  MULTI_USER 
GO
ALTER DATABASE [WystawianieFS_prod] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WystawianieFS_prod] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WystawianieFS_prod] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WystawianieFS_prod] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WystawianieFS_prod] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WystawianieFS_prod] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WystawianieFS_prod] SET QUERY_STORE = OFF
GO
USE [WystawianieFS_prod]
GO
/****** Object:  Table [dbo].[FS_Cena]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FS_Cena](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FSID] [int] NOT NULL,
	[CenaID] [int] NULL,
	[ArchiwumCenID] [int] NULL,
	[IloscTowaru] [decimal](18, 2) NOT NULL,
	[CNprzelicz] [decimal](18, 4) NULL,
	[CBprzelicz] [decimal](18, 4) NULL,
 CONSTRAINT [PK_FS_Towary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Towary]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[Kod] [nvarchar](8) NOT NULL,
	[JM] [nvarchar](3) NOT NULL,
	[VAT] [int] NOT NULL,
 CONSTRAINT [PK_Towary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [TowaryKod_uq] UNIQUE NONCLUSTERED 
(
	[Kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ceny]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ceny](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TowarID] [int] NOT NULL,
	[DataNabycia] [datetime2](7) NOT NULL,
	[CenaNetto] [decimal](18, 4) NOT NULL,
	[CenaBrutto] [decimal](18, 4) NULL,
	[Waluta] [nvarchar](3) NOT NULL,
	[Aktualny] [bit] NULL,
	[Ilosc] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Ceny] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PozycjeNaFakturzeView]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[PozycjeNaFakturzeView]
AS
SELECT dbo.Towary.Nazwa, 
	   dbo.Towary.Kod, 
	   dbo.Towary.JM, 
	   dbo.Towary.VAT, 
	   dbo.Ceny.ID, 
	   dbo.Ceny.DataNabycia, 
	   dbo.Ceny.CenaNetto, 
	   dbo.Ceny.CenaBrutto, 
	   dbo.Ceny.Waluta, 
	   dbo.Ceny.Aktualny, 
	   dbo.Ceny.Ilosc, 
	   dbo.FS_Cena.CNprzelicz, 
       dbo.FS_Cena.CBprzelicz
FROM dbo.Ceny INNER JOIN dbo.FS_Cena 
	ON dbo.Ceny.ID = dbo.FS_Cena.CenaID 
			  INNER JOIN dbo.Towary 
	ON dbo.Ceny.TowarID = dbo.Towary.ID
GO
/****** Object:  Table [dbo].[ArchiwumCen]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArchiwumCen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TowarID] [int] NOT NULL,
	[DataNabycia] [datetime2](7) NOT NULL,
	[CenaNetto] [decimal](18, 4) NOT NULL,
	[CenaBrutto] [decimal](18, 4) NOT NULL,
	[Waluta] [nchar](3) NOT NULL,
	[Aktualny] [bit] NULL,
	[Ilosc] [decimal](18, 4) NOT NULL,
	[DataWyzerowania] [datetime2](7) NULL,
	[CenaID] [int] NOT NULL,
 CONSTRAINT [PK_ArchiwumCen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaneLogowania]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaneLogowania](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kod] [nvarchar](6) NOT NULL,
	[Imie] [nvarchar](30) NOT NULL,
	[Nazwisko] [nvarchar](30) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_DaneLogowania] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Kod_uq] UNIQUE NONCLUSTERED 
(
	[Kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firmy]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firmy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[NIP] [nvarchar](10) NOT NULL,
	[Miasto] [nvarchar](50) NOT NULL,
	[Ulica] [nvarchar](30) NOT NULL,
	[KodPocztowy] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Firmy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [NIP_uq] UNIQUE NONCLUSTERED 
(
	[NIP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FS]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KontrahentID] [int] NOT NULL,
	[FirmaID] [int] NOT NULL,
	[Nazwa] [nvarchar](30) NOT NULL,
	[NumerFaktury] [nvarchar](15) NOT NULL,
	[DataWystawienia] [datetime2](7) NOT NULL,
	[MiejsceWystawienia] [nvarchar](30) NOT NULL,
	[DataSprzedazy] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_FS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [NrFaktury_uq] UNIQUE NONCLUSTERED 
(
	[NumerFaktury] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kontrahenci]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kontrahenci](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[Akronim] [nvarchar](7) NOT NULL,
	[NIP] [nvarchar](10) NOT NULL,
	[Miasto] [nvarchar](50) NOT NULL,
	[Ulica] [nvarchar](30) NOT NULL,
	[KodPocztowy] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Kontrahenci] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [KontrahenciAkr_uq] UNIQUE NONCLUSTERED 
(
	[Akronim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [KontrahenciNIP_uq] UNIQUE NONCLUSTERED 
(
	[NIP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FS]  WITH CHECK ADD  CONSTRAINT [FK_FS_Firmy_FirmaID] FOREIGN KEY([FirmaID])
REFERENCES [dbo].[Firmy] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FS] CHECK CONSTRAINT [FK_FS_Firmy_FirmaID]
GO
ALTER TABLE [dbo].[FS]  WITH CHECK ADD  CONSTRAINT [FK_FS_Kontrahenci_KontrahentID] FOREIGN KEY([KontrahentID])
REFERENCES [dbo].[Kontrahenci] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FS] CHECK CONSTRAINT [FK_FS_Kontrahenci_KontrahentID]
GO
ALTER TABLE [dbo].[FS_Cena]  WITH CHECK ADD  CONSTRAINT [FK_FS_Ceny_ArchiwumCen_ArchiwumCenID] FOREIGN KEY([ArchiwumCenID])
REFERENCES [dbo].[ArchiwumCen] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FS_Cena] CHECK CONSTRAINT [FK_FS_Ceny_ArchiwumCen_ArchiwumCenID]
GO
ALTER TABLE [dbo].[FS_Cena]  WITH CHECK ADD  CONSTRAINT [FK_FS_Ceny_Ceny_CenaID] FOREIGN KEY([CenaID])
REFERENCES [dbo].[Ceny] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FS_Cena] CHECK CONSTRAINT [FK_FS_Ceny_Ceny_CenaID]
GO
ALTER TABLE [dbo].[FS_Cena]  WITH CHECK ADD  CONSTRAINT [FK_FS_Towary_FS_FSID] FOREIGN KEY([FSID])
REFERENCES [dbo].[FS] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FS_Cena] CHECK CONSTRAINT [FK_FS_Towary_FS_FSID]
GO
/****** Object:  StoredProcedure [dbo].[PobierzDaneFaktury]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PobierzDaneFaktury]
    @FakturaID INT
AS
BEGIN
    SELECT 
        fs.NumerFaktury,                      -- Numer faktury
        fs.DataWystawienia,                   -- Data wystawienia faktury
        fsc.IloscTowaru,                      -- Ilość towaru
        t.Kod,                                -- Kod towaru
        t.JM,                                 -- Jednostka miary towaru
        ISNULL(c.CenaNetto, ac.CenaNetto) AS CenaNetto,     -- Cena netto z tabeli Ceny lub ArchiwumCen
        ISNULL(c.CenaBrutto, ac.CenaBrutto) AS CenaBrutto,  -- Cena brutto z tabeli Ceny lub ArchiwumCen
        fsc.CNprzelicz,                       -- Przeliczona cena netto
        fsc.CBprzelicz,                       -- Przeliczona cena brutto
        ISNULL(c.Waluta, ac.Waluta) AS Waluta -- Waluta z tabeli Ceny lub ArchiwumCen
    FROM 
        FS fs
    INNER JOIN 
        FS_Cena fsc ON fs.ID = fsc.FSID  -- Powiązanie faktury z tabelą łącznika
    LEFT JOIN 
        Ceny c ON fsc.CenaID = c.ID     -- Powiązanie z Ceny, jeśli Ilosc > 0
    LEFT JOIN 
        ArchiwumCen ac ON fsc.ArchiwumCenID = ac.ID -- Powiązanie z ArchiwumCen, jeśli Ilosc = 0
    LEFT JOIN 
        Towary t ON t.ID = ISNULL(c.TowarID, ac.TowarID)   -- Pobranie informacji o towarze przez Ceny lub ArchiwumCen
    WHERE 
        fs.ID = @FakturaID;
END;
GO
/****** Object:  StoredProcedure [dbo].[PobierzFakturyKontrahenta]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PobierzFakturyKontrahenta]
    @KontrahentID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.Kontrahenci WHERE ID = @KontrahentID)
    BEGIN
        SELECT k.Nazwa,
			   k.Akronim,
			   k.NIP,
			   k.Email,
			   fs.Nazwa,
			   fs.NumerFaktury,
			   fs.DataWystawienia,
			   fs.DataSprzedazy
        FROM dbo.FS fs
		JOIN Kontrahenci k
		ON KontrahentID = k.ID
        WHERE fs.KontrahentID = @KontrahentID;
    END
    ELSE
    BEGIN
        PRINT 'Kontrahent o podanym ID nie istnieje';
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[UstawFlageAktualny]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Konrad Kurpiel>
-- Create date: <14-01-2025>
-- =============================================
CREATE PROCEDURE [dbo].[UstawFlageAktualny]
	@ID INT
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE 
		dbo.Ceny 
	SET
		Aktualny = 1
	WHERE
		ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[UsunDaneZTabeli]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UsunDaneZTabeli]
    @NazwaTabeli NVARCHAR(128)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @sql NVARCHAR(MAX);

    -- Budowanie dynamicznego zapytania do usunięcia danych
    SET @sql = N'DELETE FROM ' + QUOTENAME(@NazwaTabeli) + ';';
    
    -- Wykonywanie zapytania
    EXEC sp_executesql @sql;

    -- Resetowanie identyfikatora
    SET @sql = N'DBCC CHECKIDENT(' + QUOTENAME(@NazwaTabeli) + ', RESEED, 1);';
    EXEC sp_executesql @sql;

    PRINT 'Dane zostały usunięte, a identyfikator zresetowany.';
END;

GO
/****** Object:  Trigger [dbo].[DodajCeneBrutto]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Konrad,,Kurpiel>
-- Create date: <2024/10/24>
-- Description:	<Updating CenaBrutto>
-- =============================================
CREATE TRIGGER [dbo].[DodajCeneBrutto]
   ON  [dbo].[Ceny]
   AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;

    UPDATE c SET c.CenaBrutto = i.CenaNetto + (i.CenaNetto * t.VAT/100)
		FROM dbo.Ceny c
		JOIN inserted i ON c.ID = i.ID
		JOIN Towary t ON c.TowarID = t.ID;

END
GO
ALTER TABLE [dbo].[Ceny] ENABLE TRIGGER [DodajCeneBrutto]
GO
/****** Object:  Trigger [dbo].[PrzeniesDoArchiwumCen]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
CREATE TRIGGER [dbo].[PrzeniesDoArchiwumCen]
   ON  [dbo].[Ceny]
   AFTER UPDATE
AS 
BEGIN
    SET NOCOUNT ON;

    -- Przenieś ceny do ArchiwumCen, gdy Ilosc = 0
    INSERT INTO dbo.ArchiwumCen (TowarID, DataNabycia, CenaNetto, CenaBrutto, Waluta, Ilosc, DataWyzerowania, CenaID)
    SELECT 
        c.TowarID, 
        c.DataNabycia, 
        c.CenaNetto, 
        c.CenaBrutto, 
        c.Waluta, 
        c.Ilosc, 
        CAST(SYSDATETIME() AS datetime2(7)) AS DataWyzerowania,
		c.ID
    FROM dbo.Ceny c
    WHERE Ilosc = 0 
      AND ID IN (SELECT ID FROM inserted);
    
	-- Zaktualizuj relacje w FS_Cena przy przeniesieniu zmień relacje na ArchiwumCen
	UPDATE dbo.FS_Cena 
	SET CenaID = NULL,
    ArchiwumCenID = (SELECT a.ID 
                     FROM dbo.ArchiwumCen a 
                     WHERE a.CenaID IN (SELECT ID FROM inserted) 
                     AND a.CenaID IS NOT NULL)
	WHERE CenaID IN (SELECT ID FROM inserted WHERE Ilosc = 0);

    -- Usunięcie przeniesionych cen z tabeli Ceny
    DELETE FROM dbo.Ceny
    WHERE Ilosc = 0 
      AND ID IN (SELECT ID FROM inserted);
END;
GO
ALTER TABLE [dbo].[Ceny] ENABLE TRIGGER [PrzeniesDoArchiwumCen]
GO
/****** Object:  Trigger [dbo].[UstawAktualny]    Script Date: 15.01.2025 14:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE TRIGGER [dbo].[UstawAktualny]
   ON  [dbo].[Ceny]
   AFTER INSERT, UPDATE
AS 
BEGIN
    SET NOCOUNT ON;
	DECLARE @ID INT;
    -- Zaktualizuj flagi Aktualny dla wszystkich towarów
    UPDATE dbo.Ceny 
    SET Aktualny = 0 
    WHERE TowarID IN (SELECT DISTINCT TowarID FROM inserted) 
      AND Waluta IN (SELECT DISTINCT Waluta FROM inserted) 
      AND Aktualny = 1;

    -- Ustaw najstarszą cenę jako aktualną dla każdego towaru w danej walucie
    SELECT TOP 1 @ID = ID 
    FROM dbo.Ceny
    WHERE TowarID IN (SELECT DISTINCT TowarID FROM inserted) 
      AND Waluta IN (SELECT DISTINCT Waluta FROM inserted) 
      AND Ilosc > 0
    ORDER BY DataNabycia ASC

	EXEC [dbo].[UstawFlageAktualny] @ID = ID
END
GO
ALTER TABLE [dbo].[Ceny] ENABLE TRIGGER [UstawAktualny]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "FS_Cena"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Ceny"
            Begin Extent = 
               Top = 10
               Left = 301
               Bottom = 173
               Right = 495
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Towary"
            Begin Extent = 
               Top = 7
               Left = 539
               Bottom = 170
               Right = 733
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 2928
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PozycjeNaFakturzeView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PozycjeNaFakturzeView'
GO
USE [master]
GO
ALTER DATABASE [WystawianieFS_prod] SET  READ_WRITE 
GO

