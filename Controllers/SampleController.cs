using Microsoft.AspNetCore.Mvc;
[Controller]
public class SampleController
{
    [Route("/")]
    public ContentResult Index() => new ContentResult() { ContentType = "text/html", Content = "<h1>Home PAGEO</h1>" };
    [Route("/about")]
    public ContentResult About() => new ContentResult() { ContentType = "text/plain", Content = "{\"About\":\"SkillIssue\"}" };
    [Route("/contact")]
    public ContentResult Contact() => new ContentResult() { ContentType = "text/xml", Content = "<book><title>Harry Potter</title></book>" };
}