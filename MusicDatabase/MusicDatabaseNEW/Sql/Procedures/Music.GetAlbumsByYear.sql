CREATE OR ALTER PROCEDURE Music.GetAlbumsByYear
	@Year DATETIMEOFFSET
AS

SELECT A.AlbumID, A.[Name], A.ReleaseDate
FROM Music.Album A
WHERE YEAR(A.ReleaseDate) = YEAR(@Year)
ORDER BY A.[Name] ASC;
GO