CREATE OR ALTER PROCEDURE Music.GetArtist
   @Name NVARCHAR(64)
AS

SELECT A.Name
FROM Music.Artist A
WHERE A.Name = @Name;
GO
