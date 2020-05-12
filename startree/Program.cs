using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=8; i>0; i--)
            {
                for(int j=0; j<i-1; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<9-i; j++)
                {
                    Console.Write("*");
                    
                }
                for(int j=0; j<8-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
