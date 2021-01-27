using PlayNow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow.Concrete.Entities
{
    public class TurkPerson : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCNo { get; set; }
    }
}
