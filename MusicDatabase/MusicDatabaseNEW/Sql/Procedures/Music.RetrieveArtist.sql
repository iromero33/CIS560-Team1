CREATE OR ALTER PROCEDURE Music.RetrieveArtist
AS

SELECT A.ArtistID, A.[Name]
FROM Music.Artist A;
GO

/*
CREATE OR ALTER PROCEDURE Music.RetrieveArtist
AS

SELECT A.ArtistID, A.SongID, A.[Name]
FROM Music.Artist A;
GO
*/
