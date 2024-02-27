using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstracts
{
    public interface ICampaignService // arayüz
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Uptade(Campaign campaign);

    }
}
