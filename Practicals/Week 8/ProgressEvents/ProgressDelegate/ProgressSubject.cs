using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressDelegate
{
    class ProgressSubject
    {
        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }

        private void OnUpdateEvent()
        {
            throw new NotImplementedException();
        }
    }
}
