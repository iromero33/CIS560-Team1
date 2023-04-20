CREATE OR ALTER PROCEDURE Music.RetrieveBillboard
AS

SELECT B.BillboardID, B.AlbumID, B.StartDate, B.EndDate
FROM Music.Billboard B;
GO
