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
        int botSize;

        //ctor
        public PetrolBot(Graphics parentCanvas, Color colour, Point startLoc, int botSize, Ship tetheredShip)
        {
            this.botSize = botSize;
            this.parentCanvas = parentCanvas;
            botColour = colour;
            botShip = tetheredShip;

            //Set the starting location  & the current location as the initially passed in location.
            botStartingLocation = startLoc; //This will not change
            botCurrentLocation = botStartingLocation; //This will change a lot.

            //Bind event handler
            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandler);
            botShip.OutOfFuelEvent += outOfFuelHandler;

            Ship.FullOfFuelEventHandler fullOfFuelHandler = new Ship.FullOfFuelEventHandler(FullOfFuelEventHandler);
            botShip.FullOfFuelEvent += fullOfFuelHandler;
        }

        public void drawBot()
        {
            //Setup a brush of the bots colour
            SolidBrush botBrush = new SolidBrush(botColour);

            //Draw the rectangle to the form using the brush
            parentCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, botSize, botSize);
        }

        //Help from Leonard on basics of using this method,
        //Then found out how to write it as an async method.
        public void OutOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            botCurrentLocation = botShip.ShipLocation;

            botShip.refuel();
        }

        public void FullOfFuelEventHandler(object ship, ShipEventArgs shipArgs)
        {
            botCurrentLocation = botStartingLocation;
        }
    }
}
