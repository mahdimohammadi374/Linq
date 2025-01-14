namespace Linq.FilteringMethods;

public class WhereMethod
{
    public void Use_Where()
    {
        List<Car> cars = GetCars();

        //its an example of Immediate Execution (the query is executed when declared) Because We Use .ToList();
        List<Car> expensive = cars.Where(x => x.Price > 15000).ToList();

        //Here if We Add new record to cars it wont be Added
        cars.Add(new Car { Id = 7, Name = "Buggati", Price = 50000 });

        Console.WriteLine("---------------Expensive Cars------------");
        //and we see just 2 outputs
        foreach (var car in expensive)
        {
            Console.WriteLine($"Name = {car.Name}, Price = {car.Price} ");
        }
    }

    public void Use_Where_With_Index()
    {
        List<Car> cars = GetCars();

        //its an example of Deferred Execution (the query is not executed when declared)
        var evens = cars.Where((item, index) => index % 2 == 0);
        var odds = cars.Where((item, index) => index % 2 != 0);

        //Here if We Add new records to cars it will be Added
        cars.Add(new Car { Id = 7, Name = "Buggati", Price = 50000 });
        cars.Add(new Car { Id = 8, Name = "Lamborghini", Price = 45000 });

        //Now we will see 4 outputs for each iteration
        Console.WriteLine("--------------EVENS---------------");
        foreach (var car in evens)
        {
            Console.WriteLine($"Name = {car.Name}, Price = {car.Price} ");
        }

        Console.WriteLine("--------------ODDS---------------");
        foreach (var car in odds)
        {
            Console.WriteLine($"Name = {car.Name}, Price = {car.Price} ");
        }

    }

    private List<Car> GetCars()
    {
        return new List<Car>()
        {
            new Car(){Id = 1, Name ="BENZ",Price=7000},
            new Car(){Id = 2, Name ="BMW",Price=5000},
            new Car(){Id = 3, Name ="TESLA",Price=20000},
            new Car(){Id = 4, Name ="AUDI",Price=18000},
            new Car(){Id = 5, Name ="NISSAN",Price=10000},
            new Car(){Id = 6, Name ="PORSCHE",Price=12000},
        };
    }
}
