CREATE OR ALTER PROCEDURE Music.GetSongByReleaseYear
	@Year DATETIMEOFFSET
AS

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
  INNER JOIN Music.Album A ON A.AlbumID = S.AlbumID
WHERE YEAR(A.ReleaseDate) = YEAR(@Year);
GO
