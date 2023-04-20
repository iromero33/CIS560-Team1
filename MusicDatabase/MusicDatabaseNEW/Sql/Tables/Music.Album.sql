IF OBJECT_ID(N'Music.Album') IS NULL
BEGIN
   CREATE TABLE Music.Album
   (
      AlbumID INT NOT NULL IDENTITY(1, 1),
      [Name] NVARCHAR(64) NOT NULL,
      ReleaseDate DATETIMEOFFSET NOT NULL

      CONSTRAINT [PK_Music_Album_AlbumID] PRIMARY KEY CLUSTERED
      (
         AlbumID ASC
      )
   );
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Music.Album')
         AND cc.[name] = N'CK_Music_Album_Name'
   )
BEGIN
   ALTER TABLE Music.Album
   ADD CONSTRAINT [CK_Music_Album_Name] CHECK
   (
      [Name] > N'' 
   )
END;

