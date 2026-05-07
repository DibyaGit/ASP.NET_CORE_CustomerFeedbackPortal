using Microsoft.AspNetCore.Mvc;
using CustomerFeedbackPortal.Models;

namespace CustomerFeedbackPortal.Controllers
{
    public class FeedbackController : Controller
    {
        // 1. This method just shows the empty form to the user
        public IActionResult Index()
        {
            return View();
        }

        // 2. This method catches the data when they click "Submit"
        [HttpPost]
        public IActionResult Index(Feedback userFeedback)
        {
            return Content("Thank you for your feedback, " + userFeedback.Name + "!");
        }
    }
}