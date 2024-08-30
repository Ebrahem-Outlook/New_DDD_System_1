using Microsoft.EntityFrameworkCore;
using New_DDD_System.Application.Core.Data;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Infrastructure.Repositories;

internal sealed class UserRepository(IDbContext dbContext) : IUserRepository
{
    public async Task AddAsync(User user, CancellationToken cancellationToken)
    {
        await dbContext.Set<User>().AddAsync(user, cancellationToken);
    }

    public void Update(User user)
    {
        dbContext.Set<User>().Update(user);
    }

    public void Delete(User user)
    {
        dbContext.Set<User>().Remove(user);
    }

    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>()
                              .AsNoTracking()
                              .ToListAsync(cancellationToken);
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>()
                              .AsNoTracking()
                              .SingleOrDefaultAsync(user => user.Email == email, cancellationToken);
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>()
                              .AsNoTracking()
                              .SingleOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<User>> GetByNameAsync(string name, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>()
                              .AsNoTracking()
                              .Where(user => user.FristName.Contains(name, StringComparison.OrdinalIgnoreCase))
                              .ToListAsync(cancellationToken);
    }
}
