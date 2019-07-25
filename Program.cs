using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            dynamic[] arr = { "a",2,"c","d","e","f","g",1,2};
            p.ArrayInsert(arr,2);
            Console.ReadLine();
        }
        public void ArrayInsert(dynamic[] arr,int size)
        {
            int c = 0;
            int ds = ((arr.Length) / size)+((Convert.ToDecimal(arr.Length) % size) > 0 ? 1 : 0);
            dynamic[,] darr = new dynamic[ds, size];
            for (int i = 0; i < darr.GetLength(0); i++)
            {
                if (c < arr.Length)
                {
                    for (int j = 0; j < darr.GetLength(1); j++)
                    {
                        if (arr.ElementAtOrDefault(c) != null)
                        {
                            dynamic val = arr[c];
                            if (darr[i, j] == null)
                                darr[i, j] = val;
                        }
                        c++;
                        Console.Write(darr[i, j]+"\t");
                    }
                    Console.WriteLine();
                }
                else
                    break;
            }
        }
    }
}
