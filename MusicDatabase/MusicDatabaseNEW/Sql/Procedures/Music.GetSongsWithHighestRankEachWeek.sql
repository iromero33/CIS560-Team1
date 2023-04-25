CREATE OR ALTER PROCEDURE Music.GetSongsWithHighestRankAlbumForWeek
	@Week DateTimeOffset
AS

WITH RankingCTE AS (
	SELECT B.WeekPosted, MIN(B.WeekRanking) AS MaxWeekRanking
	FROM Music.Billboard B
	GROUP BY B.WeekPosted
	HAVING WEEK(B.WeekPosted) = WEEK(@Week) AND YEAR(B.WeekPosted) = YEAR(@Week)
)
SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
	INNER JOIN (Music.Billboard B 
		INNER JOIN RankingCTE C ON C.WeekPosted = B.WeekPosted AND C.MaxWeekRanking = B.WeekRanking)
	ON B.AlbumID = S.AlbumID;
GO
