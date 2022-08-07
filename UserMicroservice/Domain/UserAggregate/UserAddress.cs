using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UserAggregate
{
    public class UserAddress
    {
        public String Address1 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String Country { get; set; }
    }
}
