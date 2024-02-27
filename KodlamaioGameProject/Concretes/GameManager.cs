using KodlamaioGameProject.Abstracts;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concretes
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine( game.Name +" Oyunu eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name+ "Oyunu silindi");
        }
    }
}
