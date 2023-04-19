CREATE OR ALTER PROCEDURE Music.FetchGenre
   @GenreID INT
AS

SELECT G.Name
FROM Music.Genre G
WHERE G.GenreID = @GenreID;
GO