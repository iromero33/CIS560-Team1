CREATE OR ALTER PROCEDURE Music.GetSongsByTitle
	@Title NVARCHAR(64)
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
WHERE LOWER(S.Title) LIKE LOWER(@Title);
GO
