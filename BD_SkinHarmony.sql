USE [master]
GO
/****** Object:  Database [TiendaTP]    Script Date: 12/6/2024 15:48:41 ******/
CREATE DATABASE [TiendaTP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TiendaTP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TiendaTP.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TiendaTP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TiendaTP_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TiendaTP] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TiendaTP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TiendaTP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TiendaTP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TiendaTP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TiendaTP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TiendaTP] SET ARITHABORT OFF 
GO
ALTER DATABASE [TiendaTP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TiendaTP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TiendaTP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TiendaTP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TiendaTP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TiendaTP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TiendaTP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TiendaTP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TiendaTP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TiendaTP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TiendaTP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TiendaTP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TiendaTP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TiendaTP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TiendaTP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TiendaTP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TiendaTP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TiendaTP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TiendaTP] SET  MULTI_USER 
GO
ALTER DATABASE [TiendaTP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TiendaTP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TiendaTP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TiendaTP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TiendaTP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TiendaTP]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/6/2024 15:48:41 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 12/6/2024 15:48:41 ******/
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
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/6/2024 15:48:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[nombre] [nvarchar](20) NOT NULL,
	[apellido] [nvarchar](20) NOT NULL,
	[DNI] [bigint] NOT NULL,
	[userUsuario] [nvarchar](20) NOT NULL,
	[rol] [nvarchar](20) NOT NULL,
	[contrasenia] [nvarchar](30) NULL,
	[id_usuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Clientes] ([id], [nombre], [apellido], [dni]) VALUES (1, N'Paula', N'Sanchez', 85478965)
INSERT [dbo].[Clientes] ([id], [nombre], [apellido], [dni]) VALUES (2, N'Carlos', N'Perez', 54789654)
INSERT [dbo].[Clientes] ([id], [nombre], [apellido], [dni]) VALUES (4, N'Lorena', N'Lopez', 22114563)
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (1, N'Labial ', N'Maquillaje', CAST(9000.00 AS Decimal(18, 2)), 10, N'Power Stay', N'Nude', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (2, N'Labial ', N'Maquillaje', CAST(10000.00 AS Decimal(18, 2)), 5, N'Faces', N'Red', N'NATURA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (3, N'Labial', N'Maquillaje', CAST(5000.00 AS Decimal(18, 2)), 10, N'Hidratante', N'Cherry', N'NIVEA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (4, N'Labial', N'Maquillaje', CAST(9000.00 AS Decimal(18, 2)), 10, N'Power Stay', N'Red', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (5, N'Labial', N'Maquillaje', CAST(90000.00 AS Decimal(18, 2)), 5, N'Power Stay', N'Wine', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (6, N'Labial ', N'Maquillaje', CAST(10000.00 AS Decimal(18, 2)), 5, N'Faces', N'Nude', N'NATURA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (7, N'Base de maquillaje', N'Maquillaje', CAST(5000.00 AS Decimal(18, 2)), 10, N'Compacta', N'Tono claro', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (8, N'Base de maquillaje', N'Maquillaje', CAST(3000.00 AS Decimal(18, 2)), 10, N'Liquida', N'Tono claro', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (9, N'Base de maquillaje', N'Maquillaje', CAST(5000.00 AS Decimal(18, 2)), 10, N'Compacta', N'Tono Oscuro', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (10, N'Base de maquillaje', N'Maquillaje', CAST(3000.00 AS Decimal(18, 2)), 10, N'Liquida', N'Tono Oscuro', N'AVON')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (11, N'Delineador', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 5, N'Opaco', N'Negro', N'NATURA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (12, N'Delineador', N'Maquillaje', CAST(3000.00 AS Decimal(18, 2)), 5, N'Glitter', N'Negro', N'NATURA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (13, N'Delineador', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 5, N'Opaco', N'Azul', N'NATURA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (14, N'Delineador', N'Maquillaje', CAST(2000.00 AS Decimal(18, 2)), 5, N'Opaco', N'Azul', N'NATURA')
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Categoria], [Precio], [StockCantidad], [Descripcion], [Color], [Marca]) VALUES (15, N'Tonico', N'Cuidado De Piel', CAST(9000.00 AS Decimal(18, 2)), 10, N'Hidratante', NULL, N'NEUTROGENA')
SET IDENTITY_INSERT [dbo].[Productos] OFF
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario]) VALUES (N'Ana', N'Ruescas', 11222333, N'anaUser', N'administrador', N'ana123', 1)
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario]) VALUES (N'Micaela', N'Barroso', 22333444, N'micaUser', N'gerente', N'micaela123', 2)
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario]) VALUES (N'Ciro', N'Coria', 33444555, N'ciroUser', N'atencion_al_cliente', N'ciro123', 3)
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario]) VALUES (N'Eric', N'Perez', 44555666, N'ericUser', N'cajero', N'eric123', 4)
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario]) VALUES (N'Sergio', N'Lopez', 66777888, N'sergioUser', N'repositor', N'sergio123', 5)
INSERT [dbo].[Usuarios] ([nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario]) VALUES (N'Lorena', N'Caceres', 88999000, N'lorenaUser', N'cajero', N'lorena123', 7)
USE [master]
GO
ALTER DATABASE [TiendaTP] SET  READ_WRITE 
GO
