using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_With_Classes
{
    internal class Car
    {
        double gasTankCapacity;
        double gasInTank;
        double literGasPer100Km;
        CarEngine engine;
        public Car(double gasTankCapacity, double literGasPer100Km)
        {
            this.gasTankCapacity = gasTankCapacity;
            this.literGasPer100Km = literGasPer100Km;
            gasInTank = gasTankCapacity;
            engine = new CarEngine();
        }
        public Car(Car other)
        {
            gasTankCapacity = other.gasTankCapacity;
            literGasPer100Km = other.literGasPer100Km;
            gasInTank = other.gasInTank;
            engine = new CarEngine(other.engine);
        }

        public double GetGasTankCapacity()
        {
            return gasTankCapacity;
        }
        public double GetGasInTank()
        {
            return gasInTank;
        }
        public double GetLiterGasPer100KM()
        {
            return literGasPer100Km;
        }
        public bool GetIsOn()
        {
            return engine.GetIsOn();
        }
        public void TurnOnEngine()
        {
            if (gasInTank < 0)
            {
                Console.WriteLine("Cannot Turn On Engine Please Refule your car");
            }
            else
            {
                engine.SetIsOn(true);

            }
        }
        public void TurnOffEngine()
        {
            engine.SetIsOn(false);
        }
        /// <summary>
        /// Gets <paramref name="Distance"/> In Kilomiters 
        /// <code></code>
        /// </summary>
        /// <param name="Distance"></param>
        /// <returns><if><see cref="GetGasInTank"/> > 0</if> </returns>
        ///             <else>true</else>
        public bool Drive(int Distance)
        {
            
        }
    }
}
