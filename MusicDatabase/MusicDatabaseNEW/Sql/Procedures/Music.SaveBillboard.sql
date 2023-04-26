CREATE OR ALTER PROCEDURE Music.SaveBillboard
   @AlbumID INT,
   @WeekPosted DateTimeOffset,
   @WeekRanking INT
AS

MERGE Music.Billboard B
USING
      (
         VALUES(@WeekPosted, @WeekRanking, @AlbumID)
      ) S(WeekPosted, WeekRanking, AlbumID)
   ON S.WeekPosted = B.WeekPosted
      AND S.WeekRanking = B.WeekRanking
WHEN MATCHED AND S.AlbumID <> B.AlbumID THEN
   UPDATE
   SET
      WeekRanking = S.WeekRanking
WHEN NOT MATCHED THEN
   INSERT(WeekPosted, WeekRanking, AlbumID)
   VALUES(S.WeekPosted, S.WeekRanking, S.AlbumID);
GO
