using AutoMig.Entity.Feedback;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class ContactsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Contacts controller";

            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(FeedbackRequest feedbackRequest)
        {
            if (feedbackRequest is null)
            {
                return BadRequest("feedbackRequest is null");
            }

            if (feedbackRequest.MailSender is null || !feedbackRequest.MailSender.Contains("@"))
            {
                return BadRequest("MailSender not contains @");
            }

            return Ok();
        }
    }
}