using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;

namespace Tasowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> letters = new List<string>();

            using (var reader = new StreamReader(@"C:\Projekty\Tasowanie\dane.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                IList<NumberAndLetter> records = csv.GetRecords<NumberAndLetter>().ToList();

                foreach (var r in records)
                {
                    numbers.Add(r.Number);
                    letters.Add(r.Letter);
                }
            }   
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write(numbers[i] + letters[i]);
            }
        }
    }
}
