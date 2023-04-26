CREATE OR ALTER PROCEDURE Music.GetAlbumPeakOnBillboard
	@AlbumID INT,
	@BillboardPeak INT OUTPUT
AS

SELECT @BillboardPeak = MIN(B.WeekRanking)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.AlbumID
GO
