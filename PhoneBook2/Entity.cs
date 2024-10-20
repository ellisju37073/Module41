using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook2
{
    public abstract class Entity
    {
        #region Properties
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Constructor
        public Entity(Address address, string phoneNumber)
        {
            Address = address;
            PhoneNumber = phoneNumber;
        }
        #endregion

        #region Methods
        public abstract void PrintEntity();
        #endregion
    }
}
