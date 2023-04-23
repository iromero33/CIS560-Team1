CREATE OR ALTER PROCEDURE Music.GetSongBySpotifyListens
	@SpotifyListens INT
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
WHERE S.SpotifyListens = @SpotifyListens;
GO
