using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
