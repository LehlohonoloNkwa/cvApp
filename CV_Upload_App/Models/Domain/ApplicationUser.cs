using Microsoft.AspNetCore.Identity;

namespace CV_Upload_App.Models.Domain
{

    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string ? ProfilePicture { get; set; }
    }
}
