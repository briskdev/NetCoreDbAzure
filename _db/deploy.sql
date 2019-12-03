USE [NetCoreDbAzure20191203021118_db]
GO

/****** Object: Table [dbo].[Tasks] Script Date: 03.12.2019 16:32:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tasks] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (200) NOT NULL
);


