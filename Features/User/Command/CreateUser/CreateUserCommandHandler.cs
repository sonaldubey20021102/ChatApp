
using chat.Controllers;
using chat.Data;
using chat.Entity;
using chat.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
            var UserExists = await _context.users.AnyAsync(x => x.Name == command.Name);

            if (UserExists) return 0;
            await _context.users.AddAsync(user);

            await _context.SaveChangesAsync();

            return user.Id;


            
        } 
    }
}
