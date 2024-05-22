using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyFirstProject.classes
{
    public class PrimaryConstructor(int firstNum,int secondNum)
    {
        
        
        public int FirstNum { get; set; } = firstNum;

        public int SecondNum { get; set;} = secondNum;

        // public static void Main() {
        //     PrimaryConstructor primaryConstructor= new PrimaryConstructor(1, 72);
        //     var result = primaryConstructor.CalculateNew();
        //     var result1 = primaryConstructor.Calc(26L,5L);
        //     Console.WriteLine(result);
        //     Console.WriteLine(result1);
        // }


        public Int32 CalculateNew() {
            return FirstNum+SecondNum;
        }

        public Int64 Calc(long a,long b) {
            return a-b;
        }
    }
}