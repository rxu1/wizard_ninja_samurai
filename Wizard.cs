using System;

namespace wizard_ninja_samurai
{
  public class Wizard : Human
  {
    public Wizard (string name) : base (name)
    {
      Intelligence = 25; 
      health = 50; 
    }
    
    public override int Attack(Human target)
    {
      int dmg = Intelligence * 5; 
      target.Health -= dmg; 
      System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
      health += dmg; 
      return target.Health; 
    }

    public int Heal (Human target)
    {
      int cure = Intelligence * 10; 
      target.Health += cure; 
      System.Console.WriteLine($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
      return target.Health;
    }
  }
}
