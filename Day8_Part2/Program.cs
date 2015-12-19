using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines(@".\Day8Part2.txt");

            int totalRealStringLength = 0;


            foreach (string line in lines)
            {

               
                int realStringLength = 2;

                for (int i = 0; i < line.Length; ++i)
                {

                    if (line[i] == '\\')
                    {
                        realStringLength += 2;


                    }
                    else if (line[i] == '\"') // "
                    {
                        realStringLength += 2;
                    }
                    else
                    {
                        ++realStringLength;
                    }

                }

                totalRealStringLength += realStringLength;
            }
            
            int total = totalRealStringLength - 6489; // 6489 = vaalue found in part 1

            Console.WriteLine(total);

        }
    }
}
