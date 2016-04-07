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
        Point shipLocation;
        Color shipColour;


        public Ship(int shipSize, Graphics parentCanvas)
        {
            this.shipSize = shipSize;
            this.parentCanvas = parentCanvas;

            //Give initial amount of fuel
            petrol = 50;

            //Give position
            shipLocation = new Point(50, 50);
            //Give black as starting colour
            shipColour = Color.FromArgb(0, 0, 0);
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
    }
}
