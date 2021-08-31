

using System.Collections.Generic;
using gregslist_dotnet.models;

namespace gregslist_dotnet.Services
{
  public class CarsService
  {
    IEnumerable<Car> Get()
    {
      return FakeDB.Cars;
    }
    Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new System.Exception("Invalid Id");
      }
      return found;
    }
  }
}