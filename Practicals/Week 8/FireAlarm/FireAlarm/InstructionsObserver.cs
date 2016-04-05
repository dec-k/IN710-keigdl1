using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    class InstructionsObserver : FireAlarmObserverBase
    {
        //Blank ctor
        public InstructionsObserver(FireAlarmSubject subject)
            : base(subject)
        {

        }

        //Override the base classes method with this one.
        public override void FireAlarmEventHandler(object fireSubject, FireAlarmEventArgs fe)
        {
            String result = "Fire is " + fe.FireCategory.ToString() + ".";

            //Switch on the fire category. This is possible due to having an enum.
            switch (fe.FireCategory)
            {
                //Case determines which text is appended to the end of the string
                case EFireCategory.MINOR:
                    result += "Use a fire extinguisher.";
                    break;
                case EFireCategory.SERIOUS:
                    result += "Call the Fire Department.";
                    break;
                case EFireCategory.INFERNO:
                    result += "IT'S OVER THERE IS NO HOPE";
                    break;
            }

            MessageBox.Show(result);
        }
    }
}
