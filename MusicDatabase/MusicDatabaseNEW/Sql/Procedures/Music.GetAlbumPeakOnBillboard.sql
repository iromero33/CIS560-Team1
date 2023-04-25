CREATE OR ALTER PROCEDURE Music.GetAlbumPeakOnBillboard
	@AlbumID INT,
	@BillboardPeak INT OUTPUT
AS

SELECT @BillboardPeak = MAX(B.WeekRanking)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.WeekPosted, B.AlbumID
GO
