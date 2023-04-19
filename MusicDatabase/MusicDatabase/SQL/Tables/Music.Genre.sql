IF OBJECT_ID(N'Music.Genre') IS NULL
BEGIN
   CREATE TABLE Music.Genre
   (
      GenreID INT NOT NULL IDENTITY(1, 1),
      [Name] NVARCHAR(64) NOT NULL UNIQUE,

      CONSTRAINT [PK_Music_Genre_GenreID] PRIMARY KEY CLUSTERED
      (
         GenreID ASC
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
      WHERE cc.parent_object_id = OBJECT_ID(N'Music.Genre')
         AND cc.[name] = N'CK_Music_Genre_Name'
   )
BEGIN
   ALTER TABLE Music.Genre
   ADD CONSTRAINT [CK_Music_Genre_Name] CHECK
   (
      [Name] > N'' 
   )
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Music.Genre')
         AND kc.[name] = N'UK_Music_Genre_Name'
   )
BEGIN
   ALTER TABLE Music.Genre
   ADD CONSTRAINT [UK_Music_Genre_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;
