using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_With_Classes
{
    internal class CarEngine
    {
        bool IsOn;
        public CarEngine() 
        {
            IsOn = false;
        }
        public CarEngine(CarEngine other)
        {
            IsOn = other.IsOn;
        }

        public bool GetIsOn()
        {
            return this.IsOn;
        }
        public void SetIsOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                Console.WriteLine("Engine on");
            }
            else
            {
                Console.WriteLine("Cannot turn on engine if the engine is allready on");
            }
        }
        public void SetIsOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine("Engine off");
            }
            else
            {
                Console.WriteLine("Cannot turn off engine if the engine is allready off");
            }
        }
        /*public void SetIsOn() 
        {
            if (IsOn == true)
            {
                IsOn = false;
            }
            else
                IsOn = true;
        }*/
    }
}
