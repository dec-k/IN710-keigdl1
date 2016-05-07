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
            var strikes = from s in db.tblStrikes
                          select s;

            foreach (var s in strikes)
            {
                listBox1.Items.Add(s.strikeIntensity);
            }
        }
    }
}
