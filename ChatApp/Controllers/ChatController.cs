using ChatApp.Models.Message;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private static List<KeyValuePair<string,string>> messeges = new List<KeyValuePair<string,string>>();

        public IActionResult Show()
        {
            if (messeges.Count <1)
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = messeges
                .Select(m=>new MessageViewModel()
                {
                    Sender = m.Key,
                    MessageText = m.Value
                })
                .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat) 
        {
            var newMess = chat.CurrentMessege;

            messeges.Add(new KeyValuePair<string, string>
                (newMess.Sender,newMess.MessageText));

            return RedirectToAction("Show");
        }


    }
}
