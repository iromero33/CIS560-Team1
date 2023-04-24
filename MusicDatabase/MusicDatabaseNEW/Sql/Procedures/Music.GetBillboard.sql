CREATE OR ALTER PROCEDURE Music.GetBillboard
	@AlbumID INT,
	@WeekPosted DATETIMEOFFSET
AS

SELECT B.BillboardID
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID AND B.WeekPosted = @WeekPosted;
GO
