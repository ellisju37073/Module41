using System;

namespace PhoneBook2
{
    public class PhoneBook
    {
        #region Fields
        private Entity[] entities;
        private int entityCount;
        #endregion

        #region Constructor
        public PhoneBook()
        {
            entities = new Entity[10];
            entityCount = 0; // Keeps track of how many entities have been added
        }
        #endregion

        #region Methods
        // Method to dynamically resize the array if it's full
        private void ResizeArray()
        {
            int newSize = entities.Length * 2;
            Entity[] newEntities = new Entity[newSize];
            for (int i = 0; i < entities.Length; i++)
            {
                newEntities[i] = entities[i];
            }
            entities = newEntities;
        }

        public void AddEntity(Entity entity)
        {
            if (entityCount >= entities.Length)
            {
                ResizeArray(); // Resize array if it's full
            }

            entities[entityCount] = entity;
            entityCount++;
        }

        public void AddBusinessEntity(string businessName, string streetAddress, string city, string state, string zip, string phoneNumber)
        {
            Address address = new Address(streetAddress, city, state, zip);
            Business business = new Business(businessName, address, phoneNumber);
            AddEntity(business);
        }

        public void AddPersonEntity(string firstName, string lastName, string streetAddress, string city, string state, string zip, string phoneNumber)
        {
            Address address = new Address(streetAddress, city, state, zip);
            Person person = new Person(firstName, lastName, address, phoneNumber);
            AddEntity(person);
        }

        public void PrintPhonebook()
        {
            Console.WriteLine("Phonebook Entries:");
            for (int i = 0; i < entityCount; i++)
            {
                if (entities[i] != null)
                {
                    entities[i].PrintEntity();
                    Console.WriteLine();
                }
            }
        }

        // Search method to find entities based on the beginning of the business name or last name
        public void Search(string str)
        {
            bool found = false;
            str = str.ToLower(); // Convert the search string to lowercase for comparison

            for (int i = 0; i < entityCount; i++)
            {
                if (entities[i] is Business business)
                {
                    // Check if the business name starts with the search string
                    if (business.BusinessName.ToLower().StartsWith(str))
                    {
                        Console.WriteLine("Search result:");
                        business.PrintEntity();
                        found = true;
                    }
                }
                else if (entities[i] is Person person)
                {
                    // Check if the person's last name starts with the search string
                    if (person.LastName.ToLower().StartsWith(str))
                    {
                        Console.WriteLine("Search result:");
                        person.PrintEntity();
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Search failed. No matching entity found.");
            }
        }
        #endregion
    }
}
