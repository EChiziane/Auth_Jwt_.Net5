using System.Threading.Tasks;
using Application.Dtos;
using Application.Features.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class AuthController:BaseController
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<LoginDto>> Login(Login.LoginCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}