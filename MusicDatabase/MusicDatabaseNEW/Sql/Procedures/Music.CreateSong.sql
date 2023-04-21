CREATE OR ALTER PROCEDURE Music.CreateSong
   @Title NVARCHAR(64),
   @ArtistID INT,
   @AlbumID INT,
   @GenreID INT,
   @SpotifyListens INT,
   @SongID INT OUTPUT
AS

INSERT Music.Song(Title, ArtistID, AlbumID, GenreID, SpotifyListens)
VALUES(@Title, @ArtistID, @AlbumID, @GenreID, @SpotifyListens);

SET @SongID = SCOPE_IDENTITY();
GO