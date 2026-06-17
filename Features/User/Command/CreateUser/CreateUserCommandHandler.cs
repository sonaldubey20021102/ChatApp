
using chat.Controllers;
using chat.Data;
using chat.Models;
using MediatR;

namespace chat.Features.User.Command.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateUserCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand command,CancellationToken cancellationToken)
        {
            var user = new UserDetails
            {
                Name = command.Name
            };
            await _context.users.AddAsync(user);

            await _context.SaveChangesAsync();

            return user.Id;
        } 
    }
}
