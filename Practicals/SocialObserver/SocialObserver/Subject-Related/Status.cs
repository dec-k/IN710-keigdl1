using SocialObserver.Observer_Related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialObserver.Subject_Related
{
    public class Status : ISubject
    {
        //Subject class attr
        private List<IObserver> obsList;
        private string statusText;
        private DateTime statusTimestamp;

        //Accessor/Mutator for statusText
        public string StatusText
        {
            get { return statusText; }
            set { statusText = value; }
        }

        //Ctor
        public Status()
        {
            //Instantiate the values a status needs
            obsList = new List<IObserver>();
            statusText = "";
            statusTimestamp = DateTime.Now;

        }
        public void AddObserver(IObserver o)
        {
            obsList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            obsList.Remove(o);
        }

        public void NotifyObservers()
        {
            //Alert all observers that they will need to update their information
            foreach (StatusObserver obs in obsList)
            {
                obs.Update(statusText,statusTimestamp);
                obs.Display();
            }
        }
    }
}
