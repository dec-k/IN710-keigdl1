﻿using System;
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

        public void resetLb(ListBox l){
            l.Items.Clear();
        }


        //Average strike intensity
        private void button1_Click(object sender, EventArgs e)
        {
            resetLb(listBox1);

            IEnumerable<int> intensities = from strike in db.tblStrikes
                                           select strike.strikeIntensity;

            double averageIntensity = intensities.Average();
            listBox1.Items.Add(averageIntensity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetLb(listBox1);
            //Select only the top 3 fires by area, order in descending from hi->lo
            var topFires = db.tblFires.Select(f => f)
                                      .OrderByDescending(f => f.fireArea)
                                      .Take(3);

            foreach (var f in topFires)
            {
                listBox1.Items.Add("-----------");
                listBox1.Items.Add("Fire ID: " + f.fireID);
                listBox1.Items.Add("Date: " + f.fireDate);
                listBox1.Items.Add("Area: " + f.fireArea);
                listBox1.Items.Add("Position: " + f.fireLatitude + ", " + f.fireLongitude);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetLb(listBox1);

            var picDetail = from strike in db.tblStrikes
                            join picture in db.tblPictures on strike.strikeID equals picture.strikeID
                            select new { strike.strikeLatitude, strike.strikeLongitude, picture.pictureFileName };

            foreach (var pic in picDetail)
            {
                listBox1.Items.Add("Lat: " + pic.strikeLatitude +
                                   ", Lng: " + pic.strikeLongitude +
                                   ", Url: " + pic.pictureFileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetLb(listBox1);

            var fireByStrike = from strike in db.tblStrikes
                             from fire in db.tblFires
                             where strike.strikeDate == fire.fireDate
                             && strike.strikeLatitude == fire.fireLatitude
                             && strike.strikeLongitude == fire.fireLongitude
                             select fire;

            foreach (var f in fireByStrike)
            {
                listBox1.Items.Add("-----------");
                listBox1.Items.Add("Fire ID: " + f.fireID);
                listBox1.Items.Add("Date: " + f.fireDate);
                listBox1.Items.Add("Area: " + f.fireArea);
                listBox1.Items.Add("Position: " + f.fireLatitude + ", " + f.fireLongitude);
            }
        }
    }
}
