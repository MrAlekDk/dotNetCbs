using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace students.Models.Entities;

public class Group{

    public int GroupId { get; set; }

    [MinLength(3)]
    [Required (ErrorMessage = "Enter")]
    public string Name { get; set; }

    public List<Volunteer>? Volunteers { get; set; }


}