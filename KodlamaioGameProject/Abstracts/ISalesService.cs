using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstracts
{
    public interface ISalesService
    {
        void Sale(Gamer gamer, Game game);//ir oyuncunun bir oyun satın alması için kullanılan bir yöntemi tanımlar. Bu yöntem, bir Gamer nesnesi ve bir Game nesnesi alır ve oyuncunun bu oyunu satın alması için gereken işlemleri gerçekleştirir.

        
    }
}
