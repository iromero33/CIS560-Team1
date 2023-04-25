CREATE OR ALTER PROCEDURE Music.GetAlbumAppearancesOnBillboard
	@AlbumID INT,
	@AlbumAppearances INT OUTPUT
AS 

SELECT @AlbumAppearances = COUNT(*)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.AlbumID;
GO
