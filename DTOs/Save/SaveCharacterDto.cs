using RickAndMorty.Models;

namespace RickAndMorty.DTOs.Save
{
    public record struct SaveCharacterDto(int id, string name, string status, 
        string species, string type, string gender, Location origin, 
        Location location, string image, ICollection<Episode> episode, 
        string url, DateTime created);
}
