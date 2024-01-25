using System.Text.Json.Serialization;

namespace signin_for.Model
{
    public class Bagpack
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }
    }
}
