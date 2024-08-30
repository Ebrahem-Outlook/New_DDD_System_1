using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetByName;

public sealed record GetUserByNameQuery(string Name) : IQuery<IEnumerable<User>>;
