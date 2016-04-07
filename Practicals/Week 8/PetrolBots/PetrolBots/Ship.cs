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


        public Ship(int shipSize, Graphics parentCanvas)
        {
            this.shipSize = shipSize;
            this.parentCanvas = parentCanvas;
        }

        public void drawShip()
        {
            //Brush
            Brush backgroundBrush = new SolidBrush(Color.Black);
            Rectangle shipRect = new Rectangle(50,50,shipSize,shipSize);
            parentCanvas.FillRectangle(backgroundBrush, shipRect);
        }
    }
}
