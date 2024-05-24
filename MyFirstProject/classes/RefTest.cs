using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.classes
{
    public class RefTest
    {

        private int y =10;
        private int result1;

        private int z = 25;

        // public static void Main(string[] args) {
        //     RefTest refTest= new RefTest();
        //     Console.WriteLine($"y={refTest.y}");
        //     refTest.manipulate(ref refTest.y,out refTest.result1,in refTest.z);
        //     Console.WriteLine($"now y={refTest.y}");
        //     Console.WriteLine("result1="+refTest.result1);
        //     refTest.switches(2);
        // }
 
        public void manipulate(ref int x,out int result,in int z) {
            Console.WriteLine("x=" + x);
            Console.WriteLine($"z={z}");
            x += 10;
            result = x;
            Console.WriteLine("Now x=" + x);
        }

        public void switches(int ch) {
            switch(ch) {
                case 0:
                Console.WriteLine("0");
                break;
                case 1:
                case 2:
                Console.WriteLine("1 or 2");
                break;
                default:
                Console.WriteLine("default");
                    break;  
            }
        }
    }


}