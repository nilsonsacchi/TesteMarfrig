USE [TesteMarfrig]
GO

ALTER TABLE [dbo].[CompraGadoItem] DROP CONSTRAINT [FK_CompraGadoItem_CompraGado]
GO

ALTER TABLE [dbo].[CompraGadoItem] DROP CONSTRAINT [FK_CompraGadoItem_Animal]
GO

ALTER TABLE [dbo].[CompraGado] DROP CONSTRAINT [FK_CompraGado_Pecuarista]
GO

/****** Object:  Table [dbo].[Pecuarista]    Script Date: 17/12/2018 08:22:06 ******/
DROP TABLE [dbo].[Pecuarista]
GO

/****** Object:  Table [dbo].[CompraGadoItem]    Script Date: 17/12/2018 08:22:06 ******/
DROP TABLE [dbo].[CompraGadoItem]
GO

/****** Object:  Table [dbo].[CompraGado]    Script Date: 17/12/2018 08:22:06 ******/
DROP TABLE [dbo].[CompraGado]
GO

/****** Object:  Table [dbo].[Animal]    Script Date: 17/12/2018 08:22:06 ******/
DROP TABLE [dbo].[Animal]
GO

/****** Object:  Table [dbo].[Animal]    Script Date: 17/12/2018 08:22:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Animal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Preco] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK__Animal__3214EC07C3C4A7CF] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[CompraGado]    Script Date: 17/12/2018 08:22:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CompraGado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataEntrega] [datetime] NULL,
	[PecuaristaId] [int] NOT NULL,
	[Impresso] [int] NOT NULL CONSTRAINT [DF_CompraGado_Impresso]  DEFAULT ((0)),
 CONSTRAINT [PK__CompraGa__3214EC079A84131D] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[CompraGadoItem]    Script Date: 17/12/2018 08:22:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CompraGadoItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[CompraGadoId] [int] NOT NULL,
	[AnimalId] [int] NOT NULL,
 CONSTRAINT [PK__CompraGa__3214EC071003541C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Pecuarista]    Script Date: 17/12/2018 08:22:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Pecuarista](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Pecuarista] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[CompraGado]  WITH CHECK ADD  CONSTRAINT [FK_CompraGado_Pecuarista] FOREIGN KEY([PecuaristaId])
REFERENCES [dbo].[Pecuarista] ([Id])
GO

ALTER TABLE [dbo].[CompraGado] CHECK CONSTRAINT [FK_CompraGado_Pecuarista]
GO

ALTER TABLE [dbo].[CompraGadoItem]  WITH CHECK ADD  CONSTRAINT [FK_CompraGadoItem_Animal] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[Animal] ([Id])
GO

ALTER TABLE [dbo].[CompraGadoItem] CHECK CONSTRAINT [FK_CompraGadoItem_Animal]
GO

ALTER TABLE [dbo].[CompraGadoItem]  WITH CHECK ADD  CONSTRAINT [FK_CompraGadoItem_CompraGado] FOREIGN KEY([CompraGadoId])
REFERENCES [dbo].[CompraGado] ([Id])
GO

ALTER TABLE [dbo].[CompraGadoItem] CHECK CONSTRAINT [FK_CompraGadoItem_CompraGado]
GO


