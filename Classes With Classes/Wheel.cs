using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_With_Classes
{
    internal class Wheel
    {
        public double radius;
        public int numSpin;
        public bool isRipped;

        public Wheel(double _radius, int _nSpin = 0, bool _isRipped = false)
        {
            radius = _radius;
            numSpin = _nSpin;
            isRipped = _isRipped;
        }
        public Wheel(Wheel other) 
        {
            radius = other.radius;
            numSpin = other.numSpin;
            isRipped = other.isRipped;
        }
        public double GetRadius()
        {
            return this.radius;
        }
        public bool GetIsRipped()
        {
            return this.isRipped;
        }
        public override string ToString()
        {
            string s = @$"Radius: {radius}
NumSpin: {numSpin}
IsRipped: {isRipped}";
            return s;
        }
        public bool Spin(int nSpin)
        {
            if (isRipped)
            {
                return false;
            }

            numSpin += nSpin; ;
            if (numSpin > 9999)
            {
                this.isRipped = true;
            }
            return true;
        }
        public bool Repair()
        {
            if (isRipped)
            {
                isRipped = false;
                numSpin = 0;
                return true;
            }
            return false;
        }
    }
}
