using System;
using System.Collections.Generic;
using System.Text;
using MusicDatabase.Models;


namespace MusicDatabase
{
    public interface ISongRepository
    {
        /// <summary>
        /// Retrieves all songs in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Song}"/> containing all songs.
        /// </returns>
        IReadOnlyList<Song> RetrieveSongs();

        /// <summary>
        /// Fetches the song with the given <paramref name="SongID"/> if it exists.
        /// </summary>
        /// <param name="SongID">Identifier of the song to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Song"/> containing the information of the requested song.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="SongID"/> does not exist.
        /// </exception>
        Song FetchSong(int songID);

        /// <summary>
        /// Gets the song with the given <paramref name="SongID"/> if it exists.
        /// </summary>
        /// <param name="title">Title of the Song to get.</param>
        /// <returns>
        /// An instance of <see cref="song"/> containing the information of the requested song
        /// if one exists with with the provided <paramref name="email"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Song GetSong(string title, int albumID);

        Song CreateSong(string title, int artistID, int albumID, int genreID, int spotifyListens);

        IReadOnlyList<Song> GetSongsByTitle(string title);

        IReadOnlyList<Song> GetSongsByAlbum(int albumID);

        IReadOnlyList<Song> GetSongsByReleaseDate(DateTimeOffset date);

        IReadOnlyList<Song> GetSongsBySpotifyListens(int listens);
    }
}
