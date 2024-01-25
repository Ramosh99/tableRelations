using signin_for.DTOs;

namespace EntityFramework7Relationships.DTOs
{
    public record struct CharacterCreateDto(
        string Name,
        BackpackCreateDto Bagpack,
        List<WeaponCreateDto>Weapons,
        List<FactionCreateDto>Factions
        );

}
