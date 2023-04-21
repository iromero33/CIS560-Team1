IF OBJECT_ID(N'Music.Song') IS NULL
BEGIN
   CREATE TABLE Music.Song
   (
      SongID INT NOT NULL IDENTITY(1, 1),
      Title NVARCHAR(64) NOT NULL,
      ArtistID INT NOT NULL,
      AlbumID INT NOT NULL,
      GenreID INT NOT NULL,
      SpotifyListens INT NOT NULL,
      

      CONSTRAINT PK_Music_Song_SongID PRIMARY KEY CLUSTERED
      (
         SongID ASC
      ),

      CONSTRAINT FK_Music_Song_Music_Artist FOREIGN KEY(ArtistID)
      REFERENCES Music.Artist(ArtistID),

      CONSTRAINT FK_Music_Song_Music_Album FOREIGN KEY(AlbumID)
      REFERENCES Music.Album(AlbumID),

      CONSTRAINT FK_Music_Song_Music_Genre FOREIGN KEY(GenreID)
      REFERENCES Music.Genre(GenreID)

     
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Music.Song')
         AND kc.[name] = N'UK_Music_Song_Title_AlbumID'

   )
BEGIN
   ALTER TABLE Music.Song
   ADD CONSTRAINT [UK_Music_Song_Title_AlbumID] UNIQUE NONCLUSTERED
   (
      Title ASC,
      AlbumID ASC
   )
END;

/****************************
 * Foreign Keys Constraints
 ****************************/


IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.Song')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Artist')
         AND fk.[name] = N'FK_Music_Song_Music_Artist'
   )
BEGIN
   ALTER TABLE Music.Song
   ADD CONSTRAINT [FK_Music_Song_Music_Artist] FOREIGN KEY
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
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.Song')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Album')
         AND fk.[name] = N'FK_Music_Song_Music_Album'
   )
BEGIN
   ALTER TABLE Music.Song
   ADD CONSTRAINT [FK_Music_Song_Music_Album] FOREIGN KEY
   (
      AlbumID
   )
   REFERENCES Music.Album
   (
      AlbumID
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Music.Song')
         AND fk.referenced_object_id = OBJECT_ID(N'Music.Genre')
         AND fk.[name] = N'FK_Music_Song_Music_Genre'
   )
BEGIN
   ALTER TABLE Music.Song
   ADD CONSTRAINT [FK_Music_Song_Music_Genre] FOREIGN KEY
   (
      GenreID
   )
   REFERENCES Music.Genre
   (
      GenreID
   );
END;