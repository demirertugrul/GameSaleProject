using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    class CampaignCheckManager : ICampaignCheckService
    {
        string input;//..
        public List<Campaign> AddCampaign(List<Campaign> campaigns)
        {
            var campArr = campaigns.ToArray();
            var campLast = campArr[campArr.Length - 1];
            campaigns.Add(campLast);
            Console.WriteLine("Yeni Kampanya Eklendi. " + campLast.CampaingName);
            return campaigns;
        }

        public List<Campaign> Delete(List<Campaign> campaigns,string input)
        {
            int numberDeleting = Convert.ToInt32(input);
            var tempCampArr = campaigns.ToArray()[numberDeleting-1];
            campaigns.Remove(tempCampArr);
            Console.WriteLine("Bu kampanya Silindi " + tempCampArr.CampaingName);
            return campaigns;
        }

        public List<Campaign> Update(List<Campaign> campaigns,string input)
        {
            int numberDeleting = Convert.ToInt32(input);
            var tempCampArr = campaigns.ToArray()[numberDeleting - 1];
            Console.WriteLine("Bu kampanya Güncellendi " + tempCampArr.CampaingName);
            return campaigns;
        }
    }
}
