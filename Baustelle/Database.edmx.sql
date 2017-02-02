
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/19/2015 14:25:03
-- Generated from EDMX file: C:\Users\HeatPwnz\Documents\GitHub\r1544\Aplikacija\Baustelle\Baustelle\Database.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BaustelleDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_JedinicaMjereMaterijal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MaterijalSet] DROP CONSTRAINT [FK_JedinicaMjereMaterijal];
GO
IF OBJECT_ID(N'[dbo].[FK_MaterijalStavkaUsluge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StavkaUslugeSet] DROP CONSTRAINT [FK_MaterijalStavkaUsluge];
GO
IF OBJECT_ID(N'[dbo].[FK_UslugaStavkaUsluge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StavkaUslugeSet] DROP CONSTRAINT [FK_UslugaStavkaUsluge];
GO
IF OBJECT_ID(N'[dbo].[FK_ZaspolenikUsluga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UslugaSet] DROP CONSTRAINT [FK_ZaspolenikUsluga];
GO
IF OBJECT_ID(N'[dbo].[FK_UlogaZaspolenik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ZaspolenikSet] DROP CONSTRAINT [FK_UlogaZaspolenik];
GO
IF OBJECT_ID(N'[dbo].[FK_ZaspolenikPonuda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PonudaSet] DROP CONSTRAINT [FK_ZaspolenikPonuda];
GO
IF OBJECT_ID(N'[dbo].[FK_PonudaStavkaPonude]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StavkaPonudeSet] DROP CONSTRAINT [FK_PonudaStavkaPonude];
GO
IF OBJECT_ID(N'[dbo].[FK_UslugaStavkaPonude]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StavkaPonudeSet] DROP CONSTRAINT [FK_UslugaStavkaPonude];
GO
IF OBJECT_ID(N'[dbo].[FK_KlijentPonuda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PonudaSet] DROP CONSTRAINT [FK_KlijentPonuda];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[JedinicaMjereSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JedinicaMjereSet];
GO
IF OBJECT_ID(N'[dbo].[MaterijalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaterijalSet];
GO
IF OBJECT_ID(N'[dbo].[UslugaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UslugaSet];
GO
IF OBJECT_ID(N'[dbo].[StavkaUslugeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StavkaUslugeSet];
GO
IF OBJECT_ID(N'[dbo].[ZaspolenikSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ZaspolenikSet];
GO
IF OBJECT_ID(N'[dbo].[UlogaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UlogaSet];
GO
IF OBJECT_ID(N'[dbo].[KlijentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KlijentSet];
GO
IF OBJECT_ID(N'[dbo].[PonudaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PonudaSet];
GO
IF OBJECT_ID(N'[dbo].[StavkaPonudeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StavkaPonudeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'JedinicaMjereSet'
CREATE TABLE [dbo].[JedinicaMjereSet] (
    [IdJedinicaMjere] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [SkraceniNaziv] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MaterijalSet'
CREATE TABLE [dbo].[MaterijalSet] (
    [IdMaterijal] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Napomena] nvarchar(max)  NOT NULL,
    [JedinicaMjereId] int  NOT NULL
);
GO

-- Creating table 'UslugaSet'
CREATE TABLE [dbo].[UslugaSet] (
    [IdUsluge] int IDENTITY(1,1) NOT NULL,
    [ZaposlenikId] int  NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Cijena] decimal(18,0)  NOT NULL,
    [DatumKreiranja] datetime  NOT NULL
);
GO

-- Creating table 'StavkaUslugeSet'
CREATE TABLE [dbo].[StavkaUslugeSet] (
    [IdStavkaUsluge] int IDENTITY(1,1) NOT NULL,
    [UslugaId] int  NOT NULL,
    [MaterijalId] int  NOT NULL,
    [Kolicina] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'ZaspolenikSet'
CREATE TABLE [dbo].[ZaspolenikSet] (
    [IdZaposlenik] int IDENTITY(1,1) NOT NULL,
    [UlogaId] int  NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [DatumRodjenja] datetime  NOT NULL,
    [OIB] nvarchar(max)  NOT NULL,
    [Adresa] nvarchar(max)  NOT NULL,
    [Kontakt] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UlogaSet'
CREATE TABLE [dbo].[UlogaSet] (
    [IdUloga] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KlijentSet'
CREATE TABLE [dbo].[KlijentSet] (
    [IdKlijent] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [OIB] nvarchar(max)  NOT NULL,
    [Adresa] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PonudaSet'
CREATE TABLE [dbo].[PonudaSet] (
    [IdPonuda] int IDENTITY(1,1) NOT NULL,
    [KlijentId] int  NOT NULL,
    [ZaposlenikId] int  NOT NULL,
    [DatumIzdavanja] datetime  NOT NULL,
    [Napomena] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StavkaPonudeSet'
CREATE TABLE [dbo].[StavkaPonudeSet] (
    [IdStavkePonude] int IDENTITY(1,1) NOT NULL,
    [PonudaId] int  NOT NULL,
    [UslugaId] int  NOT NULL,
    [Kolicina] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdJedinicaMjere] in table 'JedinicaMjereSet'
ALTER TABLE [dbo].[JedinicaMjereSet]
ADD CONSTRAINT [PK_JedinicaMjereSet]
    PRIMARY KEY CLUSTERED ([IdJedinicaMjere] ASC);
GO

-- Creating primary key on [IdMaterijal] in table 'MaterijalSet'
ALTER TABLE [dbo].[MaterijalSet]
ADD CONSTRAINT [PK_MaterijalSet]
    PRIMARY KEY CLUSTERED ([IdMaterijal] ASC);
GO

-- Creating primary key on [IdUsluge] in table 'UslugaSet'
ALTER TABLE [dbo].[UslugaSet]
ADD CONSTRAINT [PK_UslugaSet]
    PRIMARY KEY CLUSTERED ([IdUsluge] ASC);
GO

-- Creating primary key on [IdStavkaUsluge] in table 'StavkaUslugeSet'
ALTER TABLE [dbo].[StavkaUslugeSet]
ADD CONSTRAINT [PK_StavkaUslugeSet]
    PRIMARY KEY CLUSTERED ([IdStavkaUsluge] ASC);
GO

-- Creating primary key on [IdZaposlenik] in table 'ZaspolenikSet'
ALTER TABLE [dbo].[ZaspolenikSet]
ADD CONSTRAINT [PK_ZaspolenikSet]
    PRIMARY KEY CLUSTERED ([IdZaposlenik] ASC);
GO

-- Creating primary key on [IdUloga] in table 'UlogaSet'
ALTER TABLE [dbo].[UlogaSet]
ADD CONSTRAINT [PK_UlogaSet]
    PRIMARY KEY CLUSTERED ([IdUloga] ASC);
GO

-- Creating primary key on [IdKlijent] in table 'KlijentSet'
ALTER TABLE [dbo].[KlijentSet]
ADD CONSTRAINT [PK_KlijentSet]
    PRIMARY KEY CLUSTERED ([IdKlijent] ASC);
GO

-- Creating primary key on [IdPonuda] in table 'PonudaSet'
ALTER TABLE [dbo].[PonudaSet]
ADD CONSTRAINT [PK_PonudaSet]
    PRIMARY KEY CLUSTERED ([IdPonuda] ASC);
GO

-- Creating primary key on [IdStavkePonude] in table 'StavkaPonudeSet'
ALTER TABLE [dbo].[StavkaPonudeSet]
ADD CONSTRAINT [PK_StavkaPonudeSet]
    PRIMARY KEY CLUSTERED ([IdStavkePonude] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [JedinicaMjereId] in table 'MaterijalSet'
ALTER TABLE [dbo].[MaterijalSet]
ADD CONSTRAINT [FK_JedinicaMjereMaterijal]
    FOREIGN KEY ([JedinicaMjereId])
    REFERENCES [dbo].[JedinicaMjereSet]
        ([IdJedinicaMjere])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_JedinicaMjereMaterijal'
CREATE INDEX [IX_FK_JedinicaMjereMaterijal]
ON [dbo].[MaterijalSet]
    ([JedinicaMjereId]);
GO

-- Creating foreign key on [MaterijalId] in table 'StavkaUslugeSet'
ALTER TABLE [dbo].[StavkaUslugeSet]
ADD CONSTRAINT [FK_MaterijalStavkaUsluge]
    FOREIGN KEY ([MaterijalId])
    REFERENCES [dbo].[MaterijalSet]
        ([IdMaterijal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterijalStavkaUsluge'
CREATE INDEX [IX_FK_MaterijalStavkaUsluge]
ON [dbo].[StavkaUslugeSet]
    ([MaterijalId]);
GO

-- Creating foreign key on [UslugaId] in table 'StavkaUslugeSet'
ALTER TABLE [dbo].[StavkaUslugeSet]
ADD CONSTRAINT [FK_UslugaStavkaUsluge]
    FOREIGN KEY ([UslugaId])
    REFERENCES [dbo].[UslugaSet]
        ([IdUsluge])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UslugaStavkaUsluge'
CREATE INDEX [IX_FK_UslugaStavkaUsluge]
ON [dbo].[StavkaUslugeSet]
    ([UslugaId]);
GO

-- Creating foreign key on [ZaposlenikId] in table 'UslugaSet'
ALTER TABLE [dbo].[UslugaSet]
ADD CONSTRAINT [FK_ZaspolenikUsluga]
    FOREIGN KEY ([ZaposlenikId])
    REFERENCES [dbo].[ZaspolenikSet]
        ([IdZaposlenik])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZaspolenikUsluga'
CREATE INDEX [IX_FK_ZaspolenikUsluga]
ON [dbo].[UslugaSet]
    ([ZaposlenikId]);
GO

-- Creating foreign key on [UlogaId] in table 'ZaspolenikSet'
ALTER TABLE [dbo].[ZaspolenikSet]
ADD CONSTRAINT [FK_UlogaZaspolenik]
    FOREIGN KEY ([UlogaId])
    REFERENCES [dbo].[UlogaSet]
        ([IdUloga])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UlogaZaspolenik'
CREATE INDEX [IX_FK_UlogaZaspolenik]
ON [dbo].[ZaspolenikSet]
    ([UlogaId]);
GO

-- Creating foreign key on [ZaposlenikId] in table 'PonudaSet'
ALTER TABLE [dbo].[PonudaSet]
ADD CONSTRAINT [FK_ZaspolenikPonuda]
    FOREIGN KEY ([ZaposlenikId])
    REFERENCES [dbo].[ZaspolenikSet]
        ([IdZaposlenik])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ZaspolenikPonuda'
CREATE INDEX [IX_FK_ZaspolenikPonuda]
ON [dbo].[PonudaSet]
    ([ZaposlenikId]);
GO

-- Creating foreign key on [PonudaId] in table 'StavkaPonudeSet'
ALTER TABLE [dbo].[StavkaPonudeSet]
ADD CONSTRAINT [FK_PonudaStavkaPonude]
    FOREIGN KEY ([PonudaId])
    REFERENCES [dbo].[PonudaSet]
        ([IdPonuda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PonudaStavkaPonude'
CREATE INDEX [IX_FK_PonudaStavkaPonude]
ON [dbo].[StavkaPonudeSet]
    ([PonudaId]);
GO

-- Creating foreign key on [UslugaId] in table 'StavkaPonudeSet'
ALTER TABLE [dbo].[StavkaPonudeSet]
ADD CONSTRAINT [FK_UslugaStavkaPonude]
    FOREIGN KEY ([UslugaId])
    REFERENCES [dbo].[UslugaSet]
        ([IdUsluge])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UslugaStavkaPonude'
CREATE INDEX [IX_FK_UslugaStavkaPonude]
ON [dbo].[StavkaPonudeSet]
    ([UslugaId]);
GO

-- Creating foreign key on [KlijentId] in table 'PonudaSet'
ALTER TABLE [dbo].[PonudaSet]
ADD CONSTRAINT [FK_KlijentPonuda]
    FOREIGN KEY ([KlijentId])
    REFERENCES [dbo].[KlijentSet]
        ([IdKlijent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_KlijentPonuda'
CREATE INDEX [IX_FK_KlijentPonuda]
ON [dbo].[PonudaSet]
    ([KlijentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------