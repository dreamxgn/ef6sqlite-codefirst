using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6SQLite
{
    [Table("User")]
    public class User
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string Username { get; set; }

        [Required]
        [StringLength(255)]
        public virtual string Password { get; set; }

        public virtual DateTime CreateTime { get; set; } = DateTime.Now;
        public virtual bool Enabled { get; set; } = true;
        public virtual ICollection<Photo> Photos { get; set; }
    }
}