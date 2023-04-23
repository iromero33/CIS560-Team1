CREATE OR ALTER PROCEDURE Music.GetSongsBySpotifyListensDESC
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
ORDER BY S.SpotifyListens DESC, S.Title ASC;
GO
