using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_With_Classes
{
    internal class CarDriver
    {
        Car car;
        string name;
        int money;
        
        public CarDriver(Car car,string name,int money)
        {
            this.car = new Car(car);
            this.name = name;
            this.money = money;
        }

        public string GetName()
        {
            return this.name;
        }
        public int GetMoney()
        {
            return this.money;
        }
        public Car getCar() 
        {
            return this.car;
        }
        public double GetGasInTank()
        {
            return this.car.GetGasInTank();
        }
        public void AddMoney(int money)
        {
            if (money < 0)
                Console.WriteLine("Cannot add a negitive number");
            else
                this.money += money;

        }
        public void TurnOnCar()
        {
            car.TurnOnEngine();
        }
        public void TurnOffCar()
        {
            car.TurnOffEngine();
        }
        public bool DriveCar(int distanceInKiloMeters)
        {
            return car.Drive(distanceInKiloMeters);
        }
        public bool FillGasCar(int literFuelPrice, int requestedFuel)
        {
            if (car.GetIsOn())
            {
                Console.WriteLine("please turn off the engine before refueling");
                return false;
            }
            if (car.GetGasInTank() == car.GetGasTankCapacity())
            {
                Console.WriteLine("The fuel tank is full you cannot fuel your car like this");
                return false;
            }
            double requiredGasToFillTank = car.GetGasTankCapacity() - car.GetGasInTank();
            int cost;
            if (requestedFuel > car.GetGasTankCapacity() || requestedFuel >= requiredGasToFillTank)
            {
                cost = car.FillGas(literFuelPrice, requiredGasToFillTank);
                if (money - cost < 0)
                {
                    Console.WriteLine("you dont have the money to fuel the car");
                    return false;
                }
                money -= cost;
                return true;
            }
            cost = car.FillGas(literFuelPrice, requestedFuel);
            if (money - cost < 0)
            {
                Console.WriteLine("you dont have the money to fuel the car");
                return false;
            }
            return true;
        }
    }
}
