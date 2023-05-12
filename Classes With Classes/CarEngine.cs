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
        public void SetIsOn(bool value)
        {
            if (IsOn && value)
                Console.WriteLine("Cannot Turn On Engine\nEngine Is allready On");
            else if (IsOn == true && value == false)
                IsOn = false;
            else if (IsOn == false && value == true)
                IsOn = true;
            else
                Console.WriteLine("Cannot Turn Off Engine\nEngine Is allready Off");
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
