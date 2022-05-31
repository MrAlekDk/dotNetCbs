namespace students.Models.Entities;

public class VolunteerGroupIndexVm
{
    public IEnumerable<Volunteer> Volunteers {get; set;}

    public IEnumerable<Group> Groups {get; set;}

}