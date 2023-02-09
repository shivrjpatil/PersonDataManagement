﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class PersonDataManagement
    {
        public static void RetrieveTop2Below60(List<Person> list)
        {
            var top2 = list.Where(p => p.Age < 60).OrderBy(p => p.Age).Take(2);
            Console.WriteLine("\nTop 2 Person less than Age 60");
            Program.DisplayPersonDetails(top2);
        }
        public static void AgeBetween13to18(List<Person> list)
        {
            var teenage = list.Where(p => p.Age > 13 && p.Age < 18);
            Console.WriteLine("\nRecord found Betwwen Age 13 to 18");
            Program.DisplayPersonDetails(teenage);
        }
        public static void AverageAge(List<Person> list)
        {
            var avgAge = list.Average(p => p.Age);
            Console.WriteLine("\nAverage Age is : " + Math.Round(avgAge, 2));
        }
        public static void NameCheck(List<Person> list, string input)
        {
            var result = list.Where(p => p.Name == input).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine("\nName is Present");
            }
            else
            {
                Console.WriteLine("\nName is not Present");
            }
        }
        public static void SkipLessThan60(List<Person> list)
        {
            var skipAge = list.SkipWhile(p => p.Age < 60);
            Console.WriteLine("\nSkip record from the list for age is less than 60");
            Program.DisplayPersonDetails(skipAge);
        }
    }
}
