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
        [StringLength(40)]
        public string Title { get; set; }

        [Required]
        public DateTime DatePost { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }


        // Conexión con el user que hizo el Post
        public User User { get; set; }
        // Conexion con comentarios;
        public ICollection<Comment> Comments { get; set; }
    }
}
