using Microsoft.AspNetCore.Mvc;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IMegaSenaRepository
    {
        List<JogoMegaSena> ObterTodosOsJogos();

        void RegistrarJogo(JogoMegaSena megasena);
    }
}
