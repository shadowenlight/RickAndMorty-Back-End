using AutoMapper;
using RickAndMorty.DTOs.Display;
using RickAndMorty.DTOs.Save;
using RickAndMorty.Models;

namespace RickAndMorty.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {            
            //Episode to DisplayEpisodeDto
            CreateMap<Episode, DisplayEpisodeDto>()
                .ForMember(to => to.characters, from => from.MapFrom(src => src.characters));

            //Character to DisplayCharacterDto
            CreateMap<Character, DisplayCharacterDto>()
                .ForMember(to => to.episode, from => from.MapFrom(src => src.episode));

            //Character to CharacterDisplayForEpisodeDto
            CreateMap<Character, DisplayCharacterForEpisodeDto>()
                .ForMember(to => to.name, from => from.MapFrom(src => src.name));

            //Character to CharacterDisplayForEpisodeDto
            CreateMap<Episode, DisplayEpisodeForCharacterDto>()
                .ForMember(to => to.name, from => from.MapFrom(src => src.name));
        }
    }
}
