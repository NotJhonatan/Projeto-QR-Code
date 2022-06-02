using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeiraProfissões.Database
{
    public class FeiraDatabase
    {
        Models.db_a4c265_feira19Entities db = new Models.db_a4c265_feira19Entities();
        public void Inserir(Models.tb_avaliacao avaliacao)
        {
            db.tb_avaliacao.Add(avaliacao);

            db.SaveChanges();
        }

        public void InserirLog (Models.tb_log_navegacao log)
        {
            db.tb_log_navegacao.Add(log);
            db.SaveChanges();
        }
    }
}