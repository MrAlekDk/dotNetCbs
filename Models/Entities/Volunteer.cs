using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace students.Models.Entities;

public class Volunteer{

    public int VolunteerId{ get; set; }

    [MinLength(3)]
    [Required (ErrorMessage = "Please insert your name")]
    public string Name { get; set; }

    [Range(14,90,ErrorMessage = "Age has to be between 14 and 90" )]
    [Required (ErrorMessage = "Please enter your age")]
    public int Age { get; set;}

    public string StudyProgramme { get; set;}
    [Display(Name = "Date")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; }

    public VolunteerStatus Status { get; set; }

    [Display(Name = "Group")]
    public int? GroupId {get;set;}
    public Group? Group {get; set;}



}