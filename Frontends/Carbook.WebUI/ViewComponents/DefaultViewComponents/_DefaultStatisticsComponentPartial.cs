using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.DefaultViewComponents;

public class _DefaultStatisticsComponentPartial : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}