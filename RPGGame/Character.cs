public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(Character target)
    {
        target.TakeDamage(10);
        Console.WriteLine($"{target.Name} takes 10 damage, {target.Health} HP remaining");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }
}