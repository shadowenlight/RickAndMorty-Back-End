using RickAndMorty.Models;

namespace RickAndMorty.DTOs.Display
{
    public record struct DisplayCharacterDto(string name, string status, string species,
        string type, string gender, Location origin, Location location, ICollection<DisplayEpisodeForCharacterDto> episode);
}
