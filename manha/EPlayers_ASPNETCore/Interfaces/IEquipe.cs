using System.Collections.Generic;
using EPlayers_ASPNETCore.Models;

namespace EPlayers_ASPNETCore.Interfaces
{
    public interface IEquipe
    {
        void Create(Equipe e);
        List<Equipe> ReadAll();
        void Update(Equipe e);
        void Delete(int id);
    }
}