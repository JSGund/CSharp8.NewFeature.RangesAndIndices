using System;
using System.Linq;

namespace CSharp8.NewFeature.RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 8.0 New Feature Ranges and Indices");

            string[] techArray = { "C", "C++", "C#", "F#", "JavaScript", "Angular", "TypeScript", "React", "GraphQL" };

            //Example 1
            var techSlice = techArray.Skip(1).Take(3).ToArray();

            foreach (var item in techSlice)
            {
                Console.WriteLine(item);
            }

            //Example 2
            foreach (var item in techArray[1..4])
            {
                Console.WriteLine(item);
            }

            //Example 3
            Range range = 1..4;

            foreach (var item in techArray[range])
            {
                Console.WriteLine(item);
            }

            //Example 4
            Index startIndex = 1;
            Index endIndex = 4;

            foreach (var item in techArray[startIndex..endIndex])
            {
                Console.WriteLine(item);
            }
                       
            //Example 5 - Find last item from list
            var lastOldWay = techArray[techArray.Length - 1];
            Console.WriteLine("Old way : " + lastOldWay + "(techArray[techArray.Length - 1])");

            //Example 5 - Find last item from list
            var lastNewWay = techArray[^1];
            Console.WriteLine("New way : " + lastNewWay + "(techArray[^1])");

            //Example 6
            var welcome = "Welcome to C# Corner!";

            Console.WriteLine(welcome[^10..]);

            //Example 7
            var people = new Person[] {
                new Person("Mangesg", "G"),
                new Person("Jeetendra", "G"),
                new Person("Avinash", "J"),
                new Person("Sai", "B"),
            };

            foreach (var per in people[1..^2])
            {
                Console.WriteLine(per.FirstName + ' ' + per.LastName);
            }

            //Example 8
            foreach (var item in techArray[1..])
            {
                Console.WriteLine(item);
            }

            //Example 9
            foreach (var item in techArray[..3])
            {
                Console.WriteLine(item);
            }

            //Example 10
            foreach (var item in techArray[1..^1])
            {
                Console.WriteLine(item);
            }

            //Example 11
            Console.WriteLine("Jeetendra"[..4]);
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
