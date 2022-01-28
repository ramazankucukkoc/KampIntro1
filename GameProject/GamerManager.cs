using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
            Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");        }
    }
}
