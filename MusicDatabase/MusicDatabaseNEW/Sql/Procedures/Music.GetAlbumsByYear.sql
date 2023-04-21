CREATE OR ALTER PROCEDURE Music.GetAlbumsByYear
	@Year DATETIMEOFFSET
AS

SELECT A.AlbumID, A.[Name], A.ReleaseDate
FROM Music.Album A
WHERE YEAR(Album.ReleaseDate) = YEAR(@Year);
GO