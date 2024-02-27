using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Entities
{
    public class Gamer// Oyuncu bilgileri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
        public int BirthYear { get; set; }
        public Game PurschasedGAme { get; set; }

        public List<Game> Games { get; set; }//oyuncunun oynadığı oyunların bir listesini temsil eden bir özelliktir. Bir oyuncunun birden fazla oyun oynayabileceği için, oyunları depolamak için bir liste kullanılır.


    }
}
