USE [master]
GO
/****** Object:  Database [ListasCompras]    Script Date: 24/3/2019 9:17:34 p. m. ******/
CREATE DATABASE [ListasCompras]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ListasCompras', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ListasCompras.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ListasCompras_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ListasCompras_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ListasCompras] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ListasCompras].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ListasCompras] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ListasCompras] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ListasCompras] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ListasCompras] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ListasCompras] SET ARITHABORT OFF 
GO
ALTER DATABASE [ListasCompras] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ListasCompras] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ListasCompras] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ListasCompras] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ListasCompras] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ListasCompras] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ListasCompras] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ListasCompras] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ListasCompras] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ListasCompras] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ListasCompras] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ListasCompras] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ListasCompras] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ListasCompras] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ListasCompras] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ListasCompras] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ListasCompras] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ListasCompras] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ListasCompras] SET  MULTI_USER 
GO
ALTER DATABASE [ListasCompras] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ListasCompras] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ListasCompras] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ListasCompras] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ListasCompras] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ListasCompras]
GO
/****** Object:  Table [dbo].[Lista]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista](
	[id_lista] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[fecha_alta] [datetime] NULL,
	[fecha_vencimiento] [datetime] NULL,
	[id_usuario_alta] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Lista] PRIMARY KEY CLUSTERED 
(
	[id_lista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lista_Estado]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_Estado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Estado_Lista] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lista_Participantes]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_Participantes](
	[id_lista] [int] NOT NULL,
	[id_usuario_participante] [int] NOT NULL,
	[fecha_alta] [datetime] NULL,
 CONSTRAINT [PK_Lista_Participantes] PRIMARY KEY CLUSTERED 
(
	[id_lista] ASC,
	[id_usuario_participante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[id_lugar] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
	[observaciones] [varchar](100) NULL,
 CONSTRAINT [PK_Lugar] PRIMARY KEY CLUSTERED 
(
	[id_lugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marca_Producto]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca_Producto](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Marca_Producto] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
	[observaciones] [varchar](200) NULL,
	[id_tipo] [int] NULL,
	[id_marca] [int] NULL,
	[codigo_barra] [varchar](100) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto_Oferta]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto_Oferta](
	[id_producto] [int] NOT NULL,
	[fecha_desde] [datetime] NOT NULL,
	[fecha_hasta] [datetime] NULL,
	[precio] [decimal](10, 2) NULL,
	[id_lugar] [int] NULL,
 CONSTRAINT [PK_Producto_Oferta] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[fecha_desde] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto_X_Lugar]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto_X_Lugar](
	[id_producto] [int] NOT NULL,
	[id_lugar] [int] NOT NULL,
	[precio] [decimal](10, 2) NULL,
	[fecha_alta] [datetime] NULL,
	[fecha_ultima_modif] [datetime] NULL,
 CONSTRAINT [PK_Producto_X_Lugar] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[id_lugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Producto]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Producto](
	[id_tipo_producto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Tipo_Producto] PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](100) NULL,
	[password] [varchar](150) NULL,
	[telefono] [varchar](30) NULL,
	[password_recovery] [varchar](150) NULL,
	[fecha_alta] [datetime] NULL,
	[fecha_recovery] [datetime] NULL,
	[id_estado] [int] NULL,
	[calle] [varchar](100) NULL,
	[calle_nro] [varchar](10) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario_Estado]    Script Date: 24/3/2019 9:17:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Estado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Usuario_Estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Lista]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Lista_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Lista_Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Lista] CHECK CONSTRAINT [FK_Lista_Lista_Estado]
GO
ALTER TABLE [dbo].[Lista]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Usuario] FOREIGN KEY([id_usuario_alta])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Lista] CHECK CONSTRAINT [FK_Lista_Usuario]
GO
ALTER TABLE [dbo].[Lista_Participantes]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Participantes_Lista] FOREIGN KEY([id_lista])
REFERENCES [dbo].[Lista] ([id_lista])
GO
ALTER TABLE [dbo].[Lista_Participantes] CHECK CONSTRAINT [FK_Lista_Participantes_Lista]
GO
ALTER TABLE [dbo].[Lista_Participantes]  WITH CHECK ADD  CONSTRAINT [FK_Lista_Participantes_Usuario] FOREIGN KEY([id_usuario_participante])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Lista_Participantes] CHECK CONSTRAINT [FK_Lista_Participantes_Usuario]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marca_Producto] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marca_Producto] ([id_marca])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Marca_Producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Tipo_Producto] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[Tipo_Producto] ([id_tipo_producto])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Tipo_Producto]
GO
ALTER TABLE [dbo].[Producto_Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Oferta_Lugar] FOREIGN KEY([id_lugar])
REFERENCES [dbo].[Lugar] ([id_lugar])
GO
ALTER TABLE [dbo].[Producto_Oferta] CHECK CONSTRAINT [FK_Producto_Oferta_Lugar]
GO
ALTER TABLE [dbo].[Producto_Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Oferta_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Producto_Oferta] CHECK CONSTRAINT [FK_Producto_Oferta_Producto]
GO
ALTER TABLE [dbo].[Producto_X_Lugar]  WITH CHECK ADD  CONSTRAINT [FK_Producto_X_Lugar_Lugar] FOREIGN KEY([id_lugar])
REFERENCES [dbo].[Lugar] ([id_lugar])
GO
ALTER TABLE [dbo].[Producto_X_Lugar] CHECK CONSTRAINT [FK_Producto_X_Lugar_Lugar]
GO
ALTER TABLE [dbo].[Producto_X_Lugar]  WITH CHECK ADD  CONSTRAINT [FK_Producto_X_Lugar_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Producto_X_Lugar] CHECK CONSTRAINT [FK_Producto_X_Lugar_Producto]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Usuario_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Usuario_Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Usuario_Estado]
GO
USE [master]
GO
ALTER DATABASE [ListasCompras] SET  READ_WRITE 
GO
