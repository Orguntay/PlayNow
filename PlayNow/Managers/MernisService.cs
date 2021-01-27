using PlayNow.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayNow.Managers
{
    public class MernisService
    {
        public bool CheckTCNo(TurkPerson person)
        {
            if (person.TCNo == "66998822" && person.FirstName == "Engin" && person.LastName == "Demiroğ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
