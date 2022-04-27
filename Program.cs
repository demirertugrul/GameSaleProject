using GameSaleProject.Abstract;
using GameSaleProject.Concrete;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Gamer gamer1 = new Gamer { Ad = "Ertugrul", TcNO = "11111111111", dateTime = new DateTime(2022, 1, 1), SoyAd = "Demir" };
            IGamerService gamerManager = new GamerManager(new GamerCheckManager());
            GameSaleManager gameSaleManager = new GameSaleManager();
            Campaign campaign1 = new Campaign{CampaingName = "GTA 5 %50 İNDİRİM"};
            Campaign campaign2 = new Campaign{CampaingName = "PUBG %30 İNDİRİM" };
            Campaign campaign3 = new Campaign{CampaingName = "Fortnite %40 İNDİRİM" };
            CampaignCheckManager campaignCheckManager = new CampaignCheckManager();
            List<Campaign> campaigns = new List<Campaign> { campaign1, campaign2, campaign3 };
            //Game Basic Simulation
            Console.WriteLine("Merhaba, Yapmak istediğniz işlemi seçiniz : \n 1- Giriş\t2- Çıkış");
            input = Console.ReadLine();
            if (input == "1")
            {
                gamerManager.LogIn(gamer1);
                Console.Clear();
                Console.WriteLine("Oyun satışı için 1'i,\nKullanıcı güncellemek için 2'yi,\nKullanıcıyı silmek için 3'ü tuşlayın\n" +
                    "Kampanya Eklemek/Silmek/Güncellemek için 4'ü Tuşlayın");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("--- Kampanyalar ---");
                        foreach (var camp in campaigns)
                        {
                            Console.WriteLine(camp.CampaingName);
                        }
                        Console.WriteLine("Almak istediğniz oyunun ismini giriniz : \n");
                        input = Console.ReadLine();
                        Console.WriteLine("Oyun İndirimi Uygulandı..!");
                        gameSaleManager.SaleGame(new Game { GameId = 1, GameName = input }, gamer1);
                        break;
                    case "2":
                        Console.Clear();
                        gamerManager.Update(gamer1);
                        break;
                    case "3":
                        Console.Clear();
                        gamerManager.Delete(gamer1);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Ekle-1 Sil-2 Güncelle-3");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Kampanya ismini gir : ");
                                input = Console.ReadLine();
                                campaigns.Add(new Campaign { CampaingName = input });
                                var newCampList1 = campaignCheckManager.AddCampaign(campaigns);
                                Console.WriteLine("Yeni Liste : ");
                                foreach (var newCamp in newCampList1)
                                {
                                    Console.WriteLine(newCamp.CampaingName);
                                }
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Silmek istediğiniz kampanyayı seçin.");
                                for (int i = 0; i < campaigns.Count; i++)
                                {
                                    Console.WriteLine((i+1)+":"+campaigns.ToArray()[i].CampaingName);
                                }
                                input = Console.ReadLine();
                                var newCampList2 = campaignCheckManager.Delete(campaigns,input);
                                Console.WriteLine("Yeni Liste : ");
                                foreach (var newCamp in newCampList2)
                                {
                                    Console.WriteLine(newCamp.CampaingName);
                                }
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Güncellemek istediğiniz kampanyayı seçin.");
                                for (int i = 0; i < campaigns.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + ":" + campaigns.ToArray()[i].CampaingName);
                                }
                                input = Console.ReadLine();
                                var newCampList3 = campaignCheckManager.Update(campaigns, input);
                                Console.WriteLine("Yeni Liste : ");
                                foreach (var newCamp in newCampList3)
                                {
                                    Console.WriteLine(newCamp.CampaingName);
                                }
                                break;
                        }
                        break;
                }
            }
        }
    }
}
