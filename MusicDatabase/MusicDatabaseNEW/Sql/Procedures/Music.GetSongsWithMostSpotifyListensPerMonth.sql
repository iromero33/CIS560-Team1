CREATE OR ALTER PROCEDURE Music.GetSongsWithMostSpotifyListensPerMonth
AS

WITH ListensCTE AS (
SELECT YEAR(A.ReleaseDate) AS [Year], MONTH(A.ReleaseDate) AS [Month], MAX(S.SpotifyListens) AS SpotifyListens
	FROM Music.Song S
		INNER JOIN Music.Album A ON A.AlbumID = S.AlbumID
	GROUP BY YEAR(A.ReleaseDate), MONTH(A.ReleaseDate)
)
SELECT S.SongID, S.Title, S.ArtistID, S.AlbumID, S.GenreID, C.SpotifyListens
FROM Music.Song S
	INNER JOIN ListensCTE C ON C.SpotifyListens = S.SpotifyListens
ORDER BY C.[Year] DESC, C.[Month] ASC;
GO
