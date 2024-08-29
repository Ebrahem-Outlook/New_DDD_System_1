namespace New_DDD_System.API.Contracts.Users;

public sealed record CreateUserRequest(
    string FirstName, 
    string LastName, 
    string Email, 
    string Phone);
