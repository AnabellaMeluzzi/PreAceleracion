using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrimeraEntrega.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The title can't be more than 40 characters")]
        public string Title { get; set; }

        [Required]
        public DateTime DatePost { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The content can't be more than 500 characters")]
        public string Content { get; set; }


        // Conexión con el user que hizo el Post
        public User User { get; set; }

        // Conexion con comentarios;
        public ICollection<Comment> Comments { get; set; }
    }
}
