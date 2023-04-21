CREATE OR ALTER PROCEDURE Music.GetSongsByAlbum
	@AlbumID INT
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
WHERE S.AlbumID = @AlbumID;
GO
