using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeiraProfissões.Business
{
    public class FeiraBusiness
    {
        Database.FeiraDatabase database = new Database.FeiraDatabase();

        public void Inserir(Models.tb_avaliacao avaliacao)
        {
            database.Inserir(avaliacao);
        }

        public void InserirLog(Models.tb_log_navegacao log)
        {
            database.InserirLog(log);
        }
    }
}