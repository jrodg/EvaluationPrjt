
using GitHub.Models;
using GitHub.Services;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GitHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactModel cm;
        private IMessageBoardRepo _mrepo;

        public HomeController(ContactModel _cm, 
            IMailService ms,
            IMessageBoardRepo mrepo)
        {
            cm = _cm;
            _mrepo = mrepo;
        }
        public ActionResult Index()
        {
            var topics = _mrepo.GetTopics()
                .OrderByDescending(d=>d.Created)
                .Take(10)
                .ToList();
            return View(topics);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel ctx)
        {
            var msg = string.Format("Comment From:  {1} {0}Email:{2}{0}Website:{3}{0}",
                Environment.NewLine,
                cm.Name,
                cm.Email,
                cm.Message);
            var srv = new MailService();
            if (srv.SendMail("noreply@home.com", "test@home.com", "this is a test", msg))
            {
                ViewBag.MailSent = true;
            }
            
            return View();
        }
        [Authorize]
        public ActionResult MyMessages()
        {
            return View();
        }
    }
}