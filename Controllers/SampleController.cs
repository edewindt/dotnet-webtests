using Microsoft.AspNetCore.Mvc;

[Controller]
public class SampleController : Controller
{
    [Route("/")]
    public IActionResult Index() => Content("<h1>Home PAGEO</h1>", "text/html");

    [Route("/about/{age}")]
    public IActionResult About(int age) => BadRequest($"{age}");

    [Route("/contact")]
    public IActionResult Contact(string? book) => Content($"<book><title>{book}</title></book>", "text/xml");
    [HttpGet]
    [Route("person/{name}/{age}")]
    public IActionResult Person(string? name, int? age)
    {
        if (!string.IsNullOrEmpty(name) && age.HasValue)
        {
            return Json(new Person(name, age.Value));
        }
        else
        {
            var defaultPerson = new Person("Dune", 90);
            return Json(defaultPerson);
        }
    }
    [Route("file")]
    public IActionResult FileDown() => File("/The Art Of Bit Manipulation.png", "image/png");
}
