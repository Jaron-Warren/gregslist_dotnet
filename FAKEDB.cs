using System.Collections.Generic;
using gregslist_dotnet.models;

namespace gregslist_dotnet
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("toyota", "corolla", 1990, 1000, default, "it's cool yo!") };
  }
}