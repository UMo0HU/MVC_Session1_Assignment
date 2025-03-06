using Microsoft.AspNetCore.Mvc;
using MVCTask1.Models;

namespace MVCTask1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            productBL productBL = new productBL();

            var products = productBL.GetAll();

            return View(products);
        }

        public IActionResult Details(int id)
        {
            productBL productBL = new productBL();
            var product = productBL.GetByID(id);

            return View(product);
        }
    }
}
