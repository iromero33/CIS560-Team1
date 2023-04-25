CREATE OR ALTER PROCEDURE Music.GetAlbumPeakOnBillboard
	@AlbumID INT
AS

SELECT IIF(MAX(B.WeekRanking) <> NULL, MAX(B.WeekRanking), 0)
FROM Music.Billboard B
WHERE B.AlbumID = @AlbumID
GROUP BY B.WeekPosted, B.AlbumID
GO
