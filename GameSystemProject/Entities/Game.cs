using GameSystemProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public string GameCategory { get; set; }
    }
}
