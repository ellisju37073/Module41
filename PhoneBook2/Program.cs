using System;

namespace PhoneBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a PhoneBook object
            PhoneBook phoneBook = new PhoneBook();

            // Add Business and Person entities to the phonebook
            phoneBook.AddBusinessEntity("Tech Solutions Inc.", "456 Corporate Blvd", "Seattle", "WA", "98109", "206-555-1234");
            phoneBook.AddPersonEntity("John", "Doe", "789 Residential St", "Tacoma", "WA", "98402", "253-555-5678");
            phoneBook.AddPersonEntity("Jane", "Smith", "321 Greenway Dr", "Bellevue", "WA", "98004", "425-555-7890");
            phoneBook.AddBusinessEntity("Creative Agency", "123 Innovation Ln", "Redmond", "WA", "98052", "425-555-2345");

            // Print the phonebook entries
            phoneBook.PrintPhonebook();

            // Test the search method
            Console.WriteLine("\nSearch for 'Smith':");
            phoneBook.Search("Smith");

            Console.WriteLine("\nSearch for 'Tech':");
            phoneBook.Search("Tech");

            Console.WriteLine("\nSearch for 'Nonexistent':");
            phoneBook.Search("Nonexistent");

            // Add more entities to trigger the dynamic array resizing
            for (int i = 0; i < 8; i++)
            {
                phoneBook.AddPersonEntity($"Person{i}", $"Lastname{i}", "Some Address", "Some City", "WA", "99999", $"555-000{i}");
            }

            // Print phonebook after adding more entities
            Console.WriteLine("\nPhonebook after adding more entities (dynamic resizing test):");
            phoneBook.PrintPhonebook();
        }
    }
}
