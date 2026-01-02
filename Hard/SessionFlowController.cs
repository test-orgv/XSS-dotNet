using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class SessionFlowController : Controller
{
    public IActionResult Set(string name)
    {
        HttpContext.Session.SetString("n", name);
        return Content("Set");
    }

    public IActionResult Show()
    {
        var n = HttpContext.Session.GetString("n");
        return Content("<h1>" + n + "</h1>", "text/html");
    }
}
