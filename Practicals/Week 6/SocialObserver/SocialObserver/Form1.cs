﻿using SocialObserver.Observer_Related;
using SocialObserver.Subject_Related;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialObserver
{
    public partial class Form1 : Form
    {
        //Declare empty instances of observers and their subject
        Status subject;
        StatusObserver sOb;

        //You only really need 1 and then I could just update multiple listboxes but I feel that
        //defeats the point of the exercise
        FriendStatusObserver fsOb1;
        FriendStatusObserver fsOb2;
        FriendStatusObserver fsOb3;
        
        public Form1()
        {
            InitializeComponent();

            //Fully instantiate above objects
            subject = new Status();
            sOb = new StatusObserver(lbMine, subject);
            fsOb1 = new FriendStatusObserver(lbF1, subject);
            fsOb2 = new FriendStatusObserver(lbF2, subject);
            fsOb3 = new FriendStatusObserver(lbF3, subject);
        }

        private void UpdateFields()
        {
            //Again, this should probably be in its own class. I think.
            subject.StatusText = txtStatus.Text;
            
            //Notify obs
            subject.NotifyObservers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateFields();
        }
    }
}
