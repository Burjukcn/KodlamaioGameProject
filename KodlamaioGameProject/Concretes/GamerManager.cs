using KodlamaioGameProject.Abstracts;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concretes
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;// Bu satır, IGamerCheckService türünde bir özellik tanımlar. Bu özellik, oyuncunun gerçek bir kişi olup olmadığını kontrol etmek için kullanılacak olan bir IGamerCheckService örneğini tutar.

        public GamerManager(IGamerCheckService gamerCheckService) //Bu satır, GamerManager sınıfının kurucu yöntemini tanımlar. Kurucu yöntem, IGamerCheckService türünden bir parametre alır ve bu parametreyi _gamerCheckService özelliğine atar.
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                Console.WriteLine(gamer.Name+" "+gamer.Name+" Oyuncu eklendi " );
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi ...");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" "+gamer.Name+" Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" "+gamer.Name+" Oyuncu güncellendi");
        }
    }
}
