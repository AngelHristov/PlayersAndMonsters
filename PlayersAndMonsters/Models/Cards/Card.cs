using PlayersAndMonsters.Models.Cards.Contracts;

namespace PlayersAndMonsters.Models.Cards
{
    public class Card : ICard
    {
        public string Name { get; }

        public int DamagePoints { get; set; }

        public int HealthPoints { get; }
    }
}
