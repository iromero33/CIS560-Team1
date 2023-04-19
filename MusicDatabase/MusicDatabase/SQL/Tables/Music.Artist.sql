﻿IF OBJECT_ID(N'Music.Artist') IS NULL
BEGIN
   CREATE TABLE Music.Artist
   (
      ArtistID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      SongID INT NOT NULL,
      [Name] NVARCHAR(64) NOT NULL,
   );
END;