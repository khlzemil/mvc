using front_to_back.Models;
using front_to_back.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var projectComponents = new List<ProjectComponent>
            {
                new ProjectComponent{Title = "Our vision", Text = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."},
                new ProjectComponent{Title = "Our mission", Text = "Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis."},
                new ProjectComponent{Title = "Our goal", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor."},
            };

            var model = new AboutIndexViewModel
            {
                ProjectComponents = projectComponents
            };

            return View(model);
        }
    }
}
