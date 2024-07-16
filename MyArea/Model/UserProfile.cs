using System.ComponentModel.DataAnnotations;

namespace MyArea
{
    public class UserProfile
    {
        public string Id { get; set; } // fields to store data

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Role { get; set; }

        public string Hobbies { get; set; } 
        public string ImageURL { get; set; }
        public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    }
}
