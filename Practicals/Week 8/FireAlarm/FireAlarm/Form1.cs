using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        //Declare things we need
        EFireCategory currentFire;
        FireAlarmSubject fas;
        InstructionsObserver io;

        public Form1()
        {
            InitializeComponent();

            //Instantiate objects
            fas = new FireAlarmSubject();
            io = new InstructionsObserver(fas);

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (rdoMinor.Checked)
            {
                currentFire = EFireCategory.MINOR;
            }
            else if (rdoSerious.Checked)
            {
                currentFire = EFireCategory.SERIOUS;
            }
            else
            {
                currentFire = EFireCategory.INFERNO;
            }

            fas.OnFireEvent(currentFire);
        }
    }
}
