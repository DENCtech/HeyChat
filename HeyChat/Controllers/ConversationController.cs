using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HeyChat.Controllers
{
    public class ConversationController : Controller
    {
        public JsonResult WithContact(int contact)
        {
            if (Session["user"] == null)
            {
                return Json(new { status = "error", message = "User is not logged in" });
            }

            var currentUser = (Models.User)Session["user"];

            var conversations = new List<Models.Conversation>();

            using (var db = new Models.ChatContext())
            {
                conversations = db.Conversations.
                    Where(c => (c.ReceiverId == currentUser.Id && c.SenderId == contact) || (c.ReceiverId == contact && c.SenderId == currentUser.Id))
                    .OrderBy(c => c.createdAt)
                    .ToList();
            }

            return Json(new { status = "success", data = conversations });
        }
    }
}