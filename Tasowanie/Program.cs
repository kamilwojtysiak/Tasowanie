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

            NumbersAndLettersReader reader = new NumbersAndLettersReader();

            foreach (var r in reader.GetNumberAndLetter())
            {
                numbers.Add(r.Number);
                letters.Add(r.Letter);
            }
            
            for (int i = 0; i < letters.Count; i++)
            {
                Console.Write(numbers[i] + letters[i]);
            }
        }
    }
}
