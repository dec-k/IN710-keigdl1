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

        //Help from Leonard on basics of using this method,
        //Then found out how to write it as an async method.
        public async void OutOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            //This event will fire if this condition is met, that is, if the bots assigned ship has run out of fuel.
            if (botShip.Petrol == 0)
            {
                //Shift the boat into refueling state so it ceases movement
                botShip.State = EShipState.REFUELING;

                //Set the petrolBots location to match the boats.
                botCurrentLocation.X = botShip.ShipLocation.X;
                botCurrentLocation.Y = botShip.ShipLocation.Y;

                //Continue looping and increasing the boats petrol value until it reaches 100.
                //Note: This is coupled and should in
                while (botShip.Petrol < 100)
                {
                    //Call the ships refuel method, its literally 1 line that increments fuel.
                    botShip.refuel();

                    //Delay processing in this loop by 100ms. Only affects this thread of processing, unlike Sleep().
                    await Task.Delay(50);
                }

                //After refueling done, set state back to wander.
                botShip.State = EShipState.WANDERING;

                //Clean up location of fuel bot after a hard days work.
                botCurrentLocation.X = botStartingLocation.X;
                botCurrentLocation.Y = botStartingLocation.Y;
                
            }
        }

    }
}
