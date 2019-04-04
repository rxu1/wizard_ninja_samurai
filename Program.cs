using System;
using System.Collections.Generic;

namespace wizard_ninja_samurai
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");
      Wizard raymond = new Wizard("Raymond");
      // Wizard harry = new Wizard("Harry Potter");
      // raymond.Attack(harry);
      Ninja gaiden = new Ninja("Ninja Gaiden");
      gaiden.Steal(raymond);
      gaiden.Attack(raymond); 
      System.Console.WriteLine(raymond.Health);
    }
  }
}
