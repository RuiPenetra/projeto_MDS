
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/28/2019 13:28:57
-- Generated from EDMX file: C:\Users\Rui\Desktop\Projetos_2ºSemestre\Desenvolvimento de Aplicações\projeto\GesStand\GesStand\Model_GesStand.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GesStand];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroOficina] DROP CONSTRAINT [FK_ClienteCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficinaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servico] DROP CONSTRAINT [FK_CarroOficinaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoParcela]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[parcela] DROP CONSTRAINT [FK_ServicoParcela];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aluguer] DROP CONSTRAINT [FK_ClienteAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_AluguerCarroAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[aluguer] DROP CONSTRAINT [FK_AluguerCarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCarroVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_VendaCarroVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroOficina] DROP CONSTRAINT [FK_CarroOficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO
IF OBJECT_ID(N'[dbo].[Venda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venda];
GO
IF OBJECT_ID(N'[dbo].[Carro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro];
GO
IF OBJECT_ID(N'[dbo].[parcela]', 'U') IS NOT NULL
    DROP TABLE [dbo].[parcela];
GO
IF OBJECT_ID(N'[dbo].[Servico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servico];
GO
IF OBJECT_ID(N'[dbo].[aluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aluguer];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroOficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroOficina];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroVenda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] int  NOT NULL
);
GO

-- Creating table 'Venda'
CREATE TABLE [dbo].[Venda] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,2)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroVenda_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carro'
CREATE TABLE [dbo].[Carro] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'parcela'
CREATE TABLE [dbo].[parcela] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,2)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServicos] int  NOT NULL
);
GO

-- Creating table 'Servico'
CREATE TABLE [dbo].[Servico] (
    [IdServicos] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [DataSaida] datetime  NOT NULL,
    [CarroOficinaIdCarro] int  NOT NULL
);
GO

-- Creating table 'aluguer'
CREATE TABLE [dbo].[aluguer] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroOficina'
CREATE TABLE [dbo].[Carro_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] int  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroAluguer'
CREATE TABLE [dbo].[Carro_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroVenda'
CREATE TABLE [dbo].[Carro_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [PK_Venda]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro'
ALTER TABLE [dbo].[Carro]
ADD CONSTRAINT [PK_Carro]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdParcela] in table 'parcela'
ALTER TABLE [dbo].[parcela]
ADD CONSTRAINT [PK_parcela]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdServicos] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [PK_Servico]
    PRIMARY KEY CLUSTERED ([IdServicos] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'aluguer'
ALTER TABLE [dbo].[aluguer]
ADD CONSTRAINT [PK_aluguer]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [PK_Carro_CarroOficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro_CarroAluguer'
ALTER TABLE [dbo].[Carro_CarroAluguer]
ADD CONSTRAINT [PK_Carro_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [PK_Carro_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [FK_ClienteCarroOficina]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOficina'
CREATE INDEX [IX_FK_ClienteCarroOficina]
ON [dbo].[Carro_CarroOficina]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroOficinaIdCarro] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [FK_CarroOficinaServico]
    FOREIGN KEY ([CarroOficinaIdCarro])
    REFERENCES [dbo].[Carro_CarroOficina]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroOficinaServico'
CREATE INDEX [IX_FK_CarroOficinaServico]
ON [dbo].[Servico]
    ([CarroOficinaIdCarro]);
GO

-- Creating foreign key on [ServicoIdServicos] in table 'parcela'
ALTER TABLE [dbo].[parcela]
ADD CONSTRAINT [FK_ServicoParcela]
    FOREIGN KEY ([ServicoIdServicos])
    REFERENCES [dbo].[Servico]
        ([IdServicos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoParcela'
CREATE INDEX [IX_FK_ServicoParcela]
ON [dbo].[parcela]
    ([ServicoIdServicos]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'aluguer'
ALTER TABLE [dbo].[aluguer]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[aluguer]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'aluguer'
ALTER TABLE [dbo].[aluguer]
ADD CONSTRAINT [FK_AluguerCarroAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[Carro_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AluguerCarroAluguer'
CREATE INDEX [IX_FK_AluguerCarroAluguer]
ON [dbo].[aluguer]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Venda]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroVenda_IdCarro] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_IdCarro])
    REFERENCES [dbo].[Carro_CarroVenda]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[Venda]
    ([CarroVenda_IdCarro]);
GO

-- Creating foreign key on [IdCarro] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carro]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carro_CarroAluguer'
ALTER TABLE [dbo].[Carro_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carro]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carro]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------