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


