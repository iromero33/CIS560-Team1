CREATE OR ALTER PROCEDURE Music.CreateArtist
   @Name NVARCHAR(32),
   @SongID INT,
   @ArtistID INT OUTPUT
AS

INSERT Person.Person([Name], SongID)
VALUES(@Name, @SongID);

SET @ArtistID = SCOPE_IDENTITY();
GO