using System.Collections;

namespace Linq.FilteringMethods;

public class OfTypeMethod
{
    public void Use_OfType()
    {
        ArrayList list = [];

        list.Add(1);
        list.Add("C#");
        list.Add(true);
        list.Add(10);
        list.Add("ASP .NET CORE");
        list.Add("SQL");
        list.Add(new Car() { Id = 1, Name = "BENZ", Price = 7000 });
        list.Add(21);

        IEnumerable<int> intResult = list.OfType<int>(); //it will take an IEnumerable of type int (1, 10, 21)
        IEnumerable<string> stringResult = list.OfType<string>(); //it will take an IEnumerable of type string ("C#", "ASP .NET CORE", "SQL")
        IEnumerable<Car> carResult = list.OfType<Car>(); //it will take an IEnumerable of type car ({Id = 1, Name = "BENZ", Price = 7000 })
        IEnumerable<bool> boolResult = list.OfType<bool>(); //it will take an IEnumerable of type bool (true)

    }
}
