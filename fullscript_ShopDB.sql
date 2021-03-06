USE [master]
GO
/****** Object:  Database [ShopDB]    Script Date: 22-Nov-21 1:56:18 AM ******/
CREATE DATABASE [ShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopDB', FILENAME = N'F:\DBMS_Nhom3\ShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopDB_log', FILENAME = N'F:\DBMS_Nhom3\ShopDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ShopDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [ShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShopDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShopDB', N'ON'
GO
ALTER DATABASE [ShopDB] SET QUERY_STORE = OFF
GO
USE [ShopDB]
GO
/****** Object:  User [staff]    Script Date: 22-Nov-21 1:56:18 AM ******/
CREATE USER [staff] FOR LOGIN [staff] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [admin]    Script Date: 22-Nov-21 1:56:18 AM ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [staff]
GO
ALTER ROLE [db_datareader] ADD MEMBER [admin]
GO
/****** Object:  UserDefinedFunction [dbo].[IDmaxCompany]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[IDmaxCompany]()
RETURNS int 
as
begin
	declare @maxid int
	select @maxid = max(ID_company)
	from CongTySX
	if(@maxid IS NULL)
		set @maxid = -1;
	return @maxid
end
GO
/****** Object:  UserDefinedFunction [dbo].[IDmaxProduct]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[IDmaxProduct]()
RETURNS int 
as
begin
	declare @maxid int
	select @maxid = max(ID_product)
	from Product
	if(@maxid IS NULL)
		set @maxid = -1;
	return @maxid
end
GO
/****** Object:  UserDefinedFunction [dbo].[IDmaxTrans]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[IDmaxTrans]()
RETURNS int 
as
begin
	declare @maxid int
	select @maxid = max(ID_transaction)
	from Transactions
	if(@maxid IS NULL)
		set @maxid = -1;
	return @maxid
end
GO
/****** Object:  Table [dbo].[Product]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Name_product] [varchar](50) NOT NULL,
	[ID_product] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[ID_company] [int] NOT NULL,
	[warranty_month] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_product]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_product]
as select * from Product
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[Name_Staff] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Posision] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_staff]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_staff] as
select * from staff
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Name] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[ID_customer] [int] NOT NULL,
	[VIP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[ID_transaction] [int] NOT NULL,
	[Total_price] [int] NOT NULL,
	[Dates] [date] NOT NULL,
	[ID_customer] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_transaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction_Details]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction_Details](
	[quantity] [int] NOT NULL,
	[ID_transaction] [int] NOT NULL,
	[ID_product] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_transaction] ASC,
	[ID_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewTrans_details]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[viewTrans_details]
as
select Transactions.ID_transaction,Customer_Name,PhoneNumber,VIP,Product.ID_product,Name_product,Price,quantity,warranty_month,Dates,username as seller
from Customer, Product, Transaction_Details, Transactions 
where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_product = Product.ID_product
GO
/****** Object:  View [dbo].[month_Revenue]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[month_Revenue]
as
select Staff.username,Name_Staff,Posision,SUM(Total_price) as Total
from Transactions,Staff
where Transactions.username = Staff.username and MONTH(Dates) = MONTH(GETDATE())
group by Staff.username, Name_Staff,Posision
GO
/****** Object:  View [dbo].[view_warranty]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_warranty]
as
select PhoneNumber,Customer.Customer_Name,Product.ID_product,Product.Name_product
from Customer,Transactions,Transaction_Details,Product
where Customer.ID_customer = Transactions.ID_customer and Transaction_Details.ID_transaction = Transactions.ID_transaction 
and Transaction_Details.ID_product = Product.ID_product and DATEDIFF(MONTH,Transactions.Dates,GETDATE()) < Product.warranty_month
GO
/****** Object:  Table [dbo].[CongTySX]    Script Date: 22-Nov-21 1:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTySX](
	[ID_company] [int] NOT NULL,
	[Company_name] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ID_company])
REFERENCES [dbo].[CongTySX] ([ID_company])
GO
ALTER TABLE [dbo].[Transaction_Details]  WITH CHECK ADD FOREIGN KEY([ID_product])
REFERENCES [dbo].[Product] ([ID_product])
GO
ALTER TABLE [dbo].[Transaction_Details]  WITH CHECK ADD FOREIGN KEY([ID_transaction])
REFERENCES [dbo].[Transactions] ([ID_transaction])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([ID_customer])
REFERENCES [dbo].[Customer] ([ID_customer])
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[Staff] ([username])
GO
USE [master]
GO
ALTER DATABASE [ShopDB] SET  READ_WRITE 
GO
