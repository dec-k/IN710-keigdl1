using SocialObserver.Subject_Related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialObserver.Observer_Related
{
    public class FriendStatusObserver : StatusObserver
    {
        //Ctor
        public FriendStatusObserver(ListBox lb, Status st)
            : base(lb, st)
        {
            //Ain't nothin' here sir. No siree.
        }

        //Override display method from parent
        public override void Display()
        {
            //Add items to listbox, will accumulate over time
            lb.Items.Add("Time of Post: " + statusTimestamp);
            lb.Items.Add(" \" " + statusText + " \" ");
        }

    }
}
