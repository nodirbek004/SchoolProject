using ApartmentDomain.Commons;

namespace ApartmentDomain.Entities;

public class User:AudiTable
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string DateOfBirth { get; set; }

}
