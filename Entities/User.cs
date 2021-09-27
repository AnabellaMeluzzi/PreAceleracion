using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PrimeraEntrega.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The name can't be more than 20 characters")]
        public string Name { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Password can't be less than 4 characters")]
        [MaxLength(10, ErrorMessage = "Password can't be more than 10 characters")]
        public string Password { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Un usuario puede tener muchos posteos
        public ICollection<Post> Posts { get; set; }

        // Un usuario puede teener muchos comentarios
        public ICollection<Comment> Comments { get; set; }




    }
}
