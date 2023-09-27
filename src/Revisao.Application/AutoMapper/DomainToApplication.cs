using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Domain.Entities;
using Revisao.Application.ViewModels.Request;

namespace Revisao.Application.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<JogoMegaSena, MegaSenaViewModel>();
            CreateMap<JogoMegaSena, NovoRegistroMegaSenaViewModel>();
        }

    }
}