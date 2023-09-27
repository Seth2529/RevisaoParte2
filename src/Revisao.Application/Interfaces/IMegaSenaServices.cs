using Revisao.Application.ViewModels.Request;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IMegaSenaServices
    {
        public IEnumerable<MegaSenaViewModel> ObterTodosOsJogos();
        public void RegistrarJogo(NovoRegistroMegaSenaViewModel megasena);
    }
}
