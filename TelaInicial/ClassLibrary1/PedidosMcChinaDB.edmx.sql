
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2018 19:54:44
-- Generated from EDMX file: D:\Universidade Positivo - ADS\McChinaRestaurant\McChinaRestaurant\TelaInicial\ClassLibrary1\PedidosMcChinaDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PedidosSet'
CREATE TABLE [dbo].[PedidosSet] (
    [IdPedido] int IDENTITY(1,1) NOT NULL,
    [datapedido] datetime  NOT NULL,
    [tipopedido] nvarchar(max)  NOT NULL,
    [nomecliente] nvarchar(max)  NOT NULL,
    [UsuariosIdUsuario] int  NOT NULL
);
GO

-- Creating table 'UsuariosSet'
CREATE TABLE [dbo].[UsuariosSet] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [login] nvarchar(max)  NOT NULL,
    [senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProdutosSet'
CREATE TABLE [dbo].[ProdutosSet] (
    [IdProduto] int IDENTITY(1,1) NOT NULL,
    [nomeproduto] nvarchar(max)  NOT NULL,
    [valorproduto] float  NOT NULL,
    [PedidosIdPedido] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPedido] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [PK_PedidosSet]
    PRIMARY KEY CLUSTERED ([IdPedido] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [PK_UsuariosSet]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [IdProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [PK_ProdutosSet]
    PRIMARY KEY CLUSTERED ([IdProduto] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PedidosIdPedido] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [FK_PedidosProdutos]
    FOREIGN KEY ([PedidosIdPedido])
    REFERENCES [dbo].[PedidosSet]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidosProdutos'
CREATE INDEX [IX_FK_PedidosProdutos]
ON [dbo].[ProdutosSet]
    ([PedidosIdPedido]);
GO

-- Creating foreign key on [UsuariosIdUsuario] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [FK_UsuariosPedidos]
    FOREIGN KEY ([UsuariosIdUsuario])
    REFERENCES [dbo].[UsuariosSet]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosPedidos'
CREATE INDEX [IX_FK_UsuariosPedidos]
ON [dbo].[PedidosSet]
    ([UsuariosIdUsuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------