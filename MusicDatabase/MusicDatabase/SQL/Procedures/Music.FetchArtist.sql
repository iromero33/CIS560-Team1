CREATE OR ALTER PROCEDURE Music.FetchArtist
   @ArtistID INT
AS

SELECT A.Name
FROM Music.Arist A
WHERE A.ArtistID = @ArtistID;
GO