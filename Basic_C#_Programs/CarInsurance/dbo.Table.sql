CREATE TABLE [dbo].[Insurees]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[EmailAddress] NVARCHAR(50) NOT NULL,
	[DateOfBirth] DATETIME NOT NULL,
	[CarYear] INT NOT NULL,
	[CarMake] NVARCHAR(50) NOT NULL,
	[CarModel] NVARCHAR(50) NOT NULL,
	[DUI] BIT NOT NULL,
	[SpeedingTickets] Int NOT NULL,
	[CoverageType] BIT NOT NULL,
	[Qoute] MONEY NOT NULL

)
