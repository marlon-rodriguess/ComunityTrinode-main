
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Trinode.Application.UseCases.CreateUser;
using Trinode.Application.UseCases.DeleteUser;
using Trinode.Application.UseCases.GetAllUser;
using Trinode.Application.UseCases.GetIdUser;
using Trinode.Application.UseCases.UpdatseUser;
using Trinode.Domain.Entities;

namespace Trinode.Presentation.Controllers
{
    [ApiController]
    [Route("[controller].lowercase")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator; //Crio uma instância de mediator para poder chamar os casos de uso a cada requisição
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<ActionResult<CreateUserResponse>> Create([FromBody] CreateUserRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request, cancellationToken); //Envia para o meidaotr o caso de uso CreateUser, ele identifica sozinho qual é o handler que deve ser chamado
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<User>> GetId([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(new GetByIdRequest(id), cancellationToken);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("get")]
        public async Task<ActionResult<User>> GetAll(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request,cancellationToken);
                return StatusCode(response.StatusCode, response);
            }   
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("delete")]
        public async Task<ActionResult<User>> Delete([FromBody] DeleteUserRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut("update")]
        public async Task<ActionResult<User>> Update([FromBody] UpdateUserRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(request, cancellationToken);
                return StatusCode(response.StatusCode, response);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

