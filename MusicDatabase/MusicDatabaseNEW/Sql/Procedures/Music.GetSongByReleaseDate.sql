CREATE OR ALTER PROCEDURE Music.GetSongByReleaseDate
	@ReleaseDate DATETIMEOFFSET
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
  INNER JOIN Music.Album A ON A.AlbumID = S.AlbumID
WHERE CAST(A.ReleaseDate AS DATE) = CAST(@ReleaseDate AS DATE)
GO
