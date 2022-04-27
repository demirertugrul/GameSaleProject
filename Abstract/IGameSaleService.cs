using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstract
{
    public interface IGameSaleService
    {
        void SaleGame(Game game,Gamer gamer); 
        //.
    }
}
