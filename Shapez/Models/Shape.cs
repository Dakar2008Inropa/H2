using System.ComponentModel.DataAnnotations;

namespace Shapez.Models
{
    public class Shape
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(8)]
        public string? Color { get; set; }
        public DateTime Created { get; set; }
        [MaxLength(16)]
        public string? Shapez { get; set; }
        public int Owner { get; set; }
    }
}