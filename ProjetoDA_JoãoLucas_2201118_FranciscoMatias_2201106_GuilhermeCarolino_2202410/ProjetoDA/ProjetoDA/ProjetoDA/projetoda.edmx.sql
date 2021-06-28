
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/24/2021 18:54:08
-- Generated from EDMX file: C:\Users\joaol\OneDrive\Ambiente de Trabalho\ProjetoDA (2)\ProjetoDA\ProjetoDA\projetoda.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [projetoda];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EscolaFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Filho] DROP CONSTRAINT [FK_EscolaFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Filho] DROP CONSTRAINT [FK_ClienteFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_ClienteCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalheCompraCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompra] DROP CONSTRAINT [FK_DetalheCompraCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhoInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscricao] DROP CONSTRAINT [FK_FilhoInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolaParticipacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participacao] DROP CONSTRAINT [FK_EscolaParticipacao];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoParticipacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participacao] DROP CONSTRAINT [FK_EventoParticipacao];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimadorColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colaboracao] DROP CONSTRAINT [FK_AnimadorColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colaboracao] DROP CONSTRAINT [FK_EventoColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inscricao] DROP CONSTRAINT [FK_EventoInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoDetalheCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompra] DROP CONSTRAINT [FK_ProdutoDetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoTipoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produto] DROP CONSTRAINT [FK_ProdutoTipoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_Filho_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Filho] DROP CONSTRAINT [FK_Filho_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Animador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Animador] DROP CONSTRAINT [FK_Animador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa];
GO
IF OBJECT_ID(N'[dbo].[Escola]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Escola];
GO
IF OBJECT_ID(N'[dbo].[Compra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Compra];
GO
IF OBJECT_ID(N'[dbo].[DetalheCompra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[TipoProduto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProduto];
GO
IF OBJECT_ID(N'[dbo].[Inscricao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inscricao];
GO
IF OBJECT_ID(N'[dbo].[Participacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Participacao];
GO
IF OBJECT_ID(N'[dbo].[Evento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evento];
GO
IF OBJECT_ID(N'[dbo].[Colaboracao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Colaboracao];
GO
IF OBJECT_ID(N'[dbo].[Produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produto];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Filho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Filho];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Animador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Animador];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [IdPessoa] bigint IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Escola'
CREATE TABLE [dbo].[Escola] (
    [IdEscola] bigint IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [Codpostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Compra'
CREATE TABLE [dbo].[Compra] (
    [NrCompra] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL,
    [IdCliente] bigint  NOT NULL,
    [ProdutosCodProduto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetalheCompra'
CREATE TABLE [dbo].[DetalheCompra] (
    [Quantidade] nvarchar(max)  NOT NULL,
    [ComprasNrCompras] int  NOT NULL,
    [ProdutoCodProduto] int  NOT NULL
);
GO

-- Creating table 'TipoProduto'
CREATE TABLE [dbo].[TipoProduto] (
    [Tipo] nvarchar(max)  NOT NULL,
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Inscricao'
CREATE TABLE [dbo].[Inscricao] (
    [Confirmada] nvarchar(max)  NOT NULL,
    [FilhoIdPessoa] bigint  NOT NULL,
    [EventoNrEvento] int  NOT NULL
);
GO

-- Creating table 'Participacao'
CREATE TABLE [dbo].[Participacao] (
    [IdEscola] bigint  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'Evento'
CREATE TABLE [dbo].[Evento] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] nvarchar(max)  NOT NULL,
    [LimiteParticipacao] nvarchar(max)  NOT NULL,
    [IdadeInferior] nvarchar(max)  NOT NULL,
    [IdadeSuperior] nvarchar(max)  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Colaboracao'
CREATE TABLE [dbo].[Colaboracao] (
    [IdAnimador] bigint  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'Produto'
CREATE TABLE [dbo].[Produto] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [StockExistente] int  NOT NULL,
    [CodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'Pessoa_Filho'
CREATE TABLE [dbo].[Pessoa_Filho] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [IdEscola] bigint  NOT NULL,
    [IdProgenitor] bigint  NOT NULL,
    [IdPessoa] bigint  NOT NULL
);
GO

-- Creating table 'Pessoa_Cliente'
CREATE TABLE [dbo].[Pessoa_Cliente] (
    [ValorOferta] nvarchar(max)  NOT NULL,
    [NrCartao] nvarchar(max)  NOT NULL,
    [IdPessoa] bigint  NOT NULL
);
GO

-- Creating table 'Pessoa_Animador'
CREATE TABLE [dbo].[Pessoa_Animador] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdEscola] in table 'Escola'
ALTER TABLE [dbo].[Escola]
ADD CONSTRAINT [PK_Escola]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [NrCompra] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [PK_Compra]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [ComprasNrCompras], [ProdutoCodProduto] in table 'DetalheCompra'
ALTER TABLE [dbo].[DetalheCompra]
ADD CONSTRAINT [PK_DetalheCompra]
    PRIMARY KEY CLUSTERED ([ComprasNrCompras], [ProdutoCodProduto] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProduto'
ALTER TABLE [dbo].[TipoProduto]
ADD CONSTRAINT [PK_TipoProduto]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [FilhoIdPessoa], [EventoNrEvento] in table 'Inscricao'
ALTER TABLE [dbo].[Inscricao]
ADD CONSTRAINT [PK_Inscricao]
    PRIMARY KEY CLUSTERED ([FilhoIdPessoa], [EventoNrEvento] ASC);
GO

-- Creating primary key on [IdEscola], [NrEvento] in table 'Participacao'
ALTER TABLE [dbo].[Participacao]
ADD CONSTRAINT [PK_Participacao]
    PRIMARY KEY CLUSTERED ([IdEscola], [NrEvento] ASC);
GO

-- Creating primary key on [NrEvento] in table 'Evento'
ALTER TABLE [dbo].[Evento]
ADD CONSTRAINT [PK_Evento]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [IdAnimador], [NrEvento] in table 'Colaboracao'
ALTER TABLE [dbo].[Colaboracao]
ADD CONSTRAINT [PK_Colaboracao]
    PRIMARY KEY CLUSTERED ([IdAnimador], [NrEvento] ASC);
GO

-- Creating primary key on [CodProduto] in table 'Produto'
ALTER TABLE [dbo].[Produto]
ADD CONSTRAINT [PK_Produto]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoa_Filho'
ALTER TABLE [dbo].[Pessoa_Filho]
ADD CONSTRAINT [PK_Pessoa_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [PK_Pessoa_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoa_Animador'
ALTER TABLE [dbo].[Pessoa_Animador]
ADD CONSTRAINT [PK_Pessoa_Animador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEscola] in table 'Pessoa_Filho'
ALTER TABLE [dbo].[Pessoa_Filho]
ADD CONSTRAINT [FK_EscolaFilho]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[Escola]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaFilho'
CREATE INDEX [IX_FK_EscolaFilho]
ON [dbo].[Pessoa_Filho]
    ([IdEscola]);
GO

-- Creating foreign key on [IdProgenitor] in table 'Pessoa_Filho'
ALTER TABLE [dbo].[Pessoa_Filho]
ADD CONSTRAINT [FK_ClienteFilho]
    FOREIGN KEY ([IdProgenitor])
    REFERENCES [dbo].[Pessoa_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFilho'
CREATE INDEX [IX_FK_ClienteFilho]
ON [dbo].[Pessoa_Filho]
    ([IdProgenitor]);
GO

-- Creating foreign key on [IdCliente] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Pessoa_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[Compra]
    ([IdCliente]);
GO

-- Creating foreign key on [ComprasNrCompras] in table 'DetalheCompra'
ALTER TABLE [dbo].[DetalheCompra]
ADD CONSTRAINT [FK_DetalheCompraCompra]
    FOREIGN KEY ([ComprasNrCompras])
    REFERENCES [dbo].[Compra]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FilhoIdPessoa] in table 'Inscricao'
ALTER TABLE [dbo].[Inscricao]
ADD CONSTRAINT [FK_FilhoInscricao]
    FOREIGN KEY ([FilhoIdPessoa])
    REFERENCES [dbo].[Pessoa_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEscola] in table 'Participacao'
ALTER TABLE [dbo].[Participacao]
ADD CONSTRAINT [FK_EscolaParticipacao]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[Escola]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'Participacao'
ALTER TABLE [dbo].[Participacao]
ADD CONSTRAINT [FK_EventoParticipacao]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[Evento]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoParticipacao'
CREATE INDEX [IX_FK_EventoParticipacao]
ON [dbo].[Participacao]
    ([NrEvento]);
GO

-- Creating foreign key on [IdAnimador] in table 'Colaboracao'
ALTER TABLE [dbo].[Colaboracao]
ADD CONSTRAINT [FK_AnimadorColaboracao]
    FOREIGN KEY ([IdAnimador])
    REFERENCES [dbo].[Pessoa_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'Colaboracao'
ALTER TABLE [dbo].[Colaboracao]
ADD CONSTRAINT [FK_EventoColaboracao]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[Evento]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoColaboracao'
CREATE INDEX [IX_FK_EventoColaboracao]
ON [dbo].[Colaboracao]
    ([NrEvento]);
GO

-- Creating foreign key on [EventoNrEvento] in table 'Inscricao'
ALTER TABLE [dbo].[Inscricao]
ADD CONSTRAINT [FK_EventoInscricao]
    FOREIGN KEY ([EventoNrEvento])
    REFERENCES [dbo].[Evento]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoInscricao'
CREATE INDEX [IX_FK_EventoInscricao]
ON [dbo].[Inscricao]
    ([EventoNrEvento]);
GO

-- Creating foreign key on [ProdutoCodProduto] in table 'DetalheCompra'
ALTER TABLE [dbo].[DetalheCompra]
ADD CONSTRAINT [FK_ProdutoDetalheCompra]
    FOREIGN KEY ([ProdutoCodProduto])
    REFERENCES [dbo].[Produto]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoDetalheCompra'
CREATE INDEX [IX_FK_ProdutoDetalheCompra]
ON [dbo].[DetalheCompra]
    ([ProdutoCodProduto]);
GO

-- Creating foreign key on [CodTipoProduto] in table 'Produto'
ALTER TABLE [dbo].[Produto]
ADD CONSTRAINT [FK_ProdutoTipoProduto]
    FOREIGN KEY ([CodTipoProduto])
    REFERENCES [dbo].[TipoProduto]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoTipoProduto'
CREATE INDEX [IX_FK_ProdutoTipoProduto]
ON [dbo].[Produto]
    ([CodTipoProduto]);
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoa_Filho'
ALTER TABLE [dbo].[Pessoa_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoa]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoa]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoa_Animador'
ALTER TABLE [dbo].[Pessoa_Animador]
ADD CONSTRAINT [FK_Animador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoa]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------