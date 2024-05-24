using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstProject.classes;

namespace MyFirstProject.classes1
{
    public class Inheritance:InheritanceBase {

        private int result;

        public Inheritance():base(21,26) { 
            Console.WriteLine("Inside derived class constructor");
        }

        public void display() {
            result = base.x+base.y;
            Console.WriteLine($"result is::: {result}");

        }

        public override void Hego() {
            Console.WriteLine("Hego override");
            base.Hego();
        }

        public static void Main(string[] args) {
            int x1 = 23;
            Int32 x2= x1;
            Console.WriteLine(x2);
            Int64 x3 = 89909L;
            long x4 = x3;    
            Console.WriteLine(x4);
            Inheritance inheritance = new Inheritance();
            inheritance.display();
            inheritance.Hego();
            
        }
    }


    
 }
    
public abstract class InheritanceBase {
        protected int x;

        protected int y;

        public InheritanceBase(int a,int b) {
            this.x = a;
            this.y = b;
        }

        public virtual void Hego() {
            Console.WriteLine("hego"); 
        }
    }


 
