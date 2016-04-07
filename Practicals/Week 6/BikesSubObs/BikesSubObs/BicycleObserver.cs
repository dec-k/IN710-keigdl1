using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BikesSubObs
{
    public abstract class BicycleObserver : IObserver
    {
        //Attr
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected Subject bikeSubject;

        //Ctor
        public BicycleObserver(Label displayLabel, Subject bikeSubject)
        {
            this.displayLabel = displayLabel;

            currentRPM = 0;
            currentComputedValue = 0;
            this.bikeSubject = bikeSubject;

            //Observer adds itself to its parents list
            bikeSubject.AddObserver(this);
        }

        //Methods
        public abstract void Update(int currentRPM);

        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }

    }
