CREATE OR ALTER PROCEDURE Music.CreateArtist
   @Title NVARCHAR(64),
   @ArtistID INT,
   @AlbumID INT,
   @GenreID INT,
   @SpotifyID INT,
   @SongID INT OUTPUT
AS

INSERT Music.Artist(Title, ArtistID, AlbumID, GenreID, SpotifyID, SongID)
VALUES(@Title, @ArtistID, @AlbumID, @GenreID, @SpotifyID, @SongID);

SET @SongID = SCOPE_IDENTITY();
GO