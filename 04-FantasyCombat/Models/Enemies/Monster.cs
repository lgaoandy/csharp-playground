using CombatSystem.Enums;
using CombatSystem.Interfaces;

namespace CombatSystem.Models.Enemies
{
    public class Monster(string name = "Monster", int maxHealth = 50) : ICombatant
    {
        public string Name { get; } = name;
        public int Health { get; private set; } = maxHealth;
        public int MaxHealth { get; } = maxHealth;
        public bool IsAlive { get; private set; } = true;
        public Debuff[] Debuffs { get; } = [];

        public void Attack(ICombatant target)
        {
            Random rnd = new();
            int damage = rnd.Next(1, 4);
            target.TakeDamage(damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= Math.Max(damage, 0);
            if (Health == 0)
            {
                IsAlive = false;
                Console.WriteLine($"{Name} has been slain!");
            }
        }
        
        public void DisplayStatus()
        {
            Console.WriteLine($"{Name}: {Health}/{MaxHealth} HP.");
        }
    }
}