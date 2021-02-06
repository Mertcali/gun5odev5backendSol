using gun5odev5backend.Abstract;
using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Mert" && gamer.BirthYear == 1998 && gamer.LastName == "ÇALIŞ" && gamer.NationalityId == "12345678910")
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
