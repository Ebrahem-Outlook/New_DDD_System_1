namespace New_DDD_System.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken);
    void Update(User user);
    void Delete(User user);

    // Queries.
    Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken);
    Task<User?> GetByIdAsync(Guid Id, CancellationToken cancellationToken);
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken);
    Task<IEnumerable<User>> GetByNameAsync(string name, CancellationToken cancellationToken);
}
