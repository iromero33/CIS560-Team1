﻿CREATE OR ALTER PROCEDURE Music.RetrieveAlbum
AS

SELECT A.AlbumID, A.[Name], A.ReleaseDate
FROM Music.Album A
ORDER BY A.[Name] ASC;
GO
