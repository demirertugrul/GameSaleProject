using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstract
{
    public interface ICampaignCheckService
    {
        List<Campaign> AddCampaign(List<Campaign> campaigns);
        List<Campaign> Delete(List<Campaign> campaigns,string input);
        List<Campaign> Update(List<Campaign> campaigns,string input);
    }
}
