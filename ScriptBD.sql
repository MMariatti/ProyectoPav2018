USE [ScheDulJ]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/23/2018 8:31:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
	[apellido] [varchar](25) NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [clientes_pk] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEventos]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEventos](
	[idEvento] [int] NOT NULL,
	[idItem] [int] NOT NULL,
	[costoAlquiler] [int] NOT NULL,
 CONSTRAINT [pk_DetalleEventos] PRIMARY KEY CLUSTERED 
(
	[idEvento] ASC,
	[idItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFacturas]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFacturas](
	[idDetalleFactura] [int] NOT NULL,
	[idFactura] [int] NOT NULL,
	[idEvento] [int] NOT NULL,
	[idPresupuesto] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idItem] [int] NULL,
	[costoItem] [int] NULL,
 CONSTRAINT [detalleF_pk] PRIMARY KEY CLUSTERED 
(
	[idDetalleFactura] ASC,
	[idFactura] ASC,
	[idEvento] ASC,
	[idPresupuesto] ASC,
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePresupuestos]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePresupuestos](
	[idPresupuesto] [int] NOT NULL,
	[idEvento] [int] NOT NULL,
	[idDetallePresupuesto] [int] NOT NULL,
	[idItem] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [dp_pk] PRIMARY KEY CLUSTERED 
(
	[idPresupuesto] ASC,
	[idEvento] ASC,
	[idDetallePresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[idEvento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[idTipoEvento] [int] NULL,
	[fecha] [datetime] NULL,
	[horario] [time](7) NULL,
	[direccion] [varchar](50) NULL,
	[idCliente] [int] NULL,
	[horarioFin] [time](7) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [eventos_pk] PRIMARY KEY CLUSTERED 
(
	[idEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idEvento] [int] NOT NULL,
	[idPresupuesto] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[hora] [time](7) NULL,
 CONSTRAINT [facturas_pk] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC,
	[idEvento] ASC,
	[idPresupuesto] ASC,
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[idItem] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
	[descripcion] [varchar](50) NULL,
	[idTipoItem] [int] NULL,
	[costoAlquiler] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [items_pk] PRIMARY KEY CLUSTERED 
(
	[idItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presupuestos]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presupuestos](
	[idPresupuesto] [int] IDENTITY(1,1) NOT NULL,
	[idEvento] [int] NOT NULL,
	[cantidadHoras] [int] NULL,
 CONSTRAINT [presupuestos_pk] PRIMARY KEY CLUSTERED 
(
	[idPresupuesto] ASC,
	[idEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposEventos]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposEventos](
	[idTipoEvento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [tiposEventos_pk] PRIMARY KEY CLUSTERED 
(
	[idTipoEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposItems]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposItems](
	[idTipoItem] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
	[descricpcion] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [tiposItems_pk] PRIMARY KEY CLUSTERED 
(
	[idTipoItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/23/2018 8:31:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](25) NULL,
	[contra] [varchar](16) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [usuarios_pk] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleFacturas]  WITH CHECK ADD  CONSTRAINT [detalleF_Factura_fk] FOREIGN KEY([idFactura], [idEvento], [idPresupuesto], [idCliente])
REFERENCES [dbo].[Facturas] ([idFactura], [idEvento], [idPresupuesto], [idCliente])
GO
ALTER TABLE [dbo].[DetalleFacturas] CHECK CONSTRAINT [detalleF_Factura_fk]
GO
ALTER TABLE [dbo].[DetalleFacturas]  WITH CHECK ADD  CONSTRAINT [detalleF_fk] FOREIGN KEY([idItem])
REFERENCES [dbo].[Items] ([idItem])
GO
ALTER TABLE [dbo].[DetalleFacturas] CHECK CONSTRAINT [detalleF_fk]
GO
ALTER TABLE [dbo].[DetallePresupuestos]  WITH CHECK ADD  CONSTRAINT [dp_item_fk] FOREIGN KEY([idItem])
REFERENCES [dbo].[Items] ([idItem])
GO
ALTER TABLE [dbo].[DetallePresupuestos] CHECK CONSTRAINT [dp_item_fk]
GO
ALTER TABLE [dbo].[DetallePresupuestos]  WITH CHECK ADD  CONSTRAINT [dp_presupuesto_fk] FOREIGN KEY([idPresupuesto], [idEvento])
REFERENCES [dbo].[Presupuestos] ([idPresupuesto], [idEvento])
GO
ALTER TABLE [dbo].[DetallePresupuestos] CHECK CONSTRAINT [dp_presupuesto_fk]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [eventos_fk] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [eventos_fk]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [tipoEventos_fk] FOREIGN KEY([idTipoEvento])
REFERENCES [dbo].[TiposEventos] ([idTipoEvento])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [tipoEventos_fk]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [facturas_clientes_fk] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [facturas_clientes_fk]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [facturas_presupuestos_fk] FOREIGN KEY([idPresupuesto], [idEvento])
REFERENCES [dbo].[Presupuestos] ([idPresupuesto], [idEvento])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [facturas_presupuestos_fk]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [items_tipos_fk] FOREIGN KEY([idTipoItem])
REFERENCES [dbo].[TiposItems] ([idTipoItem])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [items_tipos_fk]
GO
ALTER TABLE [dbo].[Presupuestos]  WITH CHECK ADD  CONSTRAINT [presupuestos_eventos_fk] FOREIGN KEY([idEvento])
REFERENCES [dbo].[Eventos] ([idEvento])
GO
ALTER TABLE [dbo].[Presupuestos] CHECK CONSTRAINT [presupuestos_eventos_fk]
GO
