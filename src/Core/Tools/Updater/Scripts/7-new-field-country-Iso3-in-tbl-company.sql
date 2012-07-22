
CREATE TABLE dbo.Tmp_Company
	(
	Id int NOT NULL IDENTITY (1, 1),
	Name nvarchar(255) NULL,
	Industry nvarchar(255) NULL,
	Size nvarchar(255) NULL,
	Url nvarchar(255) NULL,
	Location nvarchar(255) NULL,
	ZipCode nvarchar(255) NULL,
	Email nvarchar(255) NULL,
	Password nvarchar(255) NULL,
	WelfareBalanceFor2011 bit NULL,
	WelfareBalanceFor2012 bit NULL,
	CountryIso3 char(3) NULL,
	DateCreated datetime NULL,
	DateModified datetime NULL
	)  ON [PRIMARY]

ALTER TABLE dbo.Tmp_Company SET (LOCK_ESCALATION = TABLE)

SET IDENTITY_INSERT dbo.Tmp_Company ON

IF EXISTS(SELECT * FROM dbo.Company)
	 EXEC('INSERT INTO dbo.Tmp_Company (Id, Name, Industry, Size, Url, Location, ZipCode, Email, Password, WelfareBalanceFor2011, WelfareBalanceFor2012, DateCreated, DateModified)
		SELECT Id, Name, Industry, Size, Url, Location, ZipCode, Email, Password, WelfareBalanceFor2011, WelfareBalanceFor2012, DateCreated, DateModified FROM dbo.Company WITH (HOLDLOCK TABLOCKX)')

SET IDENTITY_INSERT dbo.Tmp_Company OFF

DROP TABLE dbo.Company

EXECUTE sp_rename N'dbo.Tmp_Company', N'Company', 'OBJECT' 

ALTER TABLE dbo.Company ADD CONSTRAINT
	PK__Organisa__3214EC0732767D0B PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
