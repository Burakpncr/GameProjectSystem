using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Add(List<Game> orderGames, Gamer gamer, List<Campaign> campaigns)
        {
            int total = 0;
            int campaignTotal = 0;
            int campaignRate = 0;
            Console.WriteLine(orderGames.Count);

            for (int i = 0; i < orderGames.Count; i++)
            {
                Console.WriteLine(orderGames[i].GameName);
                total = total + orderGames[i].GamePrice;
            }
            if (campaigns.Count > 0)
            {
                for (int j = 0; j < campaigns.Count; j++)
                {
                    campaignRate = campaignRate + campaigns[j].DiscountRate;
                    campaignTotal = total * campaignRate;
                    campaignTotal = campaignTotal / 100;
                    total = total - campaignTotal;
                }
                total = campaignRate > 100 ? 0 : total;
            }
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satın Alma İşleminiz Başarıyla Tamamlanmıştır Ödediğiniz Fiyat : " + total + " TL");
        }
    }
}
