using System;
using System.Collections.Generic;
using System.Text;
using MusicDatabase.Models;


namespace MusicDatabase
{
    public interface IArtistRepository
    {
        IReadOnlyList<Artist> RetrieveArtists();

        Artist FetchArtist(int artistID);

        Artist GetArtist(string name);

        Artist CreateArtist(string name, int songId);
    }
}
