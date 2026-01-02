using Microsoft.AspNetCore.Mvc;

public class TemplateConfusionController : Controller
{
    public IActionResult Index(string c)
    {
        string template = "<h2>{{content}}</h2>";
        return Content(template.Replace("{{content}}", c), "text/html");
    }
}
