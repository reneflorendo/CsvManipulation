using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class CsvFileHandler
    {
        public static void WritePersonsToCsv(string filePath, IEnumerable<Person> persons)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Write header
                writer.WriteLine("Firstname,Lastname,Email,DateofBirth");

                // Write data
                foreach (var person in persons)
                {
                    writer.WriteLine($"{person.Firstname},{person.Lastname},{person.Email},{person.DateofBirth:yyyy-MM-dd}");
                }
            }
        }

        public static List<Person> ReadPersonsFromCsv(string filePath)
        {
            var persons = new List<Person>();

            using (var reader = new StreamReader(filePath))
            {
                // Read header
                var header = reader.ReadLine();

                // Read data
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var person = new Person
                    {
                        Firstname = values[0],
                        Lastname = values[1],
                        Email = values[2],
                        DateofBirth = DateTime.Parse(values[3])
                    };

                    persons.Add(person);
                }
            }

            return persons;
        }
    }

}
