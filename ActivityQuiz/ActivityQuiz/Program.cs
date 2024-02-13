using System;
using System.Collections.Generic;

namespace PersonWeightTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Console.WriteLine("Welcome to the Person Weight Tracker!");

            bool addingPeople = true;
            while (addingPeople)
            {
                Console.WriteLine("\nEnter the name of the person (or type 'done' to finish adding people):");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                {
                    addingPeople = false;
                }
                else
                {
                    Console.WriteLine("Enter the weight of the person:");
                    if (int.TryParse(Console.ReadLine(), out int weight))
                    {
                        people.Add(new Person(name, weight));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid weight.");
                    }
                }
            }

            Console.WriteLine("\nList of People and their Weights:");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}: {person.Weight} kg");
            }

            int totalWeight = CalculateTotalWeight(people);
            Console.WriteLine($"\nTotal Weight of all People: {totalWeight} kg");
        }

        static int CalculateTotalWeight(List<Person> people)
        {
            int totalWeight = 0;
            foreach (Person person in people)
            {
                totalWeight += person.Weight;
            }
            return totalWeight;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Person(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
