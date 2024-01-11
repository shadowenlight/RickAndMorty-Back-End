using System.ComponentModel.DataAnnotations;

namespace RickAndMorty.Models
{
    public class Episode
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public DateTime air_date { get; set; }
        public required string episode { get; set; }
        public required ICollection<Character> characters { get; set; } = new List<Character>();
    }
}
