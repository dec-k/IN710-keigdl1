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

            //Add the new gig req'd for exercise 5
            addGig();
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
                string gigMonth = cGig.Element("Date").Attribute("month").Value.Trim();

                if (gigMonth.Equals(nowMonth))
                {
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
                    gridRow.Add(cGig.Element("Band").Element("Name").Value.Trim(),
                                cGig.Element("Band").Element("Genre").Value.Trim(),
                                cGig.Element("Venue").Value.Trim(),
                                cGig.Element("Date").Attribute("day").Value.Trim() + " - " + cGig.Element("Date").Attribute("month").Value.Trim() + " - " + cGig.Element("Date").Attribute("year").Value.Trim(),
                                cGig.Element("Time").Value.Trim());
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

        public void addGig()
        {
            //Declare new xElement
            XElement newGig = new XElement("Gig",
                                 new XElement("Venue", "My House"),
                                 new XElement("Date",
                                     new XAttribute("day", "12"), new XAttribute("month", "09"), new XAttribute("year", "2016")),
                                 new XElement("Time", "3:00am"),
                                 new XElement("Band",
                                     new XElement("Name", "Dredg"),
                                     new XElement("Genre", "Metal"),
                                     new XElement("Band_Members",
                                         new XElement("Member",
                                             new XElement("First_Name", "Gavin"),
                                             new XElement("Last_Name", "Hayes"),
                                             new XElement("Role", "Lead Guitarist"),
                                             new XElement("Instruments",
                                                 new XElement("Instrument", "Guitar"))),
                                         new XElement("Member",
                                             new XElement("First_Name", "Mark"),
                                             new XElement("Last_Name", "Engles"),
                                             new XElement("Role", "Vocals & Guitar"),
                                             new XElement("Instruments",
                                                 new XElement("Instrument", "Guitar"))))));

            //Add new gig to gigdoc
            gigDoc.Element("Event_Guide").Add(newGig);
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
