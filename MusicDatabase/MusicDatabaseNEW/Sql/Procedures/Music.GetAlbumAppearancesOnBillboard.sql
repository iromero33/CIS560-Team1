CREATE OR ALTER PROCEDURE Music.GetBillboard
	@AlbumID INT
AS

SELECT B.BillboardID, B.WeekPosted, B.WeekRanking
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GO
