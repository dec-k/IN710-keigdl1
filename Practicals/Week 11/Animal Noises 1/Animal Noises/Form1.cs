using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        //Instance of an animal
        private Animal mainAnimal;
        ThreadStart threadDelegate;
        Thread animalNoiseThread;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate the animal
            mainAnimal = new Animal();

            //Instantiate a thread start instance, providing it the signature of the method that will run in the seperate thread.
            threadDelegate = new ThreadStart(mainAnimal.speak);

            //Instantiate a thread, feeding it the above delegate.
            animalNoiseThread = new Thread(threadDelegate);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            //Start running the delegates code on a separate thread.
            animalNoiseThread.Start();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }


    }
}
