USE [master]
GO
/****** Object:  Database [Libreria]    Script Date: 27/11/2021 13:31:58 ******/
CREATE DATABASE [Libreria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Libreria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Libreria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Libreria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Libreria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Libreria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Libreria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Libreria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Libreria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Libreria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Libreria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Libreria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Libreria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Libreria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Libreria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Libreria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Libreria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Libreria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Libreria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Libreria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Libreria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Libreria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Libreria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Libreria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Libreria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Libreria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Libreria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Libreria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Libreria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Libreria] SET RECOVERY FULL 
GO
ALTER DATABASE [Libreria] SET  MULTI_USER 
GO
ALTER DATABASE [Libreria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Libreria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Libreria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Libreria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Libreria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Libreria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Libreria', N'ON'
GO
ALTER DATABASE [Libreria] SET QUERY_STORE = OFF
GO
USE [Libreria]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 27/11/2021 13:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NULL,
	[autor] [varchar](50) NULL,
	[anio] [int] NULL,
	[stock] [int] NULL,
	[ventas] [int] NULL,
	[precio] [float] NULL,
	[genero] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Libros] ON 

INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (1, N'En el camino', N'Kerouac, Jack', 1960, 10, 4, 800, N'novela')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (2, N'Al sur de la frontera, al oeste del sol', N'Murakami, Haruki', 2010, 2, 7, 1500, N'novela')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (1002, N'White Noise', N'De Lillo, Don', 2015, 18, 2, 2000, N'novela')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (1003, N'Sumision', N'Houellebeq, Michel', 2019, 12, 3, 1500, N'novela')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (1004, N'Robespierre', N'McPhee, Peter', 2015, 4, 1, 2500, N'biografia')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (1005, N'El guardian entre el centeno', N'Salinger, J', 1950, 7, 3, 400, N'novela')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (2010, N'En busca del tiempo perdido', N'Proust, Marcel', 1922, 2, 0, 2000, N'novela')
INSERT [dbo].[Libros] ([Codigo], [titulo], [autor], [anio], [stock], [ventas], [precio], [genero]) VALUES (2011, N'La metamorfosis', N'Kafka, Franz', 1915, 5, 0, 800, N'novela')
SET IDENTITY_INSERT [dbo].[Libros] OFF
GO
USE [master]
GO
ALTER DATABASE [Libreria] SET  READ_WRITE 
GO
