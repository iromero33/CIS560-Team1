CREATE OR ALTER PROCEDURE Music.GetAlbumLongestBillboardAppearance
	@AlbumID INT,
	@LongestRun INT OUTPUT
AS

WITH ConsecutiveWeeksCte(LongestRun)
AS (
	SELECT 
		SUM(S.WeekSegments) OVER(PARTITION BY S.AlbumID ORDER BY S.WeekPosted ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS LongestRun
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
						PARTITION BY B.AlbumID 
						ORDER BY B.WeekPosted
					)
				) = -1,
				0,
				1
			) AS WeekSegments
		FROM Music.Billboard B
		/*ORDER BY B.WeekPosted*/
	) S
	WHERE S.AlbumID = @AlbumID
)
SELECT TOP(1)
	@LongestRun = COUNT(C.LongestRun)
FROM ConsecutiveWeeksCte C
GROUP BY C.LongestRun
ORDER BY COUNT(C.LongestRun) DESC;
GO
