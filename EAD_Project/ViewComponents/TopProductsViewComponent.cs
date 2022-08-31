using Microsoft.AspNetCore.Mvc;

namespace EAD_Project.ViewComponents
{
    public class TopProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
