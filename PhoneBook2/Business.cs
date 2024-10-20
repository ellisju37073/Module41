using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook2
{
    public class Business : Entity
    {
        #region Properties
        public string BusinessName { get; set; }
        #endregion

        #region Constructor
        public Business(string businessName, Address address, string phoneNumber)
            : base(address, phoneNumber)
        {
            BusinessName = businessName;
        }
        #endregion

        #region Methods
        public override void PrintEntity()
        {
            Console.WriteLine($"{BusinessName}");
            Address.PrintAddress();
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
        #endregion
    }
}