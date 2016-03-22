using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikesSubObs
{
    public class Subject : ISubject
    {
        //Properties
        protected List<IObserver> observerList;
        protected int currentRPM;

        public int CurrentRPM
        {
            get { return currentRPM; }
            set { currentRPM = value; }
        }

        //Ctor
        public Subject()
        {
            //Init the list
            observerList = new List<IObserver>();
            currentRPM = 0;
        }

        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (BicycleObserver currentObserver in observerList)
            {
                currentObserver.Update(currentRPM);
                currentObserver.Display();
            }
        }
    }
}
