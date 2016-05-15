using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private bool playing = false;

        //Accessor for playing boolean
        public bool Playing
        {
            get { return playing; }
            set { playing = value; }
        }

        public Animal()
        {
            soundPlayer = new SoundPlayer("frog.wav");
        }

        public void speak()
        {
            while (playing)
            {
                soundPlayer.Play();
                Thread.Sleep(1000);
            }
        }

    }
}
