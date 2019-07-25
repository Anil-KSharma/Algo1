using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Anagram("abcd","abcd");
            int[] arr = { 10, 1, 8, 4, 5, 6 };
            p.ArrayMax(arr);
            Console.ReadKey();
        }
	// Retrieving max value from an array.
        public void ArrayMax( int[] value)
        {
            int mv=int.MinValue;
            foreach (var item in value)
            {
                if (mv<item)
                {
                    mv = item;
                }
            }
            Console.Write(mv);
        }
	//Anagram implementation.
        public void Anagram(string A, string B)
        {
            string sb = "Anagram true !";
            int acount=0,bcount=0;
            string[] arr, brr;

            foreach(var a in A)
            {
                if (acount==bcount&& A.Length==B.Length)
	            {
		 
                    foreach (var aa in A)
                    {
                        if (a==aa)
	                    {
		                    acount++;
	                    }
                    }
                    foreach (var b in B)
	                {
                            if (a==b)
	                        {
		                        bcount++;
	                        }
	                }   
                }
                else
                {
                    sb = "Anagram False !";
                }
            }

            Console.Write(sb);
        }
    }
}
