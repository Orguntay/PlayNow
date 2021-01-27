using PlayNow.Abstructers;
using PlayNow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow.Managers
{
    public class PersonManager : CrudShema
    {
        readonly IPerson person;
        public PersonManager(IPerson _person)
        {
            person = _person;
        }
        public override void Get()
        {
            Console.WriteLine("listed persons");
        }

        public override void Save()
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " saved db");
        }

        public override void Delete()
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " deleted db");
        }

        public override void Update()
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " udated db");
        }
    }
}
