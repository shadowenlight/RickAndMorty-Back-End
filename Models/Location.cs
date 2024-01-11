using System.ComponentModel.DataAnnotations;

namespace RickAndMorty.Models
{
    public class Location
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
    }
}
