using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6SQLite
{
    [Table("Photo")]
    public class Photo
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(50)]
        public virtual string Url { get; set; }
    }
}