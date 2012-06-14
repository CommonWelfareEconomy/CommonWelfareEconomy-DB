CREATE TABLE dbo.Club
	(
	Id int NOT NULL IDENTITY (1, 1),
	Name nvarchar(150) NOT NULL,
	AreaOfWork nvarchar(150) NOT NULL,
	Location nvarchar(150) NOT NULL,
	Email nvarchar(150) NOT NULL,
	Url nvarchar(150) NOT NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	)  ON [PRIMARY]

ALTER TABLE dbo.Club SET (LOCK_ESCALATION = TABLE)

