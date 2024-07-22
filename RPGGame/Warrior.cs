public class Warrior : Character
{
    public Warrior(string name) : base(name, 50) { }

    public void Slash(Character target)
    {
        target.TakeDamage(15);
        Console.WriteLine($"{target.Name} takes 15 damage, {target.Health} HP remaining");
    }
}