CREATE OR ALTER PROCEDURE Music.GetAlbumAppearancesOnBillboard
	@AlbumID INT
AS

SELECT IIF(COUNT(*) <> NULL, COUNT(*), 0)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.AlbumID
GO
