IF OBJECT_ID(N'Music.Billboard') IS NULL
BEGIN
   CREATE TABLE Music.Billboard
   (
      BillboardID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      WeekPosted DATETIMEOFFSET NOT NULL,
      WeekRanking INT NOT NULL,
      AlbumID INT NOT NULL
   );
END;