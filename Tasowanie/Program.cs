using System;
using System.Collections.Generic;
using System.IO;

namespace Tasowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>();

            using (var reader = new StreamReader(@"C:\Projekty\Tasowanie\dane.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    values.Add(line);
                }
            }

            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            listA.Add(values[0]);
            listB.Add(values[1]);

        }
    }
}
