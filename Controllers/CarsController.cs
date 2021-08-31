
using Microsoft.AspNetCore.Mvc;
using gregslist_dotnet.Services;

namespace gregslist_dotnet.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _carsService;
    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }
  }
}