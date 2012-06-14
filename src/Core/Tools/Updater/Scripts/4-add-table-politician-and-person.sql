CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Job] [nvarchar](255) NULL,
	[Location] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[Url] [nvarchar](255) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


/***********/

CREATE TABLE [dbo].[Politician](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Capacity] [nvarchar](255) NULL,
	[Location] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[Url] [nvarchar](255) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

