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

        public Form1()
        {
            InitializeComponent();

            //Read in xml from file
            gigDoc = XDocument.Load("pubsAndClubs.xml");
            gridRow = dgvGigs.Rows;

            //Debug: just seeing how gridrows work
            gridRow.Add(gigDoc.Element("Name"));
            gridRow.Add("test");
        }

        public void showAllGigs()
        {
            //Clear dgv row before use
            gridRow.Clear();

            foreach (XElement cGig in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                //Maybe a gig class would be good here...
                gridRow.Add(cGig.Element("Band").Element("Name").Value,
                            cGig.Element("Band").Element("Genre").Value,
                            cGig.Element("Venue").Value,
                            cGig.Element("Date").Attribute("day").Value + " - " + cGig.Element("Date").Attribute("month").Value + " - " +cGig.Element("Date").Attribute("year").Value,
                            cGig.Element("Time").Value);
            }
        }

        private void btnAllGigs_Click(object sender, EventArgs e)
        {
            showAllGigs();
        }
    }
}
