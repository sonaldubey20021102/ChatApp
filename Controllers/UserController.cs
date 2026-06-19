using chat.Data;
using chat.Entity;
using chat.Features.User.Command.CreateUser;
using chat.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace chat.Controllers
{
    public class UserController : Controller
    {

        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<int> CreateUser(string UserName)
        {
            
            var result = await _mediator.Send(new CreateUserCommand(UserName));
            return result;

        }

    }
}
