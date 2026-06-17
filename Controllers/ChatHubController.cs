using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace chat.Controllers
{
    public class ChatHubController : Controller
    {
        static List<MSG> messages = new List<MSG>();
        
        // to send messages
        public async Task sendMsg(string message)
        {

            var m = new MSG() { Id = messages.Count, Content = message };
            messages.Add(m);
        }


        public async Task ListenMessages()
        {
            List<int> deliveredMessageIds = new List<int>();

            while(true)
            {
                messages.ForEach(async m =>
                {
                    if (deliveredMessageIds.Contains(m.Id)) return; // already delivered
                    await Response.WriteAsync(m.Content);
                    await Response.Body.FlushAsync();
                    deliveredMessageIds.Add(m.Id);
                });
                await Task.Delay(1000);
            }
        }
    }


    public class User
    {
        public int Id { get; set; }
        public List<string> Messages { get; set; }
    }

    public class MSG
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
