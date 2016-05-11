using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropoutPrevention
{
    public partial class Form1 : Form
    {
        //Declare a database helper.
        DatabaseHelper dbHelper;
        public Form1()
        {
            InitializeComponent();

            //Having a database helper class decouples the UI from the code.
            dbHelper = new DatabaseHelper(lb);
        }

        private void btnShowPaper_Click(object sender, EventArgs e)
        {
            dbHelper.ShowPapers();
        }

    }
}
