using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook2
{
    public class Person : Entity
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Constructor
        public Person(string firstName, string lastName, Address address, string phoneNumber)
            : base(address, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Methods
        public override void PrintEntity()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Address.PrintAddress();
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
        #endregion
    }
}
