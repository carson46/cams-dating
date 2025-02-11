

namespace Mission6.Models;

public class Application
{
    public int ApplicationId { get; set; }
    
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
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Hobbies { get; set; }
    public string Phone { get; set; }
    public string Major { get; set; }
    public string Occupation { get; set; }
    public bool Clingy { get; set; }
    
}

