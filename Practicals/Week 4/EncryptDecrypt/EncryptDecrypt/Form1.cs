using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        //IEncrypt setup
        IEncrypt encryptor;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Act differently depending on which rdobtn is clicked
            if (rdoRev.Checked == true)
            {
                encryptor = new Reversal();
            }
            else
            {
                encryptor = new Rot13();
            }

            //Grab the string in the entry box
            String toEncrypt = txtEncString.Text;

            //Run toEncrypt through encryptor, and place the output in the output textbox
            txtOutput.Text =  encryptor.Encrypt(toEncrypt);
        }
    }
}
