CREATE OR ALTER PROCEDURE Music.FetchBillboard
	@BillboardID INT
AS

SELECT B.AlbumID, B.StartDate, B.EndDate
FROM Music.Billboard B
WHERE B.BillboardID = @BillboardID;
GO
