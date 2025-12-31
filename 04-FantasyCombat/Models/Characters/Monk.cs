using CombatSystem.Interfaces;

namespace CombatSystem.Models.Characters
{
    public class Monk(string name, int constitution, int maxHealth) : Character
    {
        public override string Name { get; } = name;
        public override int Health { get; set; } = maxHealth;
        public override int MaxHealth { get; } = maxHealth;
        protected override int BaseDamage { get; } = 2;
        protected override string SpecialAbilityName { get; } = "Radiant Sunder";

        public int Constitution = constitution;

        protected override int CalculateAttackDamage()
        {
            Random rnd = new();
            int minHit = BaseDamage + (int)Math.Floor(Constitution / 2.5);
            int maxHit = 2 + (int)Math.Ceiling(Constitution * 0.85);
            int dmg = rnd.Next(minHit, maxHit);
            int critChance = rnd.Next(0, 101);

            if (critChance > 90)
            {
                return dmg * 2;
            }
            return dmg;
        }

        public override bool SpecialAbility(ICombatant target)
        {
            int damage = CalculateAttackDamage();
            target.TakeDamage(damage + (int)Math.Round(Constitution * 1.25));
            Health = Math.Min(MaxHealth, Health + Constitution);
            Console.WriteLine($"{Name} uses {SpecialAbilityName} on {target.Name} for {damage} damage, and healing {Constitution} HP!");
            return true;
        }
    }
}