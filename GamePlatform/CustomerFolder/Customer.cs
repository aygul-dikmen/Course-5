using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.CustomerFolder
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityID { get; set; }

    }
}
