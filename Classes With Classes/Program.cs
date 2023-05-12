


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

}