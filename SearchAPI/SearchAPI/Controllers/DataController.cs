using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SearchAPI.Service.Features.CustomerFeatures.Commands;
using SearchAPI.Service.Features.CustomerFeatures.Queries;
using System.Threading.Tasks;

namespace SearchAPI.Controllers
{
    
    [ApiController]
    [Route("api/v{version:apiVersion}/Data")]
    [ApiVersion("1.0")]
    public class DataController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllDataQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await Mediator.Send(new GetDataByIdQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await Mediator.Send(new DeleteByIdCommand { Id = id }));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, UpdateCommand command)
        {
            if (id != command.Column1)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
    }
}
