CREATE OR ALTER PROCEDURE Music.RetrieveArtist
AS

SELECT A.ArtistID, A.[Name]
FROM Music.Artist A
ORDER BY A.[Name] ASC;
GO

/*
CREATE OR ALTER PROCEDURE Music.RetrieveArtist
AS

SELECT A.ArtistID, A.SongID, A.[Name]
FROM Music.Artist A;
GO
*/
