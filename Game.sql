USE [master]
GO

GO
IF DB_ID ( N'Game' ) IS NOT NULL
DROP DATABASE Game;
GO
CREATE DATABASE Game;  
GO

USE [Game]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Item](
    [ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Weight] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Member](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Account] [varchar](10) NULL,
	[Password] [varchar](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Monster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[HP] [int] NULL,
	[ATK] [int] NULL,
	[Exp] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Treasure](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MonsterID] [int] NULL,
	[ItemID] [int] NULL
) ON [PRIMARY]
GO

Insert Into Item (Name,Weight) values ('¬õ¦âÃÄ¤ô',5)