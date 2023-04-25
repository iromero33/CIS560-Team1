CREATE OR ALTER PROCEDURE Music.GetAlbumAppearancesOnBillboard
	@AlbumID INT
AS

SELECT COUNT(*)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.AlbumID
GO
