using System;
using System.Collections.Generic;
using System.Text;
using MusicDatabase.Models;


namespace MusicDatabase
{
    public interface IGenreRepository
    {
        IReadOnlyList<Genre> RetrieveGenres();

        Genre FetchGenre(int genreID);

        Genre GetGenre(string name);

        Genre CreateGenre(string name);
    }
}
