using KodlamaioGameProject.Abstracts;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concretes
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " adlı kampanya eklendi ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " adlı kampanya silindi");
        }

        public void Uptade(Campaign campaign)
        {
            Console.WriteLine(campaign.CompaignName + " adlı kampanya güncellendi");
        }


   
    }
}

