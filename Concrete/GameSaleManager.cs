using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void SaleGame(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Ad + " adlı oyuncuya " + game.GameName + " oyunu satılmıştır.!");
        }
    }
}
