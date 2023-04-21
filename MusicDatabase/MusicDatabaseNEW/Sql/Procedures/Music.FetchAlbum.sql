﻿CREATE OR ALTER PROCEDURE Music.FetchAlbum
	@AlbumID INT
AS

SELECT A.[Name], A.ReleaseDate
FROM Music.Album A
WHERE A.AlbumID = @AlbumID;
GO
