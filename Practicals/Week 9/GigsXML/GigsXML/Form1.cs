using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GigsXML
{
    public partial class Form1 : Form
    {
        //XML Document declaration & loading
        XDocument gigDoc;
        DataGridViewRowCollection gridRow;
        DataGridViewRowCollection gridRow2;

        public Form1()
        {
            InitializeComponent();

            //Read in xml from file
            gigDoc = XDocument.Load("pubsAndClubs.xml");
            gridRow = dgvGigs.Rows;
            gridRow2 = dgvBand.Rows;
        }

        public void showGigsThisMonth()
        {
            //Get current date at method called
            DateTime now = DateTime.Now;
            //Format month as 2 digit version "04".
            string nowMonth = now.ToString("MM");

            

            foreach (XElement cGig in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                //month from xml
                string gigMonth = cGig.Element("Band").Element("Date").Attribute("month").Value;

                if (gigMonth.Equals(nowMonth))
                {
                    //Maybe a gig class would be good.
                    gridRow.Add(cGig.Element("Band").Element("Name").Value,
                                cGig.Element("Band").Element("Genre").Value,
                                cGig.Element("Venue").Value,
                                cGig.Element("Date").Attribute("day").Value + " - " + cGig.Element("Date").Attribute("month").Value + " - " + cGig.Element("Date").Attribute("year").Value,
                                cGig.Element("Time").Value);
                }
            }
        }

        public void showAllGigs()
        {
            //Clear dgv row before use
            gridRow.Clear();

            foreach (XElement cGig in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                //Maybe a gig class would be good.
                gridRow.Add(cGig.Element("Band").Element("Name").Value.Trim(),
                            cGig.Element("Band").Element("Genre").Value.Trim(),
                            cGig.Element("Venue").Value.Trim(),
                            cGig.Element("Date").Attribute("day").Value.Trim() + " - " + cGig.Element("Date").Attribute("month").Value.Trim() + " - " + cGig.Element("Date").Attribute("year").Value.Trim(),
                            cGig.Element("Time").Value.Trim());
            }
        }

        public void showHardRockGigs()
        {
            //Clear dgv row before use
            gridRow.Clear();

            foreach (XElement cGig in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                if ((cGig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock")))
                {
                    //Maybe a gig class would be good.
                    gridRow.Add(cGig.Element("Band").Element("Name").Value,
                                cGig.Element("Band").Element("Genre").Value,
                                cGig.Element("Venue").Value,
                                cGig.Element("Date").Attribute("day").Value + " - " + cGig.Element("Date").Attribute("month").Value + " - " + cGig.Element("Date").Attribute("year").Value,
                                cGig.Element("Time").Value);
                }
            }
        }

        public void showBandMembers()
        {
            //Clear dgv row before use
            gridRow2.Clear();

            
            foreach (XElement cBand in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                if (cBand.Element("Band").Element("Name").Value.Trim() == "Alabama Shakes")
                {
                    //Check if the band member has a role
                    var foundRole = cBand.Element("Band").Element("Band_Members").Element("Member").Element("Role");

                    if (foundRole != null)
                    {
                        //Has a role
                        gridRow2.Add(cBand.Element("Band").Element("Band_Members").Element("Member").Element("First_Name").Value.Trim() + " " +
                                     cBand.Element("Band").Element("Band_Members").Element("Member").Element("Last_Name").Value.Trim(),
                                     cBand.Element("Band").Element("Band_Members").Element("Member").Element("Role").Value.Trim(),
                                     cBand.Element("Band").Element("Band_Members").Element("Member").Element("Instruments").Value.Trim());
                    }
                    else
                    {
                        //Has no defined role
                        gridRow2.Add(cBand.Element("Band").Element("Band_Members").Element("Member").Element("First_Name").Value.Trim() + " " +
                                     cBand.Element("Band").Element("Band_Members").Element("Member").Element("Last_Name").Value.Trim(),
                                     cBand.Element("Band").Element("Band_Members").Element("Member").Element("Instruments").Value.Trim());
                    }
                }
            }
        }

        private void btnAllGigs_Click(object sender, EventArgs e)
        {
            showAllGigs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showHardRockGigs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showBandMembers();
        }

        private void dgvBand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showGigsThisMonth();
        }
    }
}
