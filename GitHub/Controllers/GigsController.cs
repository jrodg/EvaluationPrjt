using GitHub.Models;
using GitHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GitHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _ctx;
        public GigsController()
        {
             _ctx = new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _ctx.Genre.ToList()
            };
            return View(viewModel);
        }
    }
}