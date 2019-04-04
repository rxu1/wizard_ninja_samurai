using System;
using System.Collections.Generic;

namespace wizard_ninja_samurai
{
  public class Ninja : Human
  {
    public Ninja (string name) : base (name)
    {
      health = 175; 
    }

    public override int Attack (Human target)
    {
      Random rand = new Random(); 
      int critical = rand.Next(0, 100);
      int dmg = 0; 
      if (critical <= 20)
      {
        dmg = 10 + (Dexterity * 5);
      }
      else 
      {
        dmg = Dexterity * 5; 
      }
      target.Health -= dmg; 
      System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
      return target.Health;
    }

    public int Steal (Human target)
    {
      target.Health -= 5; 
      Health += 5; 
      System.Console.WriteLine($"{Name} has stolen 5 hp from {target.Name}!");
      return target.Health;
    }
  }
}