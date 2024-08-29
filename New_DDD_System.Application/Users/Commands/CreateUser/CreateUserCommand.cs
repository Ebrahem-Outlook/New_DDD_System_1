using New_DDD_System.Application.Core.CQRS;

namespace New_DDD_System.Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(
    string FirstName,
    string LastName,
    string Email,
    string Phone) : ICommand;
