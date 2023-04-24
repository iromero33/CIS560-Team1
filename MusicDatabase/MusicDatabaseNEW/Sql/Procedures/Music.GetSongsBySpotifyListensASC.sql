CREATE OR ALTER PROCEDURE Music.GetSongsBySpotifyListensASC
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
ORDER BY S.SpotifyListens ASC, S.Title ASC;
GO
