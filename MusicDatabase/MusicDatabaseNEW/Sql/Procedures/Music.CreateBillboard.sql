CREATE OR ALTER PROCEDURE Music.CreateBillboard
   @AlbumID INT,
   @WeekPosted	DATETIMEOFFSET,
   @WeekRanking	INT OUTPUT,
   @BillboardID INT OUTPUT
AS

INSERT Music.Billboard(AlbumID, WeekPosted)
VALUES(@AlbumID, @WeekPosted);

SET @BillboardID = SCOPE_IDENTITY();
GO