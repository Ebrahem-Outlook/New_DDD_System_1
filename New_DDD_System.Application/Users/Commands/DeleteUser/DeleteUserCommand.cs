using New_DDD_System.Application.Core.CQRS;

namespace New_DDD_System.Application.Users.Commands.DeleteUser;

public sealed record DeleteUserCommand(Guid Id) : ICommand;
