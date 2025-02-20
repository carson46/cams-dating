

using System.ComponentModel.DataAnnotations;

namespace Mission6.Models;

public class Application
{
    public Application(int applicationId, string firstName, string lastName, int age, string hobbies, string phone, string major, string occupation, bool clingy)
    {
        ApplicationId = applicationId;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Hobbies = hobbies;
        Phone = phone;
        Major = major;
        Occupation = occupation;
        Clingy = clingy;
    }

    [Key]
    [Required]
    public int ApplicationId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Hobbies { get; set; }
    public string Phone { get; set; }
    public string Major { get; set; }
    public string Occupation { get; set; } 
    public bool Clingy { get; set; }
    
}

 // this is what { get; set; } do behind the scenes 
    // public int GetApplicationId() // getter
    // {
    //     return ApplicationId;
    // }
    //
    // public void SetApplicationId(int id) // setter
    // {
    //     ApplicationId = id;
    // }