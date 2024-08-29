using New_DDD_System.Application.Core.CQRS;

namespace New_DDD_System.Application.Users.Commands.UpdateUser;

public sealed record UpdateUserCommand(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Phone) : ICommand;
