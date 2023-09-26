using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ZM
{
    internal class Game
    {
        //puts a get on the string "Title," char "Esrb," and string "Genre."
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        //turns the words Title, Esrb, and Genre into Params.
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }

    }
}
