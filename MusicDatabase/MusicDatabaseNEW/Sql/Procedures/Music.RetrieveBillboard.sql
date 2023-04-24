CREATE OR ALTER PROCEDURE Music.RetrieveBillboard
AS

SELECT B.BillboardID, B.AlbumID, B.WeekPosted, B.WeekRanking
FROM Music.Billboard B;
GO
