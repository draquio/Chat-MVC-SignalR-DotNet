using Microsoft.AspNetCore.Mvc;

namespace ChatRoom.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<string, string> Rooms = new Dictionary<string, string>()
        {
            { "juegos", "Sala de juegos" },
            { "Deportes", "Sala de deportes" },
            { "Videojuegos", "Sala de VideoJuegos" }
        };
        public IActionResult Index()
        {
            @ViewData["Title"] = "Chat .NET Core";
            return View();
        }
        public IActionResult Room(string room)
        {
            @ViewData["Title"] = $"Chat {room}";
            return View("Room", room);
        }
    }
}
