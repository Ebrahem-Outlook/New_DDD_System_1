namespace New_DDD_System.Domain.Users;

/// <summary>
/// 
/// </summary>
public sealed class User 
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="fristName"></param>
    /// <param name="lastName"></param>
    /// <param name="email"></param>
    /// <param name="phone"></param>
    private User(string fristName, string lastName, string email, string phone)
    {
        Id = Guid.NewGuid();
        FristName = fristName;
        LastName = lastName;
        Email = email;
        Phone = phone;
    }

    /// <summary>
    /// 
    /// </summary>
    private User() { }

    /// <summary>
    /// 
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// 
    /// </summary>
    public string FristName { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string LastName { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string Phone { get; private set; }

    public static User Create(string firstName, string lastName, string email, string phone)
    {
        User user = new User(firstName, lastName, email, phone);

        return user;
    }
}
