using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace hienv_asp.Views.Shared.Components.FileManager
{
    [ViewComponent]
    public class FileManager : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
