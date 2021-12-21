using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CodeConvert
{
    class Program
    {
        static ulong CCC(ulong cardcode)
        {
            ulong dst = cardcode << 40;
            return dst >> 40;
        }
        static void Main(string[] args)
        {
           
            ulong max,res;


            // of the array is one line of the file.
            string outfile = args[1];
            string value24;
            string[] lines = System.IO.File.ReadAllLines(args[0]);

            //string[] outpt = new string[];

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("HEX to DEC24 conversion");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine(line);
                max = Convert.ToUInt64(line, 16);
                res = CCC(max);
                 Console.WriteLine(res);
                try { 
                value24 = Convert.ToString(res);
                File.AppendAllText(outfile, value24+Environment.NewLine);
                    //Console.WriteLine(value24);
                    }
                catch {
                File.AppendAllText(outfile, 'scodeerror'+Environment.NewLine);
                      }


                //   outpt.Append(Convert.ToString(res));


            }


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


            //Console.WriteLine(CCC(8598055604));
        }
    }
}
