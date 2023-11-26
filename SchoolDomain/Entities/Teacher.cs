using SchoolDomain.Commons;

namespace SchoolDomain.Entities;

public class Teacher:AudiTable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GroupId { get; set; }
    public string DateOfBirth { get; set; }
    public string ScienceId { get; set; }

}
