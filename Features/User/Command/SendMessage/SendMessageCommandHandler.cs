using chat.Data;
using chat.Entity;
using MediatR;

namespace chat.Features.User.Command.SendMessage
{
    public class SendMessageCommandHandler:IRequestHandler<SendMessageCommand,int>
    {
        private readonly AppDbContext _db;

        public SendMessageCommandHandler(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }

        public async Task<int> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            var message = new Message
            {
                MessageTxt = request.message,
                AddedBy = request.AddedBy
            };

            await _db.messages.AddAsync(message);
            await _db.SaveChangesAsync();

            return message.Id;

        }
    }
}
