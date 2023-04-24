CREATE OR ALTER PROCEDURE Music.GetBillboard
	@AlbumID INT
AS

SELECT MAX(B.WeekRanking)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.WeekPosted, B.AlbumID
GO
