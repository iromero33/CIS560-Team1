CREATE OR ALTER PROCEDURE Music.CreateArtist
   @Title NVARCHAR(64),
   @ArtistID INT,
   @AlbumID INT,
   @GenreID INT,
   @SpotifyListens INT,
   @SongID INT OUTPUT
AS

INSERT Music.Artist(Title, ArtistID, AlbumID, GenreID, SpotifyListens, SongID)
VALUES(@Title, @ArtistID, @AlbumID, @GenreID, @SpotifyListens, @SongID);

SET @SongID = SCOPE_IDENTITY();
GO