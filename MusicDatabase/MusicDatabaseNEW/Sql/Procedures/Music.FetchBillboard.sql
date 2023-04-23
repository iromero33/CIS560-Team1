CREATE OR ALTER PROCEDURE Music.FetchBillboard
	@BillboardID INT
AS

SELECT B.AlbumID, B.WeekPosted, B.WeekRanking
FROM Music.Billboard B
WHERE B.BillboardID = @BillboardID;
GO
