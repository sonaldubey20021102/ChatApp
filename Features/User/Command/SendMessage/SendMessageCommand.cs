using MediatR;

namespace chat.Features.User.Command.SendMessage
{
    public record SendMessageCommand(string message,int AddedBy) : IRequest<int>;
}
