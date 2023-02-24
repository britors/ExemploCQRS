using ExemploCQRS.Application.Commands.GetUserModules;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace ExemploCQRS.Api.Controllers.User
{
    [Route("api/user/get-modules")]
    [ApiController]
    public class GetUserModulesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<GetUserModule> _validator;

        public GetUserModulesController(IMediator mediator, IValidator<GetUserModule> validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GetUserModule command)
        {
            var validation = await _validator.ValidateAsync(command);

            if (!validation.IsValid)
                return BadRequest(validation.Errors?.Select(e => new
                {
                    e.PropertyName,
                    e.ErrorMessage
                }));

            try
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            catch(Exception e)
            {
                Console.WriteLine("######################");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("######################");
                return StatusCode(500, e.Message);
            }
        }
    }
}
