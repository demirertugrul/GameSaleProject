using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstract
{
    public interface IGamerService
    {
        void LogIn(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer); 
    }
}
