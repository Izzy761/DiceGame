CREATE TABLE [dbo].[PlayerHistory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlayerID] INT NOT NULL, 
    [Roll] INT NOT NULL DEFAULT 0 , 
    [Point] INT NULL  , 
    [Result] NVARCHAR(4) NULL   , 
    CONSTRAINT [FK_PlayerHistory_ToTable] FOREIGN KEY (PlayerID) REFERENCES [Players](ID)
)
