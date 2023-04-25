CREATE OR ALTER PROCEDURE Music.GetAlbumLongestBillboardAppearance
	@AlbumID INT,
	@LongestRun INT OUTPUT
AS

WITH ConsecutiveWeeksCte(LongestRun)
AS (
	SELECT 
		SUM(S.WeekSegments) OVER(PARTITION BY S.WeekPosted, S.AlbumID ORDER BY S.WeekPosted, S.WeekRanking) AS LongestRun
	FROM (
		SELECT 
			B.AlbumID,
			B.WeekPosted, 
			B.WeekRanking, 
			IIF(
				DATEDIFF(
					week, 
					B.WeekPosted, 
					LAG(B.WeekPosted) OVER(
						PARTITION BY B.WeekPosted, B.AlbumID 
						ORDER BY B.WeekPosted, B.WeekRanking
					)
				) = 1,
				0,
				1
			) AS WeekSegments
		FROM Music.Billboard B
		/*ORDER BY B.WeekPosted*/
	) S
	WHERE S.AlbumID = @AlbumID
)
SELECT 
	@LongestRun = COUNT(C.LongestRun)
FROM ConsecutiveWeeksCte C;
GO
