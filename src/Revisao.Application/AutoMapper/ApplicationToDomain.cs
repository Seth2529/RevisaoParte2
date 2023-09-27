using AutoMapper;
using Revisao.Application.ViewModels.Request;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
       public ApplicationToDomain()
       {
            CreateMap<MegaSenaViewModel, JogoMegaSena>();

            CreateMap<NovoRegistroMegaSenaViewModel, JogoMegaSena>()
            .ConstructUsing(q => new JogoMegaSena(q.Nome, q.Cpf, q.primeiroNro, q.segundoNro, q.terceiroNro, q.quartoNro, q.quintoNro, q.sextoNro, q.datajogo));
       }
    }
}
