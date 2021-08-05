using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Abstract
{
    interface ISaleService
    {
        void Add(List<Game> orderGames, Gamer gamer, List<Campaign> campaigns);
    }
}
