using GameSystemProject.Abstract;
using GameSystemProject.Adapters;
using GameSystemProject.Concrete;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;

namespace GameSystemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.DateOfBirth = new DateTime(2000, 8, 24);
            gamer1.FirstName = "Hüseyin Burak";
            gamer1.LastName = "Pancar";
            gamer1.NationalityId = "14707495120";

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "PES 2021";
            game1.GameCategory = "Futbol";
            game1.GamePrice = 20;
            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "NBA 2021";
            game2.GameCategory = "Basketbol";
            game2.GamePrice = 25;
            Game game3 = new Game();
            game3.Id = 3;
            game3.GameName = "Call Of Duty";
            game3.GameCategory = "Savaş";
            game3.GamePrice = 30;
            List<Game> orderGames = new List<Game>() { game2, game3 };
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yeni Oyuncu Kampanyası";
            campaign1.DiscountRate = 50;

            SaleManager saleManager = new SaleManager();
            // bir satışta birden fazla kampanya olabileceği için kampanya listesi oluşturdum
            List<Campaign> campaigns = new List<Campaign>() { campaign1 };
            saleManager.Add(orderGames, gamer1, campaigns);


        }
    }
}
