CREATE OR ALTER PROCEDURE Music.GetAlbumPeakOnBillboard
	@AlbumID INT
AS

SELECT MAX(B.WeekRanking) AS BillboardPeak
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.WeekPosted, B.AlbumID
GO
