CREATE OR ALTER PROCEDURE Music.FetchArtist
   @ArtistID INT
AS

SELECT A.[Name]
FROM Music.Arist A
WHERE A.ArtistID = @ArtistID;
GO

/*
CREATE OR ALTER PROCEDURE Music.FetchArtist
   @ArtistID INT
AS

SELECT A.SongID, A.[Name]
FROM Music.Arist A
WHERE A.ArtistID = @ArtistID;
GO
*/