using Microsoft.AspNetCore.Mvc;

public class SampleController : Controller
{
    [Route("method")]
    public string Method1() => "Hello from method1";
}