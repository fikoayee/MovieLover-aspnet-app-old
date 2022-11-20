using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        public string ProfilePictureURL { get; set; }
    }
}
