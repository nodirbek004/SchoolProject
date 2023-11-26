using SchoolDomain.Commons;

namespace SchoolDomain.Entities;

public class Student:AudiTable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int GroupId { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set;}
    
}
