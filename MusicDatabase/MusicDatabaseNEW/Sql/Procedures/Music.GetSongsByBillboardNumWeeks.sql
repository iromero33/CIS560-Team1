CREATE OR ALTER PROCEDURE Music.GetSongsByBillboardNumWeeks
	@BillboardWeeks INT
AS

WITH WeeksCTE AS 
(
	SELECT B.AlbumID, COUNT(*) AS WeeksOnBillboard
	FROM Music.Billboard B
	GROUP BY B.AlbumID
)
SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
	FULL OUTER JOIN WeeksCTE C ON C.AlbumID = S.AlbumID
WHERE @BillboardWeeks = 0 AND C.WeeksOnBillboard IS NULL 

UNION ALL

SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyListens
FROM Music.Song S
	INNER JOIN WeeksCTE C ON C.AlbumID = S.AlbumID
WHERE @BillboardWeeks > 0 AND C.WeeksOnBillboard = @BillboardWeeks
ORDER BY S.Title ASC;
GO
