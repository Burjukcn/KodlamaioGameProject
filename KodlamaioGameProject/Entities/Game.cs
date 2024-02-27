using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Entities
{
    public class Game  //Oyunun temel bilgilerini içerecektir.
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Campaign Campaign { get; set; }


    }
}
