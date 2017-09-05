/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2016
    Target Database Engine Edition : Microsoft SQL Server Express Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [K_Booking]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 05/09/2017 21:03:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[DoB] [varchar](50) NULL,
	[DKAddress] [nvarchar](255) NULL,
	[DKPostalCode] [char](4) NULL,
	[DKCity] [nvarchar](255) NULL,
	[Phone] [varchar](50) NULL,
	[Phone2] [varchar](50) NULL,
	[Email] [nvarchar](255) NULL,
	[ChronicIllness] [bit] NULL,
	[ChronicIllnessDescription] [nvarchar](255) NULL,
	[DKContactName] [nvarchar](255) NULL,
	[DKContactAddress] [nvarchar](255) NULL,
	[DKContactPhone] [varchar](50) NULL,
	[NewsLetter] [bit] NULL,
	[Gender] [int] NULL,
	[Status] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


