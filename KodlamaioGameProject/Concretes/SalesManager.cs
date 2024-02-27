using KodlamaioGameProject.Abstracts;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concretes
{
    public class SalesManager : ISalesService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name+" "+gamer.Name+" isimli oyunu satın aldı");
        }
        public void SaleGameWithGame(Gamer gamer, Game game, Campaign compaign)
        {
            decimal discountedPrice = game.UnitPrice - compaign.DiscountAmount;
            Console.WriteLine($"{gamer.Name}{gamer.Surname}{game.Name}{compaign.CompaignName} ile satin alindi");

        }
    }
}
