using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    //Enum that contains the possibly selectable fire types
    public enum EFireCategory { MINOR, SERIOUS, INFERNO };

    class FireAlarmEventArgs : EventArgs //Extend event args, so we can have an eventArg that can contain some data.
    {
        //Enumerator get/set - im still used to doing this the 'bloatier' way.
        public EFireCategory FireCategory { get; set; }

        //ctor
        public FireAlarmEventArgs(EFireCategory currentFireCategory)
        {
            FireCategory = currentFireCategory;
        }
    }
}
