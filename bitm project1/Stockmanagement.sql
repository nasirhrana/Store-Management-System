USE [master]
GO
/****** Object:  Database [StockManagement]    Script Date: 18/01/04 10:57:49 AM ******/
CREATE DATABASE [StockManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER1\MSSQL\DATA\StockManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StockManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER1\MSSQL\DATA\StockManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StockManagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [StockManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StockManagement', N'ON'
GO
USE [StockManagement]
GO
/****** Object:  Table [dbo].[Sell]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sell](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Quantiry] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Sell] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Catagory]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Catagory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Company]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Item]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CatagoryNameId] [int] NOT NULL,
	[CompanyNameId] [int] NOT NULL,
	[ReorderLevel] [int] NOT NULL,
 CONSTRAINT [PK_t_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Stock]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_Stock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_t_Stock] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ItemWithCompany]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[ItemWithCompany]
as

select t_Item.Name ItemName,t_Item.Id, t_Item.ReorderLevel ReorderLevel,t_Company.Name CompanyName from t_Item
left OUTER JOIN t_Company
on t_Item.CompanyNameId=t_Company.Id




GO
/****** Object:  View [dbo].[SearchAndView]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create View [dbo].[SearchAndView]
as

select t_Item.Name ItemName,t_Company.Name CompanyName,t_Catagory.Name CatagoryName,
 t_Item.ReorderLevel ReorderLevel,t_Stock.Quantity from t_Item
inner  JOIN t_Company
on t_Item.CompanyNameId=t_Company.Id


inner join t_Catagory 
on t_Item.CatagoryNameId=t_Catagory.Id

inner join t_Stock
on t_Item.Id=t_Stock.ItemId

GO
/****** Object:  View [dbo].[StockWithItem]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[StockWithItem]
as

select t_Stock.Quantity,t_Item.Name,t_Stock.ItemId, t_Item.Id from t_Stock inner join t_Item on t_Stock.ItemId=t_Item.Id


GO
/****** Object:  View [dbo].[ViewWithCatagory]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ViewWithCatagory]
as
select t_Item.Name ItemName,t_Company.Name CompanyName,t_Catagory.Name CatagoryName,
 t_Item.ReorderLevel ReorderLevel,t_Stock.Quantity from t_Item
right  join t_Catagory
on t_Item.CompanyNameId=t_Catagory.Id


left join t_Company 
on t_Item.CatagoryNameId=t_Company.Id

left join t_Stock
on t_Item.Id=t_Stock.ItemId
GO
/****** Object:  View [dbo].[ViewWithCompany]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ViewWithCompany]
as

select t_Item.Name ItemName,t_Company.Name CompanyName,t_Catagory.Name CatagoryName,
 t_Item.ReorderLevel ReorderLevel,t_Stock.Quantity from t_Item
right  JOIN t_Company
on t_Item.CompanyNameId=t_Company.Id


left join t_Catagory 
on t_Item.CatagoryNameId=t_Catagory.Id

left join t_Stock
on t_Item.Id=t_Stock.ItemId

GO
/****** Object:  View [dbo].[ViewWithCompanyAndCatagory]    Script Date: 18/01/04 10:57:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ViewWithCompanyAndCatagory]
as
select t_Item.Name ItemName,t_Company.Name CompanyName,t_Catagory.Name CatagoryName,
 t_Item.ReorderLevel ReorderLevel,t_Stock.Quantity from t_Item
right  JOIN t_Company
on t_Item.CompanyNameId=t_Company.Id


right join t_Catagory 
on t_Item.CatagoryNameId=t_Catagory.Id

left join t_Stock
on t_Item.Id=t_Stock.ItemId

GO
SET IDENTITY_INSERT [dbo].[Sell] ON 

INSERT [dbo].[Sell] ([Id], [ItemName], [Quantiry], [Date]) VALUES (1, N'plate', N'110', CAST(0xB83D0B00 AS Date))
INSERT [dbo].[Sell] ([Id], [ItemName], [Quantiry], [Date]) VALUES (2, N'plate', N'10', CAST(0xB83D0B00 AS Date))
INSERT [dbo].[Sell] ([Id], [ItemName], [Quantiry], [Date]) VALUES (3, N'plate', N'10', CAST(0xB83D0B00 AS Date))
INSERT [dbo].[Sell] ([Id], [ItemName], [Quantiry], [Date]) VALUES (4, N'plate', N'0', CAST(0xB83D0B00 AS Date))
INSERT [dbo].[Sell] ([Id], [ItemName], [Quantiry], [Date]) VALUES (5, N'plate', N'0', CAST(0xB83D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Sell] OFF
SET IDENTITY_INSERT [dbo].[t_Catagory] ON 

INSERT [dbo].[t_Catagory] ([Id], [Name]) VALUES (74, N'mudir mal')
INSERT [dbo].[t_Catagory] ([Id], [Name]) VALUES (75, N'ciramics')
SET IDENTITY_INSERT [dbo].[t_Catagory] OFF
SET IDENTITY_INSERT [dbo].[t_Company] ON 

INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (1, N'j')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (2, N'h')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (1002, N'daraz')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (1003, N'i')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (1004, N'yrtg')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (2004, N'tumi')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (2005, N'rfl')
INSERT [dbo].[t_Company] ([Id], [Name]) VALUES (2006, N'rashid')
SET IDENTITY_INSERT [dbo].[t_Company] OFF
SET IDENTITY_INSERT [dbo].[t_Item] ON 

INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (1, N'60', 43, 1002, 50)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (2, N'mug', 43, 1002, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (3, N'fan', 73, 2004, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (4, N'fan', 73, 1002, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (5, N'fan', 73, 2, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (6, N'nd', 71, 1003, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (7, N'nd', 70, 1003, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (8, N'nd', 71, 1002, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (9, N'chal', 74, 2006, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (10, N'chal', 74, 2005, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (11, N'mug', 75, 2005, 0)
INSERT [dbo].[t_Item] ([Id], [Name], [CatagoryNameId], [CompanyNameId], [ReorderLevel]) VALUES (12, N'plate', 75, 2006, 0)
SET IDENTITY_INSERT [dbo].[t_Item] OFF
SET IDENTITY_INSERT [dbo].[t_Stock] ON 

INSERT [dbo].[t_Stock] ([Id], [ItemId], [Quantity]) VALUES (1, 12, 0)
SET IDENTITY_INSERT [dbo].[t_Stock] OFF
ALTER TABLE [dbo].[t_Stock]  WITH CHECK ADD  CONSTRAINT [FK_t_Stock_t_Stock] FOREIGN KEY([Id])
REFERENCES [dbo].[t_Stock] ([Id])
GO
ALTER TABLE [dbo].[t_Stock] CHECK CONSTRAINT [FK_t_Stock_t_Stock]
GO
USE [master]
GO
ALTER DATABASE [StockManagement] SET  READ_WRITE 
GO
