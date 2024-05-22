using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.classes
{
    public class TypesExplore
    {
      private  float f1 = 29.5F;
      private  Single f2;

      public void Display() {
        f2= Convert.ToSingle(f1);

        Console.WriteLine("f1=" + f1);
        Console.WriteLine("f2=" + f2);
      }

        // public static void Main(string[] args) {
        //     TypesExplore typesExplore = new();
        //     typesExplore.Display();
        // }

    }   
}