using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogDigital
{
    interface IClock
    {
        void On();
        void Off();
        void Update();
        void Show();
        void Hide();

    }
}
