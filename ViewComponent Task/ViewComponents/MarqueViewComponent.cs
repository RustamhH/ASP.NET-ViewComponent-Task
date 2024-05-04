using Microsoft.AspNetCore.Mvc;

namespace Lesson_6_Routing.ViewComponents;

public class MarqueViewComponent : ViewComponent
{

    public IViewComponentResult Invoke()
    {
        var categories = new List<string>()
        {
            "Dizayn",
            "Proqramlaşdırma",
            "Kibertəhlükəsizlik",
            "Uşaqlar üçün IT"
        };

        return View(categories);
    }
}