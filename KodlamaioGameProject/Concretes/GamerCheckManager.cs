using KodlamaioGameProject.Abstracts;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concretes
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.Name == "Ege" && gamer.BirthYear == 2011 && gamer.NationalityId == "1548798745")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
