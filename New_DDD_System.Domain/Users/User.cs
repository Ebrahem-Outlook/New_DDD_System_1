using New_DDD_System.Domain.Core.BaseType;
using New_DDD_System.Domain.Users.Events;

namespace New_DDD_System.Domain.Users;

public sealed class User : AggregateRoot
{    
    private User(string fristName, string lastName, string email, string phone)
        : base(Guid.NewGuid())
    {
        FristName = fristName;
        LastName = lastName;
        Email = email;
        Phone = phone;
    }

    private User() { }

    public string FristName { get; private set; } = default!;

    public string LastName { get; private set; } = default!;

    public string Email { get; private set; } = default!;

    public string Phone { get; private set; } = default!;

    public static User Create(string firstName, string lastName, string email, string phone)
    {
        User user = new(firstName, lastName, email, phone);

        user.Raise(new UserCreatedDomainEvent(user));

        return user;
    }

    public void UpdateUser(string firstName, string lastName, string email, string phone)
    {
        FristName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;

        Raise(new UserUpdatedDomainEvent(this));
    }
}
