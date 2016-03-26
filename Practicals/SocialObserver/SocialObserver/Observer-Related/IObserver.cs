using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialObserver
{
    public interface IObserver
    {
        //Declare standard observer methods
        void Update(string input);
        void Display();
    }
}
