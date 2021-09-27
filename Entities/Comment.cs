using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeraEntrega.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateComment { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The comment can't be more than 200 characters")]
        public string CommentContent { get; set; }

        //Relacion con usuario
        public User User { get; set; }

        //Relacion con Post
        public Post Post { get; set; }
    }
}
