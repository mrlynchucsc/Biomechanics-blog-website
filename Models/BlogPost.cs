using System;
using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Display(Name = "Date Published")]
        public DateTime DatePublished { get; set; } = DateTime.Now;
    }
}
