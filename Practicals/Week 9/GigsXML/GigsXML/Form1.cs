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

        public Form1()
        {
            InitializeComponent();

            gigDoc = XDocument.Load("pubsAndClubs.xml");
        }
    }
}
