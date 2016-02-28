using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    class MovieDB
    {
        //Declare a dictionary of type Movie.
        Dictionary<int, Movie> movieTable;

        public MovieDB()
        {
            //Initialise movieTable.
            movieTable = new Dictionary<int, Movie>();
        }

        public void addDefaultFilms()
        {
            //Setup instances of movie to be pushed into the dictionary
            Movie movie1 = new Movie(1961, "Westside Story", "Jerome Robbins");
            Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
            Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
            Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

            //Method calls to add the above movies to a dictionary.
            movieTable.Add(movie1.Year, movie1); //Passes in an explicit value of a movie (.Year) to use as a key.
            movieTable.Add(movie2.Year, movie2); //...and then pass in the entirety of the instance afterwards. (Duplicate data on .Year, though.)
            movieTable.Add(movie3.Year, movie3);
            movieTable.Add(movie4.Year, movie4);
        }

        internal Dictionary<int, Movie> MovieTable
        {
            get { return movieTable; }
            set { movieTable = value; }
        }
    }
}
