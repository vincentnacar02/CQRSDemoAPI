using Domain.UserAggregate;
using System;
using System.Collections.Generic;

namespace Domain.UserAggregate
{
    public class User
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        private List<UserAddress> _addresses;

        public User()
        {
            this._addresses = new List<UserAddress>();
        }

        public void AddUserAddress(string address1, string city, string state, string zip, string country)
        {
            var newAddr = new UserAddress
            {
                Address1 = address1,
                City = city,
                State = state,
                Zip = zip,
                Country = country
            };
            _addresses.Add(newAddr);
        }
    }
}
