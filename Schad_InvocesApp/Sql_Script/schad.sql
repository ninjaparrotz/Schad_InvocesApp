USE [master]
GO
/****** Object:  Database [schad_Invoces]    Script Date: 3/8/2023 1:37:56 PM ******/
CREATE DATABASE [schad_Invoces]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'schad_Invoces', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\schad_Invoces.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'schad_Invoces_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\schad_Invoces_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [schad_Invoces] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [schad_Invoces].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [schad_Invoces] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [schad_Invoces] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [schad_Invoces] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [schad_Invoces] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [schad_Invoces] SET ARITHABORT OFF 
GO
ALTER DATABASE [schad_Invoces] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [schad_Invoces] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [schad_Invoces] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [schad_Invoces] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [schad_Invoces] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [schad_Invoces] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [schad_Invoces] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [schad_Invoces] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [schad_Invoces] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [schad_Invoces] SET  DISABLE_BROKER 
GO
ALTER DATABASE [schad_Invoces] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [schad_Invoces] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [schad_Invoces] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [schad_Invoces] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [schad_Invoces] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [schad_Invoces] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [schad_Invoces] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [schad_Invoces] SET RECOVERY FULL 
GO
ALTER DATABASE [schad_Invoces] SET  MULTI_USER 
GO
ALTER DATABASE [schad_Invoces] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [schad_Invoces] SET DB_CHAINING OFF 
GO
ALTER DATABASE [schad_Invoces] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [schad_Invoces] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [schad_Invoces] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [schad_Invoces] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'schad_Invoces', N'ON'
GO
ALTER DATABASE [schad_Invoces] SET QUERY_STORE = ON
GO
ALTER DATABASE [schad_Invoces] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [schad_Invoces]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 3/8/2023 1:37:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustName] [nvarchar](70) NOT NULL,
	[Adress] [nvarchar](120) NOT NULL,
	[Status] [bit] NOT NULL,
	[CustomerTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerTypes]    Script Date: 3/8/2023 1:37:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](70) NOT NULL,
 CONSTRAINT [PK_CustomerType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 3/8/2023 1:37:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[TotalItbis] [money] NOT NULL,
	[SubTotal] [money] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 3/8/2023 1:37:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Qty] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[TotalItbis] [money] NOT NULL,
	[SubTotal] [money] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_CustomerType]  DEFAULT ((1)) FOR [CustomerTypeId]
GO
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_TotalItbis]  DEFAULT ((0)) FOR [TotalItbis]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD  CONSTRAINT [DF_InvoiceDetail_TotalItbis1]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD  CONSTRAINT [DF_InvoiceDetail_TotalItbis]  DEFAULT ((0)) FOR [TotalItbis]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_CustomerTypes] FOREIGN KEY([CustomerTypeId])
REFERENCES [dbo].[CustomerTypes] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_CustomerTypes]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customers]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Invoice] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice]
GO
USE [master]
GO
ALTER DATABASE [schad_Invoces] SET  READ_WRITE 
GO
