USE [TiendaTP]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[IdDetalleVenta] [int] NOT NULL,
	[IdVenta] [int] NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [decimal](10, 2) NULL,
	[Subtotal] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Categoria] [nvarchar](50) NULL,
	[Precio] [decimal](18, 2) NULL,
	[StockCantidad] [int] NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Color] [nvarchar](20) NULL,
	[Marca] [nvarchar](20) NULL,
	[idProveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[nombre] [nvarchar](20) NOT NULL,
	[apellido] [nvarchar](20) NOT NULL,
	[DNI] [bigint] NOT NULL,
	[userUsuario] [nvarchar](20) NOT NULL,
	[rol] [nvarchar](20) NOT NULL,
	[contrasenia] [nvarchar](30) NULL,
	[id_usuario] [int] NOT NULL,
	[Estado] [varchar](20) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[NroVenta] [int] IDENTITY(1,1) NOT NULL,
	[FechaVenta] [datetime] NULL,
	[IDCliente] [int] NULL,
	[IDUsuario] [int] NULL,
	[TotalVenta] [decimal](18, 0) NULL,
	[MetodoPago] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[NroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clientes] ([id], [nombre], [apellido], [dni]) VALUES (1, N'Paula', N'Sanchez', 85478965)
INSERT [dbo].[Clientes] ([id], [nombre], [apellido], [dni]) VALUES (2, N'Carlos', N'Perez', 54789654)
INSERT [dbo].[Clientes] ([id], [nombre], [apellido], [dni]) VALUES (4, N'Lorena', N'Lopez', 22114563)
INSERT [dbo].[DetalleVenta] ([IdDetalleVenta], [IdVenta], [IdProducto], [Cantidad], [PrecioUnitario], [Subtotal]) VALUES (1, 1, 1, 2, CAST(100.00 AS Decimal(10, 2)), CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([IdDetalleVenta], [IdVenta], [IdProducto], [Cantidad], [PrecioUnitario], [Subtotal]) VALUES (2, 1, 2, 1, CAST(200.00 AS Decimal(10, 2)), CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([IdDetalleVenta], [IdVenta], [IdProducto], [Cantidad], [PrecioUnitario], [Subtotal]) VALUES (3, 2, 1, 3, CAST(100.00 AS Decimal(10, 2)), CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([IdDetalleVenta], [IdVenta], [IdProducto], [Cantidad], [PrecioUnitario], [Subtotal]) VALUES (4, 2, 2, 1, CAST(200.00 AS Decimal(10, 2)), CAST(5000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (1, N'Labial ', N'Maquillaje', CAST(9000.00 AS Decimal(18, 2)), 10, N'Power Stay', N'Nude', N'AVON', 1)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (2, N'Labial ', N'Maquillaje', CAST(10000.00 AS Decimal(18, 2)), 5, N'Faces', N'Red', N'NATURA', 2)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (3, N'Labial', N'Maquillaje', CAST(5000.00 AS Decimal(18, 2)), 10, N'Hidratante', N'Cherry', N'NIVEA', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (10, N'Base de maquillaje', N'Maquillaje', CAST(3000.00 AS Decimal(18, 2)), 10, N'Liquida', N'Tono Oscuro', N'AVON', 1)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (11, N'Delineador', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 5, N'Opaco', N'Negro', N'NATURA', 2)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (12, N'Delineador', N'Maquillaje', CAST(3000.00 AS Decimal(18, 2)), 5, N'Glitter', N'Negro', N'NATURA', 2)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (13, N'Delineador', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 5, N'Opaco', N'Azul', N'NATURA', 2)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (14, N'Delineador', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 5, N'Opaco', N'Azul', N'NATURA', 2)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (15, N'Tonico', N'Cuidado De Piel', CAST(9000.00 AS Decimal(18, 2)), 10, N'Hidratante', NULL, N'NEUTROGENA', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (16, N'rubor', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 7, N'rubor en polvo', N'rojo', N'Maybelline', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (17, N'crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 20, N'crema humectante ', N'-', N'exel', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (18, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (19, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (20, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (21, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (22, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (23, N'Labial', N'Maquillaje', CAST(10000.00 AS Decimal(18, 2)), 5, N'Faces', N'Red', N'NATURA', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (24, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (25, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (26, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (27, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (28, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (29, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (30, N'Crema', N'Cuidado Personal', CAST(8000.00 AS Decimal(18, 2)), 10, N'crema humectante', N'-', N'Avon', NULL)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca], [idProveedor]) VALUES (31, N'Crema', N'Cuidado Personal ', CAST(5000.00 AS Decimal(18, 2)), 50, N'crema humectante', N'-', N'Natura', NULL)
SET IDENTITY_INSERT [dbo].[Productos] OFF
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([idProveedor], [RazonSocial], [email]) VALUES (1, N'589', N'avon@gmail.com')
INSERT [dbo].[Proveedores] ([idProveedor], [RazonSocial], [email]) VALUES (2, N'897', N'natura@gmail.com')
INSERT [dbo].[Proveedores] ([idProveedor], [RazonSocial], [email]) VALUES (4, N'258', N'maybelline@gmail.com')
INSERT [dbo].[Proveedores] ([idProveedor], [RazonSocial], [email]) VALUES (5, N'78', N'exel@gmail.com')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado]) VALUES (N'Ana', N'Ruescas', 11222333, N'anaUser', N'administrador', N'ana123', 1, N'Activo')
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado]) VALUES (N'Micaela', N'Barroso', 22333444, N'micaUser', N'gerente', N'micaela123', 2, N'Activo')
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado]) VALUES (N'Ciro', N'Coria', 33444555, N'ciroUser', N'atencion_al_cliente', N'ciro123', 3, N'Activo')
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado]) VALUES (N'Eric', N'Perez', 44555666, N'ericUser', N'cajero', N'eric123', 4, N'Activo')
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado]) VALUES (N'Sergio', N'Lopez', 66777888, N'sergioUser', N'repositor', N'sergio123', 5, N'Inactivo')
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado]) VALUES (N'Lorena', N'Caceres', 88999000, N'lorenaUser', N'cajero', N'lorena123', 7, N'Activo')
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([NroVenta], [FechaVenta], [IDCliente], [IDUsuario], [TotalVenta], [MetodoPago]) VALUES (1, CAST(N'2024-06-01 00:00:00.000' AS DateTime), 1, 3, CAST(5000 AS Decimal(18, 0)), N'Efectivo')
INSERT [dbo].[Venta] ([NroVenta], [FechaVenta], [IDCliente], [IDUsuario], [TotalVenta], [MetodoPago]) VALUES (2, CAST(N'2024-06-02 00:00:00.000' AS DateTime), 2, 3, CAST(5000 AS Decimal(18, 0)), N'Tarjeta')
SET IDENTITY_INSERT [dbo].[Venta] OFF
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([NroVenta])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedores]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Clientes] ([id])
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerVentaConDetalle]    Script Date: 14/6/2024 20:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerVentaConDetalle]
AS
BEGIN
    SELECT 
        v.NroVenta,
        v.FechaVenta,
        c.Nombre AS NombreCliente,
        c.Apellido AS ApellidoCliente,
        u.Nombre AS NombreVendedor,
        u.Apellido AS ApellidoVendedor,
        p.Nombre AS NombreProducto,
        dv.Cantidad,
        dv.PrecioUnitario,
        dv.Subtotal,
        v.MetodoPago,
        v.TotalVenta
    FROM 
        Venta v
    INNER JOIN 
        Clientes c ON v.IdCliente = c.id
    INNER JOIN 
        DetalleVenta dv ON v.NroVenta = dv.IdDetalleVenta
    INNER JOIN 
        Productos p ON dv.IdProducto = p.IdProducto
    INNER JOIN
        Usuarios u ON v.IdUsuario = u.id_usuario;
END;

GO
