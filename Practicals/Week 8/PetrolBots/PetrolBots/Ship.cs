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
        int petrol { get; set; } //makes this var modifiable elsewhere
        Random r = new Random();
        int shipSize;
        Graphics parentCanvas;

        //Access values using name.X/Y
        Point shipLocation;
        Color shipColour;
        Point shipVelocity;


        public Ship(int shipSize, Graphics parentCanvas)
        {
            this.shipSize = shipSize;
            this.parentCanvas = parentCanvas;

            //Give initial amount of fuel (at least half full)
            petrol = r.Next(50, 100);

            //Give position
            shipLocation = new Point(r.Next(100,300),r.Next(100,300));
            //Give black as starting colour
            shipColour = Color.FromArgb(0, 0, 0);
            //Set ship velocity
            shipVelocity = new Point(r.Next(1,5), r.Next(1,5));
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
            //If the ship moves too far along either axis, it's velocity for that direction will be flipped.
            if (shipLocation.X >= (500 - shipSize) || (shipLocation.X <= 0))
            {
                shipVelocity.X = shipVelocity.X - (shipVelocity.X * 2);
            }
            if (shipLocation.Y >= (400 - shipSize) || shipLocation.Y <= 0)
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
            if (petrol != 0)
            {
                petrol--;
            }
        }
    }
}
