using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CapmningManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public CapmningManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
