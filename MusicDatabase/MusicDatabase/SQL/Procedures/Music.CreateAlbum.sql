CREATE OR ALTER PROCEDURE Music.CreateAlbum
   @Name NVARCHAR(32),
   @ReleaseDate DATETIMEOFFSET,
   @AlbumID INT OUTPUT
AS

INSERT Music.Album([Name], ReleaseDate)
VALUES(@Name, @ReleaseDate);

SET @AlbumID = SCOPE_IDENTITY();
GO