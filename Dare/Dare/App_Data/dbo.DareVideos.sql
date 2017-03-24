CREATE TABLE [dbo].DareVideos
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VideoSize] INT NOT NULL, 
    [Filename] VARCHAR(200) NOT NULL, 
    [VideoData] VARBINARY(MAX) NOT NULL
)
