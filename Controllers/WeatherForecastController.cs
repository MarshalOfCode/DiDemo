using Microsoft.AspNetCore.Mvc;

namespace DiDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ISingletonservice _singletonservice;
    private readonly ISingletonservice _singletonservice_2;

    private readonly ITransientService _transientService_1;
    private readonly ITransientService _transientService_2;

    private readonly IScopedService _scopedService_1;
    private readonly IScopedService _scopedService_2;


    public WeatherForecastController(ISingletonservice singletonservice,ISingletonservice singletonservice_2,
    ITransientService transientService_1,
    ITransientService transientService_2,
    IScopedService scopedService_1,
    IScopedService scopedService_2
    )
    {
        _singletonservice = singletonservice;
        _singletonservice_2 = singletonservice_2;

        _transientService_1 = transientService_1;
        _transientService_2 = transientService_2;

        _scopedService_1 = scopedService_1;
        _scopedService_2 = scopedService_2;
    }

    [HttpPost]
    [Route("/getSingletonList")]
    public List<int> getSingletonList(int number)
    {
        var singleton_1 = _singletonservice;

        singleton_1.addList(number);

        var singleton_2 = _singletonservice_2;

        return singleton_2.getList();
    }

    [HttpPost]
    [Route("/getTransientList")]
    public List<int> getTransientList(int number)
    {
        var transientService1 = _transientService_1;

        transientService1.addList(number);

        var transientService2 = _transientService_2;

        return transientService2.getList();
    }

    [HttpPost]
    [Route("/getScopedList")]
    public List<int> getScopedList(int number)
    {
        var scopedService1 = _scopedService_1;

        scopedService1.addList(number);

        var scopedService2 = _scopedService_2;

        return scopedService2.getList();
    }
}
