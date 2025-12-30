interface ICombatant
{
    string Name { get; }
    int Health { get; }
    int MaxHealth { get; }
    bool IsAlive { get; }
    void Attack(ICombatant target);
    void TakeDamage(int amount);
    void DisplayStatus();
}

abstract class Character : ICombatant
{
    public string Name { get; }
    public int Health { get; private set; }
    public int MaxHealth { get; }
    public bool IsAlive { get; private set } = true;
    protected int BaseDamage { get; } = 1;
    protected bool IsEmpowered { get; private set } = false;

    // Constructor
    public Character(string name = "", int maxHealth = 100)
    {
        Name = name;
        Health = maxHealth; // Initialize current health to max health
        MaxHealth = maxHealth;
    }

    // Common Methods
    public void Attack(ICombatant target)
    {
        if (IsEmpowered)
        {
            IsEmpowered = false;
            target.TakeDamage(BaseDamage * 2);
        }
        else
        {
            target.TakeDamage(BaseDamage);
        }
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        // Check if character is still alive
        if (Health < 0)
        {
            IsAlive = false;
            Console.WriteLine($"{Name} has been slain!");
        }
        else
        {
            Console.WriteLine($"{Name} has substained damage with {Health} HP left");
        }
    }

    public void DisplayStatus()
    {
        if (IsAlive)
        {
            Console.WriteLine($"{Name} is alive, with {Health}/{MaxHealth} HP");
        }
        else
        {
            Console.WriteLine($"{Name} is dead");
        }
    }

    // Specific Methods
    public abstract void CalculateAttackDamage();

    public virtual void SpecialAbility(ICombatant target)
    {
        IsEmpowered = true;
    }
}