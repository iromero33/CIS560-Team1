CREATE OR ALTER PROCEDURE Music.RetrieveGenre
AS

SELECT G.GenreID, G.[Name]
FROM Music.Genre G
ORDER BY G.[Name] ASC;
GO
