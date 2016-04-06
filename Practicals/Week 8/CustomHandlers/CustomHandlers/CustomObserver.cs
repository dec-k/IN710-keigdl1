using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomHandlers
{
    class CustomObserver
    {
        //attr
        int code; //This variable replicates functionality seen in the demo, just assigns a code to each listener.
        Button senderButton; //Button that called this custom listener

        //ctor
        public CustomObserver(int code, Button senderButton)
        {
            this.code = code;
            this.senderButton = senderButton;

            //Create a handler set to run the custom event
            EventHandler handler = new EventHandler(CustomButtonHandler);

            //Bind that handler to the instance of button used to get to this ctor
            senderButton.Click += handler;
        }

        public void CustomButtonHandler(object obj, EventArgs e)
        {
            //Use a stringbuilder to build a multi-line string instead of several different variables
            //Just playing around here.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("I'm a custom handler.");
            sb.AppendLine("I am of type: " + this.GetType().ToString());
            sb.AppendLine("My code is: " + code);

            MessageBox.Show(sb.ToString());
        }
    }
}
