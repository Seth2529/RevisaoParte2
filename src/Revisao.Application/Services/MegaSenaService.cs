using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels.Request;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class MegaSenaService : IMegaSenaServices
    {
        private readonly IMegaSenaRepository _megaSenaServices;
        private IMapper _mapper;

        public MegaSenaService(IMegaSenaRepository megaSenaServices, IMapper mapper)
        {
            _megaSenaServices = megaSenaServices;
            _mapper = mapper;
        }

        public void RegistrarJogo(NovoRegistroMegaSenaViewModel novoRegistroMegaSenaViewModel)
        {
            var novoRegistro = _mapper.Map<JogoMegaSena>(novoRegistroMegaSenaViewModel);
            _megaSenaServices.RegistrarJogo(novoRegistro);
        }
        public IEnumerable<MegaSenaViewModel> ObterTodosOsJogos()
        {
            return _mapper.Map<IEnumerable<MegaSenaViewModel>>(_megaSenaServices.ObterTodosOsJogos());
        }
    }
}
