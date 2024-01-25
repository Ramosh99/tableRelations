namespace signin_for.Model
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Bagpack Bagpack { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Faction> Factions { get; set; } 

    }
}
