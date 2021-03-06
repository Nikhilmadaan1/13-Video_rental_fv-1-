USE [master]
GO
/****** Object:  Database [VideoRentalStore]    Script Date: 10/26/2020 7:56:17 PM ******/
CREATE DATABASE [VideoRentalStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRentalStore_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRentalStore_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalStore.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRentalStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRentalStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRentalStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRentalStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRentalStore] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRentalStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRentalStore] SET QUERY_STORE = OFF
GO
USE [VideoRentalStore]
GO
/****** Object:  Table [dbo].[BookingTable]    Script Date: 10/26/2020 7:56:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingTable](
	[Rent_PK] [int] IDENTITY(1,1) NOT NULL,
	[Movie_FK] [varchar](50) NULL,
	[Member_FK] [varchar](50) NULL,
	[IssueDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_BookingTable] PRIMARY KEY CLUSTERED 
(
	[Rent_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberTable]    Script Date: 10/26/2020 7:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_MemberTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieTable]    Script Date: 10/26/2020 7:56:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieTable](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Copies] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_MovieTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookingTable] ON 

INSERT [dbo].[BookingTable] ([Rent_PK], [Movie_FK], [Member_FK], [IssueDate], [ReturnDate]) VALUES (1, N'1', N'1', N'9/9/2020', N'9/9/2020')
SET IDENTITY_INSERT [dbo].[BookingTable] OFF
SET IDENTITY_INSERT [dbo].[MemberTable] ON 

INSERT [dbo].[MemberTable] ([id], [Name], [Address], [Contact], [Email]) VALUES (1, N'chirag', N'System.Windows.Forms.TextBox, Text: batala', N'789456', N'as@gmail.com')
SET IDENTITY_INSERT [dbo].[MemberTable] OFF
SET IDENTITY_INSERT [dbo].[MovieTable] ON 

INSERT [dbo].[MovieTable] ([id], [Title], [Ratting], [Year], [Cost], [Copies], [Genre]) VALUES (1, N'jolly llb', N'4.5', N'2018', N'5', N'5', N'INSPIRTIONAL')
SET IDENTITY_INSERT [dbo].[MovieTable] OFF
USE [master]
GO
ALTER DATABASE [VideoRentalStore] SET  READ_WRITE 
GO
