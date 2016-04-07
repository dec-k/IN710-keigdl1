﻿using System;
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

            //Create bounding rectangle
            Rectangle bounds = new Rectangle(0, 0, Width, HEIGHT_MINUS_BOTBAR);

            //test drawing rect to canvas
            Ship test1 = new Ship(SHIP_SIZE, mainCanvas);
            shipList.Add(test1);
            testUpdate();
        }

        public void testUpdate()
        {
            mainCanvas.FillRectangle(backgroundBrush, 0, 0, Width, Height);
            shipList[0].drawShip();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            testUpdate();
        }
    }
}
