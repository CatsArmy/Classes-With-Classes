using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_With_Classes
{
    internal class Bicycle
    {
        Wheel frontWheel;
        Wheel backWheel;

        public Bicycle(Wheel frontWheel, Wheel backWheel)
        {
            this.frontWheel = new Wheel(frontWheel);
            this.backWheel = new Wheel(backWheel);
        }
        public Bicycle(Bicycle other)
        {
            this.frontWheel = new Wheel(other.frontWheel);
            this.backWheel = new Wheel(other.backWheel);
        }
        public override string ToString()
        {
            string s = $"Front Wheel: {frontWheel}\n Back Wheel: {backWheel}";
            return s;
        }
        public void Ride(int Distance)
        {
            if (frontWheel.isRipped || backWheel.isRipped)
            {
                Console.WriteLine("Cannot ride please repair the ripped wheel");
                return;
            }
            double frontSpinDistance = 2 * Math.PI * frontWheel.radius;
            frontWheel.Spin(Distance / (int)frontSpinDistance);
            double backSpinDistance = 2 * Math.PI * backWheel.radius;
            backWheel.Spin(Distance / (int)backSpinDistance);
        }
        public void Repair()
        {
            if (!frontWheel.isRipped && !backWheel.isRipped)
            {
                Console.WriteLine("No need to repair");
                return;
            }
            else
            {
                frontWheel.Repair();
                backWheel.Repair();
                Console.WriteLine("Succesfuly repaired");
            }
        }
    }
}
