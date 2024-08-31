using MediatR;
using Microsoft.AspNetCore.Mvc;
using New_DDD_System.API.Contracts.Users;
using New_DDD_System.Application.Users.Commands.CreateUser;
using New_DDD_System.Application.Users.Commands.DeleteUser;
using New_DDD_System.Application.Users.Queries.GetAll;
using New_DDD_System.Application.Users.Queries.GetByEmail;
using New_DDD_System.Application.Users.Queries.GetById;
using New_DDD_System.Application.Users.Queries.GetByName;

namespace New_DDD_System.API.Controllers;

[Route("api/v1/[Controller]")]
[ApiController]
public sealed class UsersController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request) =>
        Ok(await sender.Send(
            new CreateUserCommand(
                request.FirstName, 
                request.LastName,
                request.Email, 
                request.Phone)));

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserRequest request) => 
        Ok(await sender.Send(
            new UpdateUserRequest(
                request.UserId, 
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.Phone)));

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserRequest request) => Ok(await sender.Send(new DeleteUserCommand(request.UserId)));

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await sender.Send(new GetAllUsersQuery()));

    [HttpGet("id:{id}")]
    public async Task<IActionResult> GetById(Guid id) => Ok(await sender.Send(new GetUserByIdQuery(id)));

    [HttpGet("name:{name}")]
    public async Task<IActionResult> GetByName(string name) => Ok(await sender.Send(new GetUserByNameQuery(name)));

    [HttpGet("email:{email}")]
    public async Task<IActionResult> GetByEmail(string email) => Ok(await sender.Send(new GetUserByEmailQuery(email)));
}
