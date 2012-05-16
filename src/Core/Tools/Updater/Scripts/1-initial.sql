/****** Object:  ForeignKey [FKECA155F924B4B9D0]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKECA155F924B4B9D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person]'))
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FKECA155F924B4B9D0]
 
/****** Object:  ForeignKey [FKD570493F416DA7E]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F416DA7E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter] DROP CONSTRAINT [FKD570493F416DA7E]
 
/****** Object:  ForeignKey [FKD570493F776B01B0]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F776B01B0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter] DROP CONSTRAINT [FKD570493F776B01B0]
 
/****** Object:  Table [dbo].[Person_Newsletter]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F416DA7E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter] DROP CONSTRAINT [FKD570493F416DA7E]
 
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F776B01B0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter] DROP CONSTRAINT [FKD570493F776B01B0]
 
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]') AND type in (N'U'))
DROP TABLE [dbo].[Person_Newsletter]
 
/****** Object:  Table [dbo].[Person]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKECA155F924B4B9D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person]'))
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FKECA155F924B4B9D0]
 
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
 
/****** Object:  Table [dbo].[Setting]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Setting]') AND type in (N'U'))
DROP TABLE [dbo].[Setting]
 
/****** Object:  Table [dbo].[Newsletter]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Newsletter]') AND type in (N'U'))
DROP TABLE [dbo].[Newsletter]
 
/****** Object:  Table [dbo].[Organisation]    Script Date: 05/16/2012 16:02:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Organisation]') AND type in (N'U'))
DROP TABLE [dbo].[Organisation]
 
/****** Object:  Table [dbo].[Organisation]    Script Date: 05/16/2012 16:02:05 ******/
SET ANSI_NULLS ON
 
SET QUOTED_IDENTIFIER ON
 
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
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Newsletter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Newsletter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
 
/****** Object:  Table [dbo].[Setting]    Script Date: 05/16/2012 16:02:05 ******/
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
 
/****** Object:  Table [dbo].[Person]    Script Date: 05/16/2012 16:02:05 ******/
SET ANSI_NULLS ON
 
SET QUOTED_IDENTIFIER ON
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[Organisation_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
 
/****** Object:  Table [dbo].[Person_Newsletter]    Script Date: 05/16/2012 16:02:05 ******/
SET ANSI_NULLS ON
 
SET QUOTED_IDENTIFIER ON
 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Person_Newsletter](
	[Newsletter_id] [int] NOT NULL,
	[Person_id] [int] NOT NULL
) ON [PRIMARY]
END
 
/****** Object:  ForeignKey [FKECA155F924B4B9D0]    Script Date: 05/16/2012 16:02:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKECA155F924B4B9D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person]'))
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FKECA155F924B4B9D0] FOREIGN KEY([Organisation_id])
REFERENCES [dbo].[Organisation] ([Id])
 
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKECA155F924B4B9D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person]'))
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FKECA155F924B4B9D0]
 
/****** Object:  ForeignKey [FKD570493F416DA7E]    Script Date: 05/16/2012 16:02:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F416DA7E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter]  WITH CHECK ADD  CONSTRAINT [FKD570493F416DA7E] FOREIGN KEY([Newsletter_id])
REFERENCES [dbo].[Newsletter] ([Id])
 
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F416DA7E]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter] CHECK CONSTRAINT [FKD570493F416DA7E]
 
/****** Object:  ForeignKey [FKD570493F776B01B0]    Script Date: 05/16/2012 16:02:05 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F776B01B0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter]  WITH CHECK ADD  CONSTRAINT [FKD570493F776B01B0] FOREIGN KEY([Person_id])
REFERENCES [dbo].[Person] ([Id])
 
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FKD570493F776B01B0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Person_Newsletter]'))
ALTER TABLE [dbo].[Person_Newsletter] CHECK CONSTRAINT [FKD570493F776B01B0]
 
