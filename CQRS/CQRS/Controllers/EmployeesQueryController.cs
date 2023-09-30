using CQRS.Business.MediatR.Query;
using CQRS.Model.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesQueryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EmployeesQueryController> _logger;
        public EmployeesQueryController(IMediator mediator, ILogger<EmployeesQueryController> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }
        [HttpGet("GetAllEmployeeAsync")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllEmployeeAsync()
        {
            try
            {
                return Ok(await _mediator.Send(new GetAllEmployeeQuery()));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetAllEmployeeAsync/{id:int}")]
        [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetEmployeeByIdAsync([FromRoute] int id)
        {
            try
            {
                return Ok(await _mediator.Send(new GetEmployeeByIdQuery { Id = id }));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
