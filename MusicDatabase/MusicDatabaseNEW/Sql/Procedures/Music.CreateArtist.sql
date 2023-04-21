CREATE OR ALTER PROCEDURE Music.CreateArtist
   @Name NVARCHAR(32),
   @ArtistID INT OUTPUT
AS

INSERT Music.Artist([Name])
VALUES(@Name);

SET @ArtistID = SCOPE_IDENTITY();
GO

/*
CREATE OR ALTER PROCEDURE Music.CreateArtist
   @Name NVARCHAR(32),
   @SongID INT,
   @ArtistID INT OUTPUT
AS

INSERT Music.Artist([Name], SongID)
VALUES(@Name, @SongID);

SET @ArtistID = SCOPE_IDENTITY();
GO
*/