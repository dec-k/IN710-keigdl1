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
        public const int HEIGHT_MINUS_BOTBAR = 100;

        //Attr
        Graphics mainCanvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        int numShips;

        //Canvas bg colour
        Brush backgroundBrush;

        public Form1()
        {
            InitializeComponent();

            //Init things
            mainCanvas = CreateGraphics();
            backgroundBrush = new SolidBrush(Color.White);
            
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();

            //Create boundary rect
            Rectangle bounds = new Rectangle(0, 0, Width, HEIGHT_MINUS_BOTBAR);

            //Instantiate some ships
            Ship s1 = new Ship(SHIP_SIZE, mainCanvas);
            Ship s2 = new Ship(SHIP_SIZE, mainCanvas);
            Ship s3 = new Ship(SHIP_SIZE, mainCanvas);
            Ship s4 = new Ship(SHIP_SIZE, mainCanvas);
            Ship s5 = new Ship(SHIP_SIZE, mainCanvas);

            //Add ships to the list
            shipList.Add(s1);
            shipList.Add(s2);
            shipList.Add(s3);
            shipList.Add(s4);
            shipList.Add(s5);
        }

        public void updateDisplay()
        {
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, Width, Height);
            
            //Move & redraw all ships in the list
            for (int i = 0; i < shipList.Count; i++)
            {
                shipList[i].moveShip();
                shipList[i].drawShip();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
