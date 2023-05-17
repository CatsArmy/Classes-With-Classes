using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Classes_With_Classes
{
    internal class Car
    {
        double gasTankCapacity;
        double gasInTank;
        double literGasPer100Km;
        CarEngine engine;

        /// <summary>
        /// <if> </if>
        /// </summary>
        /// <param name="gasTankCapacity"></param>
        /// <param name="literGasPer100Km"></param>
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

        public bool Drive(int distance)
        {
            if (!GetIsOn())
            {
                Console.WriteLine("cant drive with the engine turned off now can you");
                return false;
            }
            if (gasInTank <= 0)
            {
                Console.WriteLine("the car wont startup... its out of fuel you should refuel it");
                return false;
            }
            double gasPerKiloMeter = GetLiterGasPer100KM()/100;
            gasInTank -= distance/gasPerKiloMeter;
            if (gasInTank == 0)
                Console.WriteLine("upon arriving you run out of fuel");
            else if (gasInTank < 0)
                Console.WriteLine("you ran out of fuel while driving");
            else
                Console.WriteLine("you made it with fuel to spare");
            return true;
        }

        public int FillGas(int pricePerLiter, double requestedFuelInLiters)
        {
            return (int)requestedFuelInLiters * pricePerLiter;
        }
    }
}
