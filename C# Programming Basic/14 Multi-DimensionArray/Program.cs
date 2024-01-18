using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Multi_DimensionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] ages = new int[5];

            //rectangular vs jagged
            int[,] datas = new int[3, 2]
            {
                {2,3}, 
                {3,4}, 
                {4,5}
            };
            datas[2, 1] = 100;

            //Console.WriteLine(datas[2,1]);

            int[,] numbers = new int[3, 4]
            {
                {1,2,3,4 },
                {2,3,4,5},
                {3,4,5,6}
            };
            //Console.WriteLine(numbers[0,3]);

            //jagged array
            int[][] values = new int[3][];
            values[0] = new int[] { 1};
            values[1] = new int[] { 1,2,3,4,5,6};
            values[2] = new int[] { 1, 2};

            for(int i = 0;i < values.Length;i++)
            {
                for(int j = 0; j < values[i].Length;j++)
                {
                    Console.Write(values[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
