using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Tasowanie
{
    public class NumbersAndLettersReader
    {
        IList<NumberAndLetter> record = new List<NumberAndLetter>();

        public IList<NumberAndLetter> GetNumberAndLetter()
        {
            using (var reader = new StreamReader(@"C:\Projekty\Tasowanie\dane.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                record = csv.GetRecords<NumberAndLetter>().ToList();
            }

            return record;
        }
    }
}
