IF OBJECT_ID(N'Music.Artist') IS NULL
BEGIN
   CREATE TABLE Music.Artist
   (
      ArtistID INT NOT NULL IDENTITY(1, 1),
      SongID INT NOT NULL,
      [Name] NVARCHAR(64) NOT NULL,

      CONSTRAINT [PK_Music_Artist_ArtistID] PRIMARY KEY CLUSTERED
      (
         ArtistID ASC
      ),

      CONSTRAINT FK_Music_Artist_Music_Song FOREIGN KEY(SongID)
      REFERENCES Music.Song(SongID)
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Music.Artist')
         AND kc.[name] = N'UK_Music_Artist_Name'
   )
BEGIN
   ALTER TABLE Music.Artist
   ADD CONSTRAINT [UK_Music_Artist_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.Artist')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Song')
         AND fk.[name] = N'FK_Music_Artist_Music_Song'
   )
BEGIN
   ALTER TABLE Music.Artist
   ADD CONSTRAINT [FK_Music_Artist_Music_Song] FOREIGN KEY
   (
      SongID
   )
   REFERENCES Music.Song
   (
      SongID
   );
END;

