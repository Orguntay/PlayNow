using PlayNow.Abstructers;
using PlayNow.Concrete.Entities;
using PlayNow.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow.Managers
{
    class TurkPersonManager : CrudShema
    {
        readonly IPerson person;
        public TurkPersonManager(IPerson _person)
        {
            person = _person;
        }

        public override void Get()
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + "Listed");
        }
        public override void Save()
        {
            MernisService mernisService = new MernisService();
            TurkPerson turkPerson = new TurkPerson
            {
                Id = 1,
                FirstName = "Celal",
                LastName = "Arnavut",
                TCNo = "66998822"
            };
            if (mernisService.CheckTCNo(turkPerson))
            {
                Console.WriteLine(turkPerson.FirstName + " " + turkPerson.LastName + " saved db");
            }
        }

        public override void Delete()
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " deleted db");
        }

        public override void Update()
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " udated db");
        }

        public void Save(IPerson person)
        {
            throw new NotImplementedException();
        }
    }
}
