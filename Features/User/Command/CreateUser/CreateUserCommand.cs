using MediatR;

namespace chat.Features.User.Command.CreateUser
{
    public record CreateUserCommand(string Name, string Email) : IRequest<int>;
}
