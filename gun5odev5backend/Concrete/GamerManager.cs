using gun5odev5backend.Abstract;
using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _uservalidationService;

        public GamerManager(IUserValidationService uservalidationService)
        {
            _uservalidationService = uservalidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_uservalidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + "   Adlı kullanıcı başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Tanımlanamayan kullanıcı");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "   Adlı kullanıcı başarıyla silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "   Adlı kullanıcı başarıyla güncellendi");
        }
    }
}
