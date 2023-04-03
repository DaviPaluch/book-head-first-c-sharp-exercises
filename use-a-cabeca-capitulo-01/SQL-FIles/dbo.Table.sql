CREATE TABLE [dbo].[Table]
(
	[ClienteId] INT NOT NULL PRIMARY KEY, 
    [Empresa] NCHAR(30) NULL, 
    [E-mail] NCHAR(50) NULL, 
    [IsClient] BIT NULL, 
    [LastMeet] DATETIME NULL
)
