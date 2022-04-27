using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;

namespace GameSaleProject
{
    internal class GamerCheckManager : IGamerCheckService
    {
        Gamer localGamer = new Gamer { Ad = "Ertugrul", TcNO = "11111111111", dateTime = new DateTime(2022, 1, 1), SoyAd = "Demir" };
        public bool CheckGamer(Gamer gamer)
        {
            return localGamer.Ad == gamer.Ad && localGamer.TcNO == gamer.TcNO && localGamer.dateTime == gamer.dateTime && localGamer.SoyAd == gamer.SoyAd;
        }
    }
}