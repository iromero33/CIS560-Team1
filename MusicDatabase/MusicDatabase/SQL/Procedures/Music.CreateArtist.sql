CREATE OR ALTER PROCEDURE Music.CreateArtist
   @Name NVARCHAR(32),
   @ArtistID INT OUTPUT
AS

INSERT Person.Person([Name])
VALUES(@Name);

SET @ArtistID = SCOPE_IDENTITY();
GO