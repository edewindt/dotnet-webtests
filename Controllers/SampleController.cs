using Microsoft.AspNetCore.Mvc;

[Controller]
public class SampleController : Controller
{
    [Route("/")]
    public ContentResult Index() => Content("<h1>Home PAGEO</h1>", "text/html");

    [Route("/about")]
    public ContentResult About() => Content("{\"About\":\"SkillIssue\"}", "text/plain");

    [Route("/contact")]
    public ContentResult Contact() => Content("<book><title>Harry Potter</title></book>", "text/xml");
    [Route("person")]
    public JsonResult Person() => Json(new Person(Guid.NewGuid(), "Elias", 21));
}
