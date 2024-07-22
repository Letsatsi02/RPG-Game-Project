public class Mage : Character
{
    public Mage(string name) : base(name, 50) { }

    public void Fireball(Character target)
    {
        target.TakeDamage(20);
        Console.WriteLine($"{target.Name} takes 20 damage, {target.Health} HP remaining");
    }
}