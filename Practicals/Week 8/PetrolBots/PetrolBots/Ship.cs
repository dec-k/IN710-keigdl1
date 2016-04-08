using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    class Ship
    {
        //Ship Attr Declaration
        int petrol;
        int shipSize;
        Random r;
        Graphics parentCanvas;
        EShipState state;

        //Access values using name.X/Y
        Point shipLocation;
        Point shipVelocity;
        Color shipColour;

        //Properties
        public int Petrol
        {
            get { return petrol; }
            set { petrol = value; }
        }
        public Point ShipLocation
        {
            get { return shipLocation; }
            set { shipLocation = value; }
        }
        public EShipState State
        {
            get { return state; }
            set { state = value; }
        }

        //custom delegate and events
        public delegate void OutOfFuelEventHandler(object ship, ShipEventArgs shipArgs);
        public event OutOfFuelEventHandler OutOfFuelEvent;

        public delegate void FullOfFuelEventHandler(object ship, ShipEventArgs shipArgs);
        public event FullOfFuelEventHandler FullOfFuelEvent; 

        public Ship(int shipSize, Graphics parentCanvas, Random r)
        {
            //Pass in random from the form to ensure proper seed generation
            this.r = r;

            //put ship into wanderer state on create
            state = EShipState.WANDERING;
            
            this.shipSize = shipSize;
            this.parentCanvas = parentCanvas;

            //Give initial amount of fuel (at least half full)
            petrol = r.Next(50, 100);

            //Give position
            shipLocation = new Point(r.Next(0, 395), r.Next(0, 300));

            //Give black as starting colour
            shipColour = Color.FromArgb(0, 0, 0);

            //Set ship velocity
            shipVelocity = new Point(r.Next(-3,3), r.Next(-3,3));
        }

        public void drawShip()
        {
            //Determine what shade of red to draw the ship as
            double petrolRatio = petrol / 100.0;
            double redVal = 255 * petrolRatio;

            //Update the ships colour to match it's fuel level
            shipColour = Color.FromArgb((int)redVal, 0, 0);

            //Setup a brush of the above colour
            SolidBrush shipBrush = new SolidBrush(shipColour);

            //Draw the rectangle to the form using the brush
            parentCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }

        public void moveShip()
        {
                //If the ship moves too far along either axis, it's velocity for that axis will be flipped.
                if (shipLocation.X >= (500 - shipSize*2) || (shipLocation.X <= 1))
                {
                    shipVelocity.X = shipVelocity.X - (shipVelocity.X * 2);
                }
                if (shipLocation.Y >= (399 - shipSize) || shipLocation.Y <= 1)
                {
                    shipVelocity.Y = shipVelocity.Y - (shipVelocity.Y * 2);
                }

                //Adjust position by velocity values
                shipLocation.X = shipLocation.X + shipVelocity.X;
                shipLocation.Y = shipLocation.Y + shipVelocity.Y;

                //consume a bit of fuel
                usePetrol();
        }

        public void usePetrol()
        {
                petrol--;

        }

        public void ShipCycle()
        {
            if (petrol == 100)
            {
                state = EShipState.WANDERING;
                OnFullOfFuelEvent();
            }

            if (petrol == 0)
                state = EShipState.REFUELING;

            if (state == EShipState.WANDERING)
            {
                drawShip();
                moveShip();
            }
            else
            {
                drawShip();
                OnOutOfFuelEvent();
            }

        }

        public void OnFullOfFuelEvent()
        {
            ShipEventArgs shipArgs = new ShipEventArgs(state);

            if (FullOfFuelEvent != null)
                FullOfFuelEvent(this, shipArgs);
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs shipArgs = new ShipEventArgs(state);

            if (OutOfFuelEvent != null)
                OutOfFuelEvent(this, shipArgs);
        } 

        public void refuel()
        {
            while (petrol < 100)
            {
                //increase petrol
                petrol++;
            }
        }
    }
}
