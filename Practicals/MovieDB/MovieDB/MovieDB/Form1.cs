using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form1 : Form
    {
        //Create an instance of MovieDB
        MovieDB movDB = new MovieDB();

        public Form1()
        {
            InitializeComponent();

            //Run movieDB's createDefaults method to populate the instance with dummy data.
            movDB.addDefaultFilms();
        }

        private void button1_Click(object sender, EventArgs e) //Not sure why this says button1, its clearly been renamed in the form.
        {
            //If any required fields havent been filled, chuck an error message and do not add entry to dictionary.
            //For real simple checks like this it seems easier to just do an if statement. Multiple try-catches destroy my code elegance :(
            if (txtAddYear.Text == "" || txtAddDirector.Text == "" || txtAddTitle.Text == "")
            {
                MessageBox.Show("You have provided incorrect information for one or more fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Pull values from Year, Title, and Director textboxes.
                int key = Convert.ToInt16(txtAddYear.Text);
                string title = txtAddTitle.Text;
                string director = txtAddDirector.Text;

                //Concat these strings into something the movie dictionary can work with
                Movie newMovie = new Movie(key, title, director);

                //Make sure user doesn't enter a key that's already been used for another entry.
                //Not a critical error, no cleanup code required.
                try
                {
                    //Add it to the dictionary.
                    movDB.MovieTable.Add(key, newMovie);
                }
                catch(ArgumentException)
                {
                    MessageBox.Show("This year already has an entry. Please remove this years entry before adding another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            //Clear listbox so it doesnt clutter up with multiple clicks.
            lbShowAll.Items.Clear();

            //Load up the box with every kvp in the MovieDB's dictionary.
            foreach(KeyValuePair<int,Movie> currentMovie in movDB.MovieTable){
                lbShowAll.Items.Add("--------------------------------------");
                lbShowAll.Items.Add(currentMovie.Key.ToString());
                lbShowAll.Items.Add(currentMovie.Value.ToString());
            }
        }

        private void btnDelMovie_Click(object sender, EventArgs e)
        {
            //Exception handler for when user enters a non-numeric key in the field.
            try
            {
                //Remove a kvp from the dictionary based on the relevant textfield.
                movDB.MovieTable.Remove(Convert.ToInt16(txtDeleteYear.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("Please ensure you have entered a year correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Reset the textboxes value to nothing.
                txtDeleteYear.ResetText();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Exception handler for when user enters a non-numeric key in the field.
            try
            {
                //Attempt to find the requested key value inside the dictionary.
                //Opted not to use the "safer" method for clarity reasons.
                int key = Convert.ToInt32(txtSearchYear.Text);
                Movie selectedMovie = movDB.MovieTable[key];
                if (movDB.MovieTable.ContainsKey(key))
                {
                    MessageBox.Show("'" + selectedMovie.ToString() + "'"  + " was the movie for the entered year.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(key.ToString() + " not found.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure you have entered a year correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Reset the textboxes value to nothing.
                txtDeleteYear.ResetText();
            }
        }
    }
}
