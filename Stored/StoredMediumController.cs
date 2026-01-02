using Microsoft.AspNetCore.Mvc;

public class StoredMediumController : Controller
{
    static string store = "";

    void SaveInternal(string d)
    {
        store += d + "<hr>";
    }

    [HttpPost]
    public IActionResult Save(string msg)
    {
        SaveInternal(msg);
        return Content("OK");
    }

    public IActionResult ViewData()
    {
        return Content(store, "text/html");
    }
}
