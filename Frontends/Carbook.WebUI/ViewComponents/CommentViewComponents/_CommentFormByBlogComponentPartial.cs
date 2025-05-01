using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebUI.ViewComponents.CommentViewComponents;

public class _CommentFormByBlogComponentPartial : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}