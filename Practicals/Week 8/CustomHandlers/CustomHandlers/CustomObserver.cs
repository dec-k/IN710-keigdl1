using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHandlers
{
    class CustomObserver
    {
        //attr
        int code; //This variable replicates functionality seen in the demo, just assigns a code to each listener.

        //ctor
        public CustomObserver(int code)
        {
            this.code = code;

            EventHandler handler = new EventHandler(CustomButtonHandler);
        }

        public void CustomButtonHandler(object obj, EventArgs e)
        {
            //Use a stringbuilder to build a multi-line string instead of several different variables
            //Just playing around here.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("I'm a custom handler.");
            sb.AppendLine("I am of type: " + this.GetType().ToString());
            sb.AppendLine("My code is: " + code);
        }
    }
}
