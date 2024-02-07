namespace ChatApp.Models.Message
{
    public class ChatViewModel
    {
        public MessageViewModel CurrentMessege { get; set; } = null!;

        public List<MessageViewModel> Messages { get; set;} = null!;
    }
}
