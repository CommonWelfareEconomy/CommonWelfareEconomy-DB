CREATE TABLE [dbo].[wp_gwo_cformsdata](
	[f_id] [int] NOT NULL,
	[sub_id] [int] NOT NULL,
	[field_name] [varchar](100) NOT NULL,
	[field_val] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[wp_gwo_cformssubmissions](
	[id] [int] NOT NULL,
	[form_id] [varchar](3) NULL,
	[sub_date] [date] NULL,
	[email] [varchar](50) NULL,
	[ip] [varchar](50) NULL
) ON [PRIMARY]

