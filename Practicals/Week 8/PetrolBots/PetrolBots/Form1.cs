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

        public Form1()
        {
            InitializeComponent();

            //Init things
            mainCanvas = CreateGraphics();
            botList = new List<PetrolBot>();

            //Create bounding rectangle
            Rectangle bounds = new Rectangle(0, 0, Width, Height);

        }
    }
}
