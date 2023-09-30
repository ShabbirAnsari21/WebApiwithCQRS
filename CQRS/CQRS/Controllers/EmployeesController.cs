using AutoMapper;
using CQRS.Api.Model;
using CQRS.Api.Model.Request;
using CQRS.Business.MediatR.Command.Employee;
using CQRS.Domain.Entity;
using CQRS.Model.Model.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly ILogger<EmployeesController> _logger;
        public EmployeesController(IMediator mediator, ILogger<EmployeesController> logger, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("CreateEmployeeAsync")]
        [ProducesResponseType(typeof(PostResponses), StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateEmployeeAsync([FromBody] CreateEmployeeRequest request)
        {
            try
            {
                return Created("", await _mediator.Send(_mapper.Map<CreateEmployeeCommand>(request)));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("UpdateEmployeeAsync")]
        [ProducesResponseType(typeof(PostResponses), StatusCodes.Status202Accepted)]
        public async Task<ActionResult> UpdateEmployeeAsync([FromBody] UpdateEmployeeRequest request)
        {
            try
            {
                return Accepted(await _mediator.Send(_mapper.Map<UpdateEmployeeCommand>(request)));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("DeleteEmployeeAsync/{id:int}")]
        [ProducesResponseType(typeof(PostResponses), StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteEmployeeAsync([FromRoute] int id)
        {
            try
            {
                return Ok(await _mediator.Send(new DeleteEmployeeCommand {
                    Id = id
                }));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
