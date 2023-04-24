CREATE OR ALTER PROCEDURE Music.GetBillboard
	@AlbumID INT
AS

WITH ConsecutiveWeeksCte(StartWeek, EndWeek, PeakRanking, LongestRun)
AS (
	SELECT 
		MIN(S.WeekPosted) AS StartWeek,
		MAX(S.WeekPosted) AS EndWeek,
		MAX(S.WeekRanking) AS PeakRanking,
		SUM(S.WeekSegments) OVER(PARTITION BY B.WeekPosted, B.AlbumID ORDER BY B.WeekPosted, B.WeekRanking) AS LongestRun
	FROM (
		SELECT 
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
		ORDER BY B.WeekPosted
	) S
	WHERE B.AlbumID = @AlbumID
	GROUP BY B.WeekPosted
)
SELECT 
	C.StartWeek, C.EndWeek, C.PeakRanking, MAX(LongestRun)
FROM ConsecutiveWeeksCte C
GROUP BY C.StartWeek, C.EndWeek, C.PeakRanking;
GO
