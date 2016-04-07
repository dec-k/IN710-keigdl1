using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{
    public partial class Form1 : Form
    {
        //Constant for ship size
        public const int SHIP_SIZE = 50;
        public const int BOT_SIZE = 10;

        //Attr
        Graphics mainCanvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        Random r;


        //Canvas bg colour
        Brush backgroundBrush;
        Brush foregroundPanelBrush;

        public Form1()
        {
            InitializeComponent();

            //Init things
            mainCanvas = CreateGraphics();
            backgroundBrush = new SolidBrush(Color.LightBlue);
            foregroundPanelBrush = new SolidBrush(Color.Black);
            
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();

            r = new Random();

            //Instantiate some ships
            Ship s1 = new Ship(SHIP_SIZE, mainCanvas,r);
            Ship s2 = new Ship(SHIP_SIZE, mainCanvas,r);
            Ship s3 = new Ship(SHIP_SIZE, mainCanvas,r);
            Ship s4 = new Ship(SHIP_SIZE, mainCanvas,r);
            Ship s5 = new Ship(SHIP_SIZE, mainCanvas,r);

            //Add ships to the list
            shipList.Add(s1);
            shipList.Add(s2);
            shipList.Add(s3);
            shipList.Add(s4);
            shipList.Add(s5);

            //Instantiate some petrolBots
            PetrolBot pb1 = new PetrolBot(mainCanvas, Color.Lime, new Point(25, 425), BOT_SIZE, s1);
            PetrolBot pb2 = new PetrolBot(mainCanvas, Color.Orange, new Point(75, 425), BOT_SIZE,s2);
            PetrolBot pb3 = new PetrolBot(mainCanvas, Color.Purple, new Point(125, 425), BOT_SIZE,s3);
            PetrolBot pb4 = new PetrolBot(mainCanvas, Color.Teal, new Point(175, 425), BOT_SIZE,s4);
            PetrolBot pb5 = new PetrolBot(mainCanvas, Color.Yellow, new Point(225, 425), BOT_SIZE,s5);

            //Add bot to its list
            botList.Add(pb1);
            botList.Add(pb2);
            botList.Add(pb3);
            botList.Add(pb4);
            botList.Add(pb5);
        }

        public void updateDisplay()
        {
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, 500, 500);
            mainCanvas.FillRectangle(foregroundPanelBrush, 0, 400, 500, 100);
            
            //Move & redraw all ships in the list
            for (int i = 0; i < shipList.Count; i++)
            {
                shipList[i].moveShip();
                shipList[i].drawShip();
            }

            //Move & redraw all bots
            for (int i = 0; i < botList.Count; i++)
            {
                botList[i].drawBot();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
