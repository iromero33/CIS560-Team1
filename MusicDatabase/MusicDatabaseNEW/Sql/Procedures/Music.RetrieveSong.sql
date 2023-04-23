CREATE OR ALTER PROCEDURE Music.RetrieveSong
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
ORDER BY S.Title ASC;
GO
