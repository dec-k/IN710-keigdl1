using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalDatabaseLightning
{
    public partial class Form1 : Form
    {
        //Db context instance
        FireStrikeDbDataContext db;

        public Form1()
        {
            InitializeComponent();
            //Initialise the external db instance
            db = new FireStrikeDbDataContext();
        }

        //Average strike intensity
        private void button1_Click(object sender, EventArgs e)
        {
            //Create a variable that stores a query result
            var avgIntensity = db.tblStrikes.Average(s => s.strikeIntensity);

            //Add intensity reading to the listbox
            listBox1.Items.Add("Average lightning strike intensity is: " + avgIntensity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Select only the top 3 fires by area, order in descending from hi->lo
            var topFires = db.tblFires.Select(f => f)
                                      .OrderByDescending(f => f.fireArea)
                                      .Take(3);

            foreach (var f in topFires)
            {
                listBox1.Items.Add("-----------");
                listBox1.Items.Add("Area: " + f.fireArea);
                listBox1.Items.Add("Position: " + f.fireLatitude + ", " + f.fireLongitude);
            }
        }
    }
}
