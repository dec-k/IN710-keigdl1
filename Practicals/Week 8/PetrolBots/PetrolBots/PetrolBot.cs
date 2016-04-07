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
            botCurrentLocation = botStartingLocation;
            botColour = colour;
            botShip = tetheredShip;

            //Bind event handler
            Ship.FuelEventHandler handler = new Ship.FuelEventHandler(OutOfFuelEventHandler);
            botShip.OutOfFuelEvent += handler;
        }

        public void drawBot()
        {
            //Setup a brush of the bots colour
            SolidBrush botBrush = new SolidBrush(botColour);

            //Draw the rectangle to the form using the brush
            parentCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, botSize, botSize);
        }

        //event handlers
        public void FullOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            
        }

        //Help from Leonard on where to place this method.
        public async void OutOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            if (botShip.Petrol == 0)
            {
                botShip.State = EShipState.REFUELING;

                botCurrentLocation.X = botShip.ShipLocation.X;
                botCurrentLocation.Y = botShip.ShipLocation.Y;


                while (botShip.Petrol < 100)
                {
                    botShip.Petrol++;
                    await Task.Delay(100);
                }

                botShip.State = EShipState.WANDERING;
                
            }

            botCurrentLocation.X = botStartingLocation.X;
            botCurrentLocation.Y = botStartingLocation.Y;
        }

    }
}
