using GitHub.Models;
using GitHub.ViewModels;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _ctx.Genre.ToList()
            };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFormViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Genres = _ctx.Genre.ToList();
                return View("Create", vm);
            }
            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = vm.GetDateTime(),
                GenreId = vm.Genre,
                Venue = vm.Venue
            };
            _ctx.Gig.Add(gig);
            _ctx.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}