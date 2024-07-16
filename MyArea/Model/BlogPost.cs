using System;
using System.ComponentModel.DataAnnotations;

namespace MyArea
{
    public class BlogPost
    {
        public int Id { get; set; } // fields to store data 

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        public string ImageURL { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
