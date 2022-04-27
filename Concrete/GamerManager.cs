using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    class GamerManager:IGamerService
    {
        IGamerCheckService _gamerCheck;
        string input;
        bool isDel = true;

        public GamerManager(IGamerCheckService gamerCheck)
        {
            _gamerCheck = gamerCheck;
        }
        public void LogIn(Gamer gamer)
        {
            if (_gamerCheck.CheckGamer(gamer))
            {
                Console.WriteLine("Başarıyla Giriş Yaptınız.. Bilgileriniz Doğru!.\nHoşgeldin "+gamer.Ad+"\n");
            }
            else
            {
                throw new Exception("Bilgileriniz Yanlış!!!");
            }
        }

        public void Delete(Gamer gamer)
        {
            var gamerTemp = gamer;
            do
            {
                Console.WriteLine("Üyeliğinizi Silmek İçin 0'ı Tuşlayın..");
                input = Console.ReadLine();
                if (input == "0")
                {
                    Gamer gamerNull = new Gamer();
                    gamerTemp = gamerNull;
                    Console.WriteLine("Üyeliğiniz Silinmiştir..");
                    isDel = false;
                }
            } while (isDel);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("--Kullanıcı Bilgilerini Güncelle-- \nAdınız: " + gamer.Ad + " Soyadınız: " + gamer.SoyAd 
                + " TC Kimlik Numaranız: " + gamer.TcNO + " Doğum Tarihiniz: " + gamer.dateTime
                +"\n");
           
            Console.WriteLine("Adınız: ");
            input = Console.ReadLine();
            gamer.Ad = input;

            Console.WriteLine("Soyadınız: ");
            input = Console.ReadLine();
            gamer.SoyAd = input;

            Console.WriteLine("TC Kimlik Numaranızı silmek için 0 tuşlayın!");
            input = Console.ReadLine();
            if (input == "0")
            {
                gamer.TcNO = "";
            }

            Console.WriteLine("Kullanıcı Bilgileriniz Güncellendi..\nAdınız: " + gamer.Ad + " Soyadınız: " + gamer.SoyAd
                + " TC Kimlik Numaranız: " + gamer.TcNO + " Doğum Tarihiniz: " + gamer.dateTime
                + "\n");
        }
    }
}
