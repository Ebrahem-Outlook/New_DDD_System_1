using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<User>;
