using PlayNow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow
{
    public class Player : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Level { get; set; }

    }
}
