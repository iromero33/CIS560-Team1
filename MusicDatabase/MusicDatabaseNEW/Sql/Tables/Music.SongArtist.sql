IF OBJECT_ID(N'Music.SongArtist') IS NULL
BEGIN
   CREATE TABLE Music.SongArtist
   (
      ArtistID INT NOT NULL,
      SongID INT NOT NULL

      CONSTRAINT PK_Music_Song_SongID_ArtistID PRIMARY KEY CLUSTERED
      (
         ArtistID ASC,
         SongID ASC
      ),

      CONSTRAINT FK_Music_SongArtist_Music_Artist FOREIGN KEY(ArtistID)
      REFERENCES Music.Artist(ArtistID),

      CONSTRAINT FK_Music_SongArtist_Music_Song FOREIGN KEY(SongID)
      REFERENCES Music.Song(SongID)
   );
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.SongArtist')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Artist')
         AND fk.[name] = N'FK_Music_SongArtist_Music_Artist'
   )
BEGIN
   ALTER TABLE Music.SongArtist
   ADD CONSTRAINT [FK_Music_SongArtist_Music_Artist] FOREIGN KEY
   (
      ArtistID
   )
   REFERENCES Music.Artist
   (
      ArtistID
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.SongArtist')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Song')
         AND fk.[name] = N'FK_Music_SongArtist_Music_Song'
   )
BEGIN
   ALTER TABLE Music.SongArtist
   ADD CONSTRAINT [FK_Music_SongArtist_Music_Song] FOREIGN KEY
   (
      SongID
   )
   REFERENCES Music.Song
   (
      SongID
   );
END;