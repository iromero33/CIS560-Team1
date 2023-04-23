IF OBJECT_ID(N'Music.Artist') IS NULL
BEGIN
   CREATE TABLE Music.Artist
   (
      ArtistID INT NOT NULL IDENTITY(1, 1),
      [Name] NVARCHAR(128) NOT NULL,

      CONSTRAINT [PK_Music_Artist_ArtistID] PRIMARY KEY CLUSTERED
      (
         ArtistID ASC
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
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Music.Artist')
         AND cc.[name] = N'CK_Music_Artist_Name'
   )
BEGIN
   ALTER TABLE Music.Artist
   ADD CONSTRAINT [CK_Music_Artist_Name] CHECK
   (
      [Name] > N'' 
   )
END;
