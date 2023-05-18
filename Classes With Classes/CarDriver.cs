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
        double money;
        
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
        public double GetMoney()
        {
            return this.money;
        }
        public Car GetCar() 
        {
            return this.car;
        }
        public double GetCarGasInTank()
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
        public bool FillCarGas (double literFuelPrice, double requestedFuel)
        {
            if (car.GetIsOn())
            {
                Console.WriteLine("Turn off the engine before refueling");
                return false;
            }
            if (car.GetGasInTank() == car.GetGasTankCapacity())
            {
                Console.WriteLine("You cannot fuel your car if the tank is full");
                return false;
            }
            double requiredGasToFillTank = car.GetGasTankCapacity() - car.GetGasInTank();
            double cost;
            if (requestedFuel > car.GetGasTankCapacity() || requestedFuel >= requiredGasToFillTank)
            {
                cost = car.FillGasPrice(literFuelPrice, requiredGasToFillTank);
                if (money - cost < 0)
                {
                    Console.WriteLine("you dont have the money to fuel the car");
                    return false;
                }
                money -= cost;
                car.FillGas(requiredGasToFillTank);
                Console.WriteLine($"after refueling you have {GetCarGasInTank()} liters in your tank\nand {money} dollars left");
                return true;
            }
            cost = car.FillGasPrice(literFuelPrice, requestedFuel);
            if (money - cost < 0)
            {
                Console.WriteLine("you dont have the money to fuel the car");
                return false;
            }
            money -= cost;
            car.FillGas(requestedFuel);
            Console.WriteLine($"after refueling you have {GetCarGasInTank()} liters in your tank\nand {money} dollars left");
            return true;
        }
    }
}
