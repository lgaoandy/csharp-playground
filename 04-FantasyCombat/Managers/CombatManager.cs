using CombatSystem.Interfaces;
using CombatSystem.Models.Characters;
using CombatSystem.Models.Enemies;
using CombatSystem.Enums;

namespace CombatSystem.Managers.CombatManager
{
    public class CombatManager
    {
        public static void Introduce(Warrior w)
        {
            Console.WriteLine($"{w.Name} is a warrior with {w.Strength} strength and {w.Health} HP!");
        }

        public static void Introduce(Elementalist e)
        {
            Console.WriteLine($"{e.Name} is a {e.Intelligence} intelligence elementalist with {e.Health} HP and {e.Mana} MP!");
        }

        public static void Introduce(Monster m)
        {
            Console.WriteLine($"{m.Name} is a monster with {m.Strength} strength and {m.Health} HP!");
        }

        public static void Fight(ICombatant c1, ICombatant c2)
        {
            int round = 0;
            ICombatant attacker = c1;
            ICombatant defender = c2;

            while (c1.IsAlive && c2.IsAlive)
            {
                // Announce every 2 rounds
                Console.WriteLine($"----- Round {round / 2 + 1} -----");

                // warriors try to use special ability whenever possible
                if (attacker is Warrior warrior && warrior.SpecialAbility(defender))
                {
                    continue;
                }

                // elementalists should swap elements when the enemy is immolated or frostbitten
                if (attacker is Elementalist elementalist)
                {
                    if (defender.Debuffs.Any(d => d == Debuff.FrostBitten || d == Debuff.Immolated))
                    {
                        if (elementalist.SpecialAbility(defender))
                        {
                            continue;
                        }
                    }
                }

                // standard attack
                attacker.Attack(defender);
                (attacker, defender) = (defender, attacker);
            }

            // Annouce winner
            Console.WriteLine($"{defender.Name} is victorious!");
        }
    }
}