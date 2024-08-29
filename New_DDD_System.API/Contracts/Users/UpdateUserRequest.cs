namespace New_DDD_System.API.Contracts.Users;

public sealed record UpdateUserRequest(
    Guid UserId, 
    string FirstName, 
    string LastName, 
    string Email, 
    string Phone);
