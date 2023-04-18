IF OBJECT_ID(N'Music.Song') IS NULL
BEGIN
   CREATE TABLE Music.Song
   (
      SongID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      Title NVARCHAR(64) NOT NULL,
      ArtistID INT NOT NULL,
      AlbumID INT NOT NULL,
      GenreID INT NOT NULL,
      SpotifyID INT NOT NULL
   );
END;