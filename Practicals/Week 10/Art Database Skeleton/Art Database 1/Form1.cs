using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Art_Database_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Artist> artists;
        public List<Painting> paintings;

        private void Form1_Load(object sender, EventArgs e)
        {
            artists = new List<Artist>();
            artists.Add(new Artist { Country = "France", FirstName = "Camille", LastName = "Pissarro", YearOfBirth = 1830, YearOfDeath = 1903 });
            artists.Add(new Artist { Country = "France", FirstName = "Claude", LastName = "Monet", YearOfBirth = 1840, YearOfDeath = 1926 });
            artists.Add(new Artist { Country = "England", FirstName = "John", LastName = "Constable", YearOfBirth = 1776, YearOfDeath = 1837 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Jan", LastName = "Vermeer", YearOfBirth = 1632, YearOfDeath = 1675 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sanzio", LastName = "Raphael", YearOfBirth = 1483, YearOfDeath = 1520 });
            artists.Add(new Artist { Country = "Spain", FirstName = "Pablo", LastName = "Picasso", YearOfBirth = 1881, YearOfDeath = 1973 });
            artists.Add(new Artist { Country = "Norway", FirstName = "Edvard", LastName = "Munch", YearOfBirth = 1863, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Leonardo", LastName = "da Vinci", YearOfBirth = 1452, YearOfDeath = 1519 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sandro", LastName = "Botticelli", YearOfBirth = 1445, YearOfDeath = 1510 });
            artists.Add(new Artist { Country = "France", FirstName = "Henri", LastName = "Matisse", YearOfBirth = 1869, YearOfDeath = 1954 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Piet", LastName = "Mondrian", YearOfBirth = 1872, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "United States", FirstName = "Jackson", LastName = "Pollock", YearOfBirth = 1912, YearOfDeath = 1956 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Vincent", LastName = "van Gogh", YearOfBirth = 1853, YearOfDeath = 1890 });

            paintings = new List<Painting>();
            paintings.Add(new Painting { Artist = "van Gogh", Title = "The Starry Night", Method = "Oil on canvas", Year = 1889, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "van Gogh", Title = "Village Street in Auvers ", Method = "Oil on canvas", Year = 1890, Width = 73, Height = 92 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Gelee Blanche", Method = "Oil on canvas", Year = 1873, Width = 65, Height = 93 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Village Path", Method = "Oil on canvas", Year = 1875, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Fishing Boats Leaving the Harbor, Le Havre ", Method = "Oil on canvas", Year = 1874, Width = 60, Height = 101 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Water Lilies ", Method = "Oil on canvas", Year = 1906, Width = 88, Height = 93 });
            paintings.Add(new Painting { Artist = "Constable", Title = "The Leaping Horse", Method = "Oil on canvas", Year = 1825, Width = 142, Height = 187 });
            paintings.Add(new Painting { Artist = "Vermeer", Title = "Girl with a Pearl Earring", Method = "Oil on canvas", Year = 1665, Width = 45, Height = 40 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "Madonna dell Granduca ", Method = "Oil on wood", Year = 1505, Width = 84, Height = 55 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "St. George Fighting the Dragon ", Method = "Oil on wood", Year = 1825, Width = 28, Height = 21 });
            paintings.Add(new Painting { Artist = "Munch", Title = "The Scream", Method = "Tempera on paper", Year = 1893, Width = 91, Height = 74 });
            paintings.Add(new Painting { Artist = "da Vinci", Title = "The Last Supper", Method = "Tempera on plaster", Year = 1498, Width = 460, Height = 880 });
            paintings.Add(new Painting { Artist = "Botticelli", Title = "The Birth of Venus", Method = "Tempera on canvas", Year = 1485, Width = 173, Height = 280 });
            paintings.Add(new Painting { Artist = "Matisse", Title = "La Musique", Method = "Oil on canvas", Year = 1939, Width = 115, Height = 115 });
            paintings.Add(new Painting { Artist = "Mondrian", Title = "Composition with Red, Yellow and Blue", Method = "Oil on canvas", Year = 1821, Width = 40, Height = 35 });
            paintings.Add(new Painting { Artist = "Pollock", Title = "The Key", Method = "Oil on canvas", Year = 1946, Width = 84, Height = 213 });
            paintings.Add(new Painting { Artist = "Picasso", Title = "The Three Musicians", Method = "Oil on canvas", Year = 1921, Width = 200, Height = 222 });



        }

        //------------------------------------------------------
        // btnAllPaintings
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            //Clear lb before update
            listBox1.Items.Clear();

            var allPaintings = from painting in paintings
                               select new { painting.Artist, painting.Title, painting.Year, painting.Method };

            foreach (var p in allPaintings)
            {
                listBox1.Items.Add(p.Artist + "\t\t" + p.Title + "\t\t" + p.Year + "\t\t" + p.Method);
            }
        }


        //------------------------------------------------------
        // btnArtistsFromItaly
        //------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear lb before update
            listBox1.Items.Clear();

            var italyArtists = from artist in artists
                               where String.Equals(artist.Country, "Italy")
                               select new { artist.FirstName, artist.LastName, artist.Country };

            foreach (var a in italyArtists)
            {
                listBox1.Items.Add(a.LastName + ", " + a.FirstName + "\t\t" + a.Country);
            }
        }

        //------------------------------------------------------
        // btnBefore1800
        //------------------------------------------------------
        private void btnBefore1800_Click(object sender, EventArgs e)
        {
            //Clear lb before update
            listBox1.Items.Clear();

            var pre1800 = from painting in paintings
                               where painting.Year < 1800
                               select new { painting.Title, painting.Year };

            foreach (var p in pre1800)
            {
                listBox1.Items.Add(p.Title + "\t\t" + p.Year);
            }
        }

        //------------------------------------------------------
        // btnOldest
        //------------------------------------------------------
        private void btnOldest_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var oldestPainting = from painting in paintings
                                 orderby painting.Year
                                 select new { painting.Title, painting.Year };

            foreach (var p in oldestPainting)
            {
                listBox1.Items.Add(p.Title + "\t\t" + p.Year);

                //Break loop early so it only outputs 1 result :^) Cheeky coders united.
                break;
            }
        }

        //------------------------------------------------------
        // byThisArtist
        //------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string uArtist = textBox1.Text;

            var oldestPainting = from painting in paintings
                                 where String.Equals(painting.Artist, uArtist)
                                 select new { painting.Title, painting.Year, painting.Artist };

            foreach (var p in oldestPainting)
            {
                listBox1.Items.Add(p.Title + "\t\t" + p.Year + "\t\t" + p.Artist);
            }
        }

        //------------------------------------------------------
        // btnNbyCountry
        //------------------------------------------------------
        private void btnNbyCountry_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //create a grouping for each country
            var countryJoinArtist = from p in paintings
                                    join a in artists
                                    on p.Artist equals a.LastName
                                    where p.Equals(p)
                                    group p by a.Country into cpaints
                                    select cpaints;

            //get country count
            var country = from c in countryJoinArtist
                          where c.Equals(c)
                          orderby c.Count()
                          select c;

            foreach (var cpaint in country)
            {
                int nPaintings = cpaint.Count();

                listBox1.Items.Add(cpaint.Key + ":\t" + nPaintings);
            }

        }

        //------------------------------------------------------
        // btnArtistGroupedByCountry
        //------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var artistGrouping = from a in artists
                                 where a.Equals(a)
                                 group a by a.Country;

            foreach (var a in artistGrouping)
            {
                listBox1.Items.Add(a.Key + ":");
                foreach (var artist in a)
                {
                    listBox1.Items.Add("\t" + artist.FirstName + " " + artist.LastName);
                }
            }
        }

        //------------------------------------------------------
        // btnDutchPainters
        //------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var artistGrouping = from a in artists
                                 where a.Country.Equals("Netherlands")
                                 group a by a.Country;

            foreach (var a in artistGrouping)
            {
                listBox1.Items.Add(a.Key + ":");
                foreach (var artist in a)
                {
                    listBox1.Items.Add("\t" + artist.FirstName + " " + artist.LastName);
                }
            }
        }

        //------------------------------------------------------
        // btnJoinTables
        //------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var joinAtoP = from p in paintings
                           join a in artists
                           on p.Artist equals a.LastName
                           select new { a.FirstName, a.LastName, a.Country, p.Title };

            foreach (var ap in joinAtoP)
            {
                string l = String.Format("{0,-10}{1,-20}\t{2,-20}\t{3}", ap.FirstName, ap.LastName, ap.Country, ap.Title);
                listBox1.Items.Add(l);
            }
        }

        //------------------------------------------------------
        // btnFrenchOrItalian
        //------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var joinAtoP = from p in paintings
                           join a in artists
                           on p.Artist equals a.LastName
                           where a.Country.Equals("Italy") || a.Country.Equals("France")
                           select new { a.FirstName, a.LastName, a.Country, p.Title };

            foreach (var ap in joinAtoP)
            {
                listBox1.Items.Add(ap.FirstName + " " + ap.LastName + "\t" + ap.Country + "\t" + ap.Title);
            }
        }

 
    }
}
