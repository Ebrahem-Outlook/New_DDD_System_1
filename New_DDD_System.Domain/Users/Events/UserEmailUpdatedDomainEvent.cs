using New_DDD_System.Domain.Core.Events;

namespace New_DDD_System.Domain.Users.Events;

/// <summary>
/// 
/// </summary>
/// <param name="User"></param>
public sealed record UserEmailUpdatedDomainEvent(User User) : DomainEvent();
