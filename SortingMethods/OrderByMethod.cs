namespace Linq.SortingMethods;

public class OrderByMethod
{
    public void Use_OrderBy()
    {
        List<Car> cars = GetCars();

        IOrderedEnumerable<Car> Asc = cars.OrderBy(c => c.Price); //From Low to High
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
