using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.Frontend.Controllers;

public class ChatController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Chat Support";
        return View();
    }
}