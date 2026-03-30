public class Program
{

    public static void Main(string[] args)
    {

        //"{type}/{brand}/{model}/{horse power / weight}
        string informationFromConsole = Console.ReadLine();
        Catalog catalog = new Catalog();
        List<Car> cars = new List<Car>();
        List<Truck> truck = new List<Truck>();

        while (informationFromConsole != "end")
        {
            string type = informationFromConsole.Split("/")[0];

            if (type == "Car")
            {
                string brand = informationFromConsole.Split("/")[1];
                string model = informationFromConsole.Split("/")[2];
                int horsePower = int.Parse(informationFromConsole.Split("/")[3]);
                Car newCar = new Car(brand, model, horsePower);
                cars.Add(newCar);
                catalog.Cars.Add(newCar);

            }
            else
            {
                string brand = informationFromConsole.Split("/")[1];
                string model = informationFromConsole.Split("/")[2];
                int weight = int.Parse(informationFromConsole.Split("/")[3]);
                Truck newTruck = new Truck(brand, model, weight);
                truck.Add(newTruck);
                catalog.Trucks.Add(newTruck);
            }

            informationFromConsole = Console.ReadLine();
        }

        cars = cars.OrderBy(Car => Car.Brand).ToList();
        truck = truck.OrderBy(truck => truck.Brand).ToList();

        if (cars.Count > 0)
        {
            Console.WriteLine("Cars:");

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }

        if (truck.Count > 0)
        {
            Console.WriteLine("Trucks:");

            foreach (Truck viachle in truck)
            {
                Console.WriteLine($"{viachle.Brand}: {viachle.Model} - {viachle.Weight}kg");
            }
        }
    }

}
