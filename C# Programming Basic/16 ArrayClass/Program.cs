using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays class
            int[] ages = { 12, 34, 54, 35, 55, 76, 56 };
            
            //length
            //Console.WriteLine(ages.Length);

            //indexof
            int index = Array.IndexOf(ages, 54);
            //Console.WriteLine("index :" +index);

            //clear
            Array.Clear(ages, 0, 2);
            foreach (int age in ages)
            {
                //Console.WriteLine(age);
            }

            //copy
            int[] newArrays = new int[7];
            Array.Copy(ages, newArrays, ages.Length);
            foreach (int age in newArrays)
            {
                //Console.WriteLine(age);
            }

            //sort
            Array.Sort(newArrays);
            foreach (int age in newArrays)
            {
                //Console.WriteLine(age);
            }

            Array.Reverse(newArrays);
            foreach(int age in newArrays)
            {
                Console.WriteLine(age);
            }

            Console.ReadLine();
        }
    }
}
