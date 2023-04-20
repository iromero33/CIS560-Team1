CREATE OR ALTER PROCEDURE Music.GetAlbum
	@Name NVARCHAR(64)
AS

SELECT A.AlbumID, A.ReleaseDate
FROM Music.Album A
WHERE A.[Name] = @Name;
GO
