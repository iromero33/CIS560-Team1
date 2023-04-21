﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using MusicDatabase;
using MusicDatabase.Models;

namespace MusicDatabaseGUI
{
    public class Controller
    {
        private AddItemDel AddNewItem;

        /// <summary>
        /// Connection String Example: @"Server=(localdb)\MSSQLLocalDb;Database=DATABASE;Integrated Security=SSPI;"
        /// </summary>
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=MusicDatabase;Integrated Security=SSPI;";

        private ISongRepository songRepository = new SqlSongRepository(connectionString);
        private IAlbumRepository albumRepository = new SqlAlbumRepository(connectionString);
        private IArtistRepository artistRepository = new SqlArtistRepository(connectionString);
        private IGenreRepository genreRepository = new SqlGenreRepository(connectionString);

        //Should eventually store BindingLists of songs, albums, etc.

        public void SetAddNewItemDel(AddItemDel del)
        {
            AddNewItem = del;
        }

        public void AddItemOfType(ItemType item)
        {
            AddNewItem(item);
        }

        public IReadOnlyList<Album> GetAlbums()
        {
            return albumRepository.RetrieveAlbums();
        }

        public IReadOnlyList<Song> GetSongs()
        {
            return songRepository.RetrieveSongs();
        }

        public IReadOnlyList<Artist> GetArtists()
        {
            return artistRepository.RetrieveArtists();
        }

        public IReadOnlyList<Genre> GetGenres()
        {
            return genreRepository.RetrieveGenres();
        }

        public void CreateAlbum(string name, DateTimeOffset releaseDate)
        {
            albumRepository.CreateAlbum(name, releaseDate);
        }

        public void CreateSong(string title, int artistID, int albumID, int genreID, int spotifyListens)
        {
            songRepository.CreateSong(title, artistID, albumID, genreID, spotifyListens);
        }

        public void CreateArtist(string name)
        {
            artistRepository.CreateArtist(name);
        }

        public Song FetchSong(int songID)
        {
            return songRepository.FetchSong(songID);
        }

        public Album FetchAlbum(int albumID)
        {
            return albumRepository.FetchAlbum(albumID);
        }

        public Artist FetchArtist(int artistID)
        {
            return artistRepository.FetchArtist(artistID);
        }

        public Genre FetchGenre(int genreID)
        {
            return genreRepository.FetchGenre(genreID);
        }
    }
}