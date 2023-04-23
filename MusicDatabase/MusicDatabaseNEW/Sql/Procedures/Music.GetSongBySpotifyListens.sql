CREATE OR ALTER PROCEDURE Music.GetSongBySpotifyListens
	@SpotifyListensMin INT,
	@SpotifyListensMax INT
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
WHERE S.SpotifyListens > @SpotifyListensMin AND S.SpotifyListens < @SpotifyListensMax
ORDER BY S.Title ASC;
GO
