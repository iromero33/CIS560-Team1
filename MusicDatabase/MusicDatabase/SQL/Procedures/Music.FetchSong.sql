﻿CREATE OR ALTER PROCEDURE Music.FetchSong
	@SongID INT
AS

SELECT S.Title, S.ArtistID, S.AlbumID, S.GenreID, S.SpotifyID
FROM Music.Song S
WHERE S.SongID = @SongID;
GO
