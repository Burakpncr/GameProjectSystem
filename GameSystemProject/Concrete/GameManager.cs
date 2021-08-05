using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Ekleme İşlemi Tamamlandı");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silme İşlemi Tamamlandı");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncelleme İşlemi Tamamlandı");
        }
    }
}
