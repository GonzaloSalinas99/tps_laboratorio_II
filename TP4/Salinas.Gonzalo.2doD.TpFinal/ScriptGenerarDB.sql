USE [master]
GO
/****** Object:  Database [TP4]    Script Date: 22/11/2021 17:53:04 ******/
CREATE DATABASE [TP4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4] SET AUTO_UPDATE_STATISTICS ON 
GO

GO
ALTER DATABASE [TP4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4] SET  MULTI_USER 
GO
ALTER DATABASE [TP4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4] SET QUERY_STORE = OFF
GO
USE [TP4]
GO
/****** Object:  Table [dbo].[Alumnoss]    Script Date: 22/11/2021 17:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnoss](
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[documento] [varchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[legajo] [varchar](50) NOT NULL,
	[cuatrimestreCursando] [int] NOT NULL,
	[fechaIngreso] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 22/11/2021 17:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[documento] [varchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[salario] [float] NOT NULL,
	[fechaIngreso] [date] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'Ana', N'Maria', N'1234123', 48, N'4', 1111111111, CAST(N'2019-11-11' AS Date))
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'Franco', N'Alvarez', N'42424242', 20, N'1111', 1, CAST(N'2021-07-10' AS Date))
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'ana', N'Perez', N'123456', 43, N'3', 12222, CAST(N'2018-11-11' AS Date))
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'aaa', N'aaa', N'123123', 12, N'1', 111, CAST(N'2011-11-11' AS Date))
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'asas', N'asas', N'123', 12, N'3', 22, CAST(N'2011-11-11' AS Date))
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'asd', N'asd', N'1231231', 123, N'4', 2312, CAST(N'2011-11-11' AS Date))
GO
INSERT [dbo].[Alumnoss] ([nombre], [apellido], [documento], [edad], [legajo], [cuatrimestreCursando], [fechaIngreso]) VALUES (N'asd', N'sd', N'2312312', 123, N'2', 33, CAST(N'2011-11-11' AS Date))
GO
INSERT [dbo].[Profesores] ([nombre], [apellido], [documento], [edad], [salario], [fechaIngreso]) VALUES (N'Lautaro', N'Galarza', N'40121234', 24, 98000, CAST(N'2021-03-11' AS Date))
GO
INSERT [dbo].[Profesores] ([nombre], [apellido], [documento], [edad], [salario], [fechaIngreso]) VALUES (N'Mauricio', N'Davila', N'33112233', 29, 300002, CAST(N'2010-01-01' AS Date))
GO
USE [master]
GO
ALTER DATABASE [TP4] SET  READ_WRITE 
GO
