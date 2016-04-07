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

        //Attr
        Graphics mainCanvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        int numShips;

        public Form1()
        {
            InitializeComponent();

            //Init things
            mainCanvas = CreateGraphics();
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();

            //Create bounding rectangle
            Rectangle bounds = new Rectangle(0, 0, Width, Height);

            //test drawing rect to canvas
            shipList.Add(new Ship(SHIP_SIZE, mainCanvas));
            shipList[0].drawShip();

        }
    }
}
