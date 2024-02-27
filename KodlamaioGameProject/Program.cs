using KodlamaioGameProject.Concretes;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign1 = new Campaign { CompaignId="1", CompaignName="New Year"  };
            Campaign campaign2 = new Campaign { CompaignId = "2", CompaignName = "Winter Sale" };
           

            Game game1 = new Game { Id = 9, Name = "PlayStation", UnitPrice=10  };
            Game game2 = new Game { Id = 8, Name = "GTA", UnitPrice = 15 };

            Gamer gamer1 = new Gamer { Id = 1,  Name = "Burcu",  Surname = "Çayan", BirthYear=1989 };
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                 Surname = "Çayan",
                 Name = "Ege",
                 BirthYear = 2011,
            };

            Gamer[] gamers = new Gamer[] { gamer1, gamer2 };


            foreach (var gamer in gamers)
            {
                Console.WriteLine($"ID: {gamer.Id}, Name: {gamer.Name }, Surname: {gamer.Surname}, BirthYear: {gamer.BirthYear}");
            }

           CampaignManager campaignManager1 = new CampaignManager();
           campaignManager1.Add(campaign1);
           campaignManager1.Delete(campaign2);
             

            Console.ReadLine();
        }
    }
}    
