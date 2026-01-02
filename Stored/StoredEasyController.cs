using Microsoft.AspNetCore.Mvc;

public class StoredEasyController : Controller
{
    static string data = "";

    [HttpPost]
    public IActionResult Save(string msg)
    {
        data += msg + "<br>";
        return Content("Saved");
    }

    public IActionResult ViewData()
    {
        return Content(data, "text/html");
    }
}
