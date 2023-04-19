CREATE OR ALTER PROCEDURE Music.GetBillboard
	@AlbumID INT,
	@StartDate DATETIMEOFFSET,
	@EndDate DATETIMEOFFSET
AS

SELECT B.BillboardID
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID AND B.StartDate = @StartDate AND B.EndDate = @EndDate;
GO
