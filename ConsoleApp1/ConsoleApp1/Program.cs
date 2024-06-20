using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample data
            var persons = new List<Person>
        {
            new Person { Firstname = "John", Lastname = "Doe", Email = "john.doe@example.com", DateofBirth = new DateTime(1980, 1, 1) },
            new Person { Firstname = "Jane", Lastname = "Smith", Email = "jane.smith@example.com", DateofBirth = new DateTime(1990, 2, 2) }
        };

            string filePath = "persons.csv";

            // Write data to CSV
            CsvFileHandler.WritePersonsToCsv(filePath, persons);

            // Read data from CSV
            var readPersons = CsvFileHandler.ReadPersonsFromCsv(filePath);

            // Display read data
            foreach (var person in readPersons)
            {
                Console.WriteLine($"{person.Firstname} {person.Lastname} - {person.Email} - {person.DateofBirth.ToShortDateString()}");
            }

            Console.Read();
        }
    }



}
