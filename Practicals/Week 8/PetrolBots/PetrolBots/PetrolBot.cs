using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    class PetrolBot
    {
        //Attributes of a petrol refueller bot
        Graphics parentCanvas;
        Color botColour;
        Point botCurrentLocation;
        Ship botShip; //The ship that the refueler bot is designated to refuel
        Point botStartingLocation; //Location on the main panel that the bot sits in waiting
        Point shipLocation; //The location of the tethered ship
        int botSize;

        //ctor
        public PetrolBot(Graphics parentCanvas, Color colour, Point startLoc, int botSize, Ship tetheredShip)
        {
            this.botSize = botSize;
            this.parentCanvas = parentCanvas;
            botStartingLocation = startLoc;
            botColour = colour;
            botShip = tetheredShip;
        }

        public void drawBot()
        {
            //Setup a brush of the bots colour
            SolidBrush botBrush = new SolidBrush(botColour);

            //Draw the rectangle to the form using the brush
            parentCanvas.FillEllipse(botBrush, botStartingLocation.X, botStartingLocation.Y, botSize, botSize);
        }

    }
}
