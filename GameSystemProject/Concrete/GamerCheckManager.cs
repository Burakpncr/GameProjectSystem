using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}
