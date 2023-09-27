using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace Revisao.Data.Repositories
{
    public class MegaSenaRepository: IMegaSenaRepository
    {
        #region Métodos
        string _arquivojogos = @".\FileJsonData\jogosMega.json";

        private List<JogoMegaSena> ObterJogos()
        {
            if (!System.IO.File.Exists(_arquivojogos))
            {
                return new List<JogoMegaSena>();
            }
            Directory.CreateDirectory(_arquivojogos.Substring(0, _arquivojogos.LastIndexOf('\\') + 1));
            string Readjson = System.IO.File.ReadAllText(_arquivojogos);
            return JsonConvert.DeserializeObject<List<JogoMegaSena>>(Readjson);
        }
        private void RegistroJogo(List<JogoMegaSena> registro)
        {
            string Readjson = JsonConvert.SerializeObject(registro);
            System.IO.File.WriteAllText(_arquivojogos, Readjson);
        }
        #endregion

        public void RegistrarJogo(JogoMegaSena megasena)
        {

            List<JogoMegaSena> registro = ObterJogos();
            registro.Add(megasena);
            RegistroJogo(registro);
        }

        public List<JogoMegaSena> ObterTodosOsJogos()
        {
            List<JogoMegaSena> obter = ObterJogos();
            List<JogoMegaSena> enumerar = obter;
            return enumerar;
        }

    }
}
