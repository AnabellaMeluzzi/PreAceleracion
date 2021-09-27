using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PrimeraEntrega.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Password can't be less than 4 characters")]
        [MaxLength(10, ErrorMessage = "Password can't be more than 10 characters")]
        //[StringLength(10, MinimumLength = 4, ErrorMessage = "Password cannot be longer than 10 characters and less than 4 characters")]
        public string Password { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Un usuario puede tener muchos posteos
        //public string Posts { get; set; }
        public ICollection<Post> Posts { get; set; }

        // Un usuario puede teener muchos comentarios
        //public string Comments { get; set; }
        public ICollection<Comment> Comments { get; set; }




    }
}
