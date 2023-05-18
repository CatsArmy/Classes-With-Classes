using Classes_With_Classes;

static void Bicycle()
{
    Wheel front = new Wheel(40);
    Wheel back = new Wheel(50);
    Bicycle bicycle = new Bicycle(front, back);
    Console.WriteLine(bicycle);
    bicycle.Repair();
    bicycle.Ride(30000);
    Console.WriteLine(bicycle);
    bicycle.Ride(10);
    bicycle.Repair();
    Console.WriteLine(bicycle);
    bicycle.Ride(2000);
    Console.WriteLine(bicycle);
    bicycle.Ride(10);
    bicycle.Repair();
    bicycle.Ride(40000);
    Console.WriteLine(bicycle);
    bicycle.Repair();
    Console.WriteLine(bicycle);
}
static void CarDriver()
{
    double literPrice = 8;
    CarEngine engine = new CarEngine();
    Car car = new Car(35, 7);
    CarDriver carDriver = new CarDriver(car, "yossi", 0);
    carDriver.TurnOffCar();
    carDriver.TurnOnCar();
    carDriver.DriveCar(100);
    Console.WriteLine(carDriver.GetCarGasInTank());
    Console.WriteLine(car.GetGasInTank());
    carDriver.DriveCar(400);
    carDriver.DriveCar(100);
    carDriver.TurnOnCar();
    carDriver.FillCarGas(literPrice, 5);
    carDriver.AddMoney(200);
    carDriver.TurnOffCar();
    carDriver.FillCarGas(literPrice, 21);
    carDriver.DriveCar(10);
    carDriver.TurnOnCar();
    carDriver.DriveCar(250);
    Console.WriteLine(carDriver.GetCarGasInTank());
    carDriver.FillCarGas(literPrice, 4);
    carDriver.TurnOffCar();
    carDriver.FillCarGas(literPrice, 4);
}
CarDriver();