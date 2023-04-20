﻿CREATE OR ALTER PROCEDURE Music.CreateGenre
   @Name NVARCHAR(64),
   @GenreID INT OUTPUT
AS

INSERT Music.Genre([Name])
VALUES(@Name);

SET @GenreID = SCOPE_IDENTITY();
GO