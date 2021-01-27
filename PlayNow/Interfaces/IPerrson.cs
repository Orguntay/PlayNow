using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow.Interfaces
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
