using Microsoft.AspNetCore.Mvc;

[Controller]
public class SampleController : Controller
{
    [Route("/")]
    public IActionResult Index() => Content("<h1>Home PAGEO</h1>", "text/html");

    [Route("/about")]
    public IActionResult About() => BadRequest("{\"About\":\"SkillIssue\"}");

    [Route("/contact")]
    public IActionResult Contact() => Content("<book><title>Harry Potter</title></book>", "text/xml");
    [Route("person")]
    public IActionResult Person() => Json(new Person(Guid.NewGuid(), "Elias", 21));
    [Route("file")]
    public IActionResult FileDown() => File("/The Art Of Bit Manipulation.png", "image/png");
}
