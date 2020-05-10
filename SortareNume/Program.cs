using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortareNume
{
    class Program
    {
        static char[] delimiterChars = { ' ', ';', ',', '.', ':', '!', '?', '\t' };
        public static Person lineToPerson(string line)
        {
            string[] delimitedLines = line.Split(delimiterChars);

            List<string> validNames = new List<string>();

            foreach (string name in delimitedLines)
            {
                if (!name.Equals(""))
                {
                    validNames.Add(name);
                }
            }

            int validNamesCount = validNames.Count();
            string[] firstNames = new string[validNamesCount - 1];

            
            p.lastName = p.formatName(delimitedLines[0]);
            for (int i = 1; i < validNamesCount; i++)
            {
                p.AddFirstName(validNames.ElementAt(i));
            }


            return p;

        }

        static void Main(string[] args)
        {
            // read the file lines
            List<string> lines = FileIO.file_Reader("../../input.txt");

            // process the file lines

            List<Person> persons = new List<Person>();
            Console.WriteLine("Read and created persons");
            foreach (string line in lines)
            {
                Person p = lineToPerson(line);
                persons.Add(p);
                Console.WriteLine(p.ToString());

            }
            Console.WriteLine();

            // sort the person list
            Console.WriteLine("Sorted List:");
            persons.Sort();

            for (int i = 0; i < persons.Count(); i++)
            {
                Console.WriteLine(persons.ElementAt(i).ToString());
            }
            Console.WriteLine();
        }

    }
}