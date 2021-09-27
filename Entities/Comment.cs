using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeraEntrega.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime DateComment { get; set; }

        [Required]
        [StringLength(200)]
        public string CommentContent { get; set; }

        //Relacion con usuario
        public User User { get; set; }
        //Relacion con Post
        public Post Post { get; set; }
    }
}
