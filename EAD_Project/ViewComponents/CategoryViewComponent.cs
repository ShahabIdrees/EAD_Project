using Microsoft.AspNetCore.Mvc;
namespace EAD_Project.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> categories = new List<string>() {
               "Computers", "Sports", "Fashion", "Health & Household", "books","Electronics", "Gym & Fitness"
            };
            return View(categories);
        }
    }
}
