IF OBJECT_ID(N'Music.SpotifyListens') IS NULL
BEGIN
   CREATE TABLE Music.SpotifyListens
   (
      SpotifyID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      Listens INT NOT NULL,
      SongID INT NOT NULL,
   );
END;