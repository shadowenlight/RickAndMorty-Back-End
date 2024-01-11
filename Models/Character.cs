using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickAndMorty.Models
{
    public class Character
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public required string status { get; set; }
        public required string species { get; set; }
        public string? type { get; set; }
        public required string gender { get; set; }


        public virtual required Location origin { get; set; }
        public int originId { get; set; }


        public virtual required Location location { get; set; }
        public int locationId { get; set; }


        public string? image {  get; set; }
        public required ICollection<Episode> episode { get; set; } = new List<Episode>();        
    }
}
