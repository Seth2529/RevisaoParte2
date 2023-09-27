﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Application.ViewModels.Validation;

namespace Revisao.Application.ViewModels.Request
{
    public class NovoRegistroMegaSenaViewModel
    {
        [MinLength(3, ErrorMessage = "Mínimo 3 letras.")]
        [MaxLength(255, ErrorMessage = "Limite máximo atingido.")]
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Nome { get; set; }

        [CPFValidation]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int primeiroNro { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int segundoNro { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int terceiroNro { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int quartoNro { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int quintoNro { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int sextoNro { get; set; }

        public DateTime datajogo { get; set; }
    }
}
