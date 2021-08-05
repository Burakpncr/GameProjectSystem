using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Adlı Oyuncu Sisteme Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Oyuncu Yanlış bilgi girdi");
            }

        }



        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.FirstName );
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + gamer.FirstName);
        }

      
    }
}
