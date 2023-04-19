﻿IF OBJECT_ID(N'Music.Song') IS NULL
BEGIN
   CREATE TABLE Music.Song
   (
      SongID INT NOT NULL IDENTITY(1, 1),
      Title NVARCHAR(64) NOT NULL,
      ArtistID INT NOT NULL,
      AlbumID INT NOT NULL,
      GenreID INT NOT NULL,
      SpotifyListens INT NOT NULL

       CONSTRAINT PK_Music_Song_SongID PRIMARY KEY CLUSTERED
      (
         SongID ASC
      )
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
      WHERE fk.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND fk.referenced_object_id = OBJECT_ID(N'Person.Person')
         AND fk.[name] = N'FK_Person_PersonAddress_Person_Person'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [FK_Person_PersonAddress_Person_Person] FOREIGN KEY
   (
      PersonId
   )
   REFERENCES Person.Person
   (
      PersonId
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Person.PersonAddress')
         AND fk.referenced_object_id = OBJECT_ID(N'Person.AddressType')
         AND fk.[name] = N'FK_Person_PersonAddress_Person_AddressType'
   )
BEGIN
   ALTER TABLE Person.PersonAddress
   ADD CONSTRAINT [FK_Person_PersonAddress_Person_AddressType] FOREIGN KEY
   (
      AddressTypeId
   )
   REFERENCES Person.AddressType
   (
      AddressTypeId
   );
END;