using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management..!");
            List<Person> listOfPerson = new List<Person>();
            //UC1 - Creating Person Class and Adding Data
            AddingPersonDetails(listOfPerson);
            Console.ReadLine();
        }
        public static void AddingPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Shiv", Address = "Belgaum", Age = 29 });
            list.Add(new Person() { SSN = 2, Name = "Anand", Address = "Hubli", Age = 10});
            list.Add(new Person() { SSN = 3, Name = "Hari", Address = "Dharwad", Age = 20 });
            list.Add(new Person() { SSN = 4, Name = "Shubham", Address = "Pune", Age = 30 });
            list.Add(new Person() { SSN = 5, Name = "Mahesh", Address = "Mysoor", Age = 56 });
            list.Add(new Person() { SSN = 6, Name = "Prasad", Address = "Mumbai", Age = 70 });
            list.Add(new Person() { SSN = 7, Name = "Raj", Address = "Chikkodi", Age = 66 });
            DisplayPersonDetails(list);
        }

        public static void DisplayPersonDetails(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
