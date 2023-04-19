CREATE OR ALTER PROCEDURE Music.CreateBillboard
   @AlbumID INT,
   @StartDate DATETIMEOFFSET,
   @EndDate DATETIMEOFFSET,
   @BillboardID INT OUTPUT
AS

INSERT Music.Billboard(AlbumID, StartDate, EndDate)
VALUES(@AlbumID, @StartDate, @EndDate);

SET @BillboardID = SCOPE_IDENTITY();
GO