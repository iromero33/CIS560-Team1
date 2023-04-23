IF OBJECT_ID(N'Music.Billboard') IS NULL
BEGIN
   CREATE TABLE Music.Billboard
   (
      BillboardID INT NOT NULL IDENTITY(1, 1),
      WeekPosted DATETIMEOFFSET NOT NULL,
      WeekRanking INT NOT NULL,
      AlbumID INT NOT NULL

      CONSTRAINT [PK_Music_Billboard_BillboardID] PRIMARY KEY CLUSTERED
      (
         BillboardID ASC
      ),

      CONSTRAINT FK_Music_Billboard_Music_Album FOREIGN KEY(AlbumID)
      REFERENCES Music.Album(AlbumID)
   );
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.Billboard')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Album')
         AND fk.[name] = N'FK_Music_Billboard_Music_Album'
   )
BEGIN
   ALTER TABLE Music.Song
   ADD CONSTRAINT [FK_Music_Billboard_Music_Album] FOREIGN KEY
   (
      AlbumID
   )
   REFERENCES Music.Album
   (
      AlbumID
   );
END;