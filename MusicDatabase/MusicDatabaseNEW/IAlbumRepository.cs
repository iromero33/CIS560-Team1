using System;
using System.Collections.Generic;
using System.Text;
using MusicDatabase.Models;


namespace MusicDatabase
{
    public interface IAlbumRepository
    {
        IReadOnlyList<Album> RetrieveAlbums();

        Album FetchAlbum(int albumID);

        Album GetAlbum(string name);

        Album CreateAlbum(string name, DateTimeOffset releaseDate);
    }
}
