﻿using SocialObserver.Subject_Related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialObserver.Observer_Related
{
    public class StatusObserver : IObserver
    {
        //Hybrid class, a parent and an instantiated class
        //Attr
        protected string statusText;
        protected DateTime statusTimestamp;

        //Form hooks
        protected ListBox lb;
        protected Status st;

        //Ctor
        public StatusObserver(ListBox lb, Status st)
        {
            //Init attr
            statusText = "";
            statusTimestamp = DateTime.Now;

            //Bind form control to local var
            this.lb = lb;

            //Add itself to the obs list
            st.AddObserver(this);
        }
        public void Update(string passedStatus)
        {
            //Set this instances attributes to equal those of the values passed in through arguments
            statusText = passedStatus;

            //Update timestamp to be set to when the main observer initially clicked update status.
            statusTimestamp = DateTime.Now;
        }

        //Method that can be overwritten,
        //In this case, it is overwritten for classes where the timestamp field is also required as an output.
        public virtual void Display()
        {
            //Add items to listbox, will accumulate over time
            lb.Items.Add(" \"" + statusText + "\"");
        }
    }
}
