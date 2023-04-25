CREATE OR ALTER PROCEDURE Music.SaveBillboard
   @BillboardID INT,
   @AlbumID INT,
   @WeekPosted DateTimeOffset,
   @WeekRanking INT
   
AS

MERGE Music.Billboard B
USING
      (
         VALUES(@BillboardID, @WeekPosted, @WeekRanking, @AlbumID)
      ) S(BillboardID, WeekPosted, WeekRanking, AlbumID)
   ON S.BillboardID = B.BillboardID
      AND S.AlbumID = B.AlbumID
      AND S.WeekPosted = B.WeekPosted
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.WeekPosted
         INTERSECT
         SELECT  B.WeekPosted
      ) THEN
   UPDATE
   SET
      WeekPosted = S.WeekPosted
WHEN NOT MATCHED THEN
   INSERT(BillboardID, WeekPosted, WeekRanking, AlbumID)
   VALUES(S.BillboardID, S.WeekPosted, S.WeekRanking, S.AlbumID);
GO
