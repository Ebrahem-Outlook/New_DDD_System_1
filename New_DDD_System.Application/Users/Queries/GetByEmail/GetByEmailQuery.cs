﻿using New_DDD_System.Application.Core.CQRS;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Application.Users.Queries.GetByEmail;

public sealed record GetByEmailQuery(string Email) : IQuery<User>;
