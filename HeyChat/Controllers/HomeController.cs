using System.Web.Mvc;

namespace HeyChat.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                return Redirect("/chat");
            }
            return View();
        }
    }
}