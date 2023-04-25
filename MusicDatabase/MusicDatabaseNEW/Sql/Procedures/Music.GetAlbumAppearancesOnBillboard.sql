CREATE OR ALTER PROCEDURE Music.GetAlbumAppearancesOnBillboard
	@AlbumID INT
AS

SELECT COUNT(*) AS AlbumAppearances
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.AlbumID
GO
