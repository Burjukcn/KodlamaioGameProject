using KodlamaioGameProject.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstracts
{
    public interface IGamerCheckService
    {
         bool Validate(Gamer gamer);
    }
}
