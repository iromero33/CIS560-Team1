CREATE OR ALTER PROCEDURE Music.GetBillboard
	@AlbumID INT
AS

SELECT TOP(1) B.BillboardID, B.WeekPosted, B.WeekRanking
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
ORDER BY B.WeekRanking
GO
