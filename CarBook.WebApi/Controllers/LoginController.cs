using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;


using CarBook.Application.Features.Mediator.Queries.AppUserQueries;
using CarBook.Application.Tools;
namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            var values = await _mediator.Send(query);
            if (!values.IsExist)
            {
                return BadRequest("Warning Check --> Password and Username!");
            }
            else
            {
                return Created("", JwtTokenGenerator.GenereteToken(values));
            }

        }
    }
}
