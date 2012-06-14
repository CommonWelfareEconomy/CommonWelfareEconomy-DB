IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organisation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Organisation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Industry] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[Url] [nvarchar](255) NULL,
	[Location] [nvarchar](255) NULL,
	[ZipCode] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[WelfareBalanceFor2011] [bit] NULL,
	[WelfareBalanceFor2012] [bit] NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
 
/****** Object:  Table [dbo].[Newsletter]    Script Date: 05/16/2012 16:02:05 ******/
SET ANSI_NULLS ON
 
SET QUOTED_IDENTIFIER ON
 
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Setting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Setting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AppVersion] [int] NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
 
