namespace Templates.WebUi.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public class ImportsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return await Task.Run(() => View());
        }

        public async Task<IActionResult> Table()
        {
            return await Task.Run(() => View());
        }
    }
}