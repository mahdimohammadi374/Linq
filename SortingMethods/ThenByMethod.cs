namespace Linq.SortingMethods;

public class ThenByMethod
{
    public void Use_ThenBy()
    {
        List<Car> cars = GetCars();

        //ThenBy() Performs a secondary sort in ascending order we can many ThenBy()
        //first it orders by Price and then by Name. if we have many records with same price then they will be orderd by name

        IOrderedEnumerable<Car> Asc = cars.OrderBy(c => c.Price).ThenBy(x=>x.Name);
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
