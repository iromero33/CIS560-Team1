CREATE OR ALTER PROCEDURE Music.GetSong
	@Title NVARCHAR(64),
	@AlbumID INT
AS

SELECT S.SongID, S.ArtistID, S.GenreID, S.SpotifyListens
FROM Music.Song S
WHERE S.Title = @Title AND S.AlbumID = @AlbumID;
GO
