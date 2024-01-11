namespace RickAndMorty.DTOs.Display
{
    public record struct DisplayEpisodeDto(string name, DateTime air_date,
        string episode, ICollection<DisplayCharacterForEpisodeDto> characters);
}
