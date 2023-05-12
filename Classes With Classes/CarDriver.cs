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
            car.Get
        }

    }
}
