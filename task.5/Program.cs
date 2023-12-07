using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace task._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 9 словами");
           
            string userinput = Console.ReadLine(); ;
            
            string[] numstr = new string[10]{ "zero", "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine" };
            int index = 0;
            for (int i = 0; i < numstr.Length; i++,index++)
            {
                if(numstr[i]==userinput)
                {
                    Console.WriteLine(index);
                    break;
                }
            
            }
            Console.ReadKey();
            
        }
    }
}
