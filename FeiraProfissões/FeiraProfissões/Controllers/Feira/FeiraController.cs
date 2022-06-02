using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeiraProfissões.Controllers.Feira
{
    public class FeiraController : Controller
    {
        Business.FeiraBusiness business = new Business.FeiraBusiness();

        public ActionResult Index()
        {
            Models.tb_log_navegacao log = new Models.tb_log_navegacao();

            log.dt_log = DateTime.Now;
            log.nm_page = "Página Inicial";
            log.ip_address = Request.UserHostAddress;

            business.InserirLog(log);

            return View();
        }

        public ActionResult Avaliacao()
        {
            Models.tb_log_navegacao log = new Models.tb_log_navegacao();

            log.dt_log = DateTime.Now;
            log.nm_page = "Avaliação";
            log.ip_address = Request.UserHostAddress;

            business.InserirLog(log);

            return View();
        }

        [HttpPost]
        public ActionResult Avaliacao(int estrela)
        {
            Models.tb_avaliacao avaliacao = new Models.tb_avaliacao();
            avaliacao.dt_avaliacao = DateTime.Now;
            avaliacao.qt_estrelas = estrela;
            avaliacao.ip_address = Request.UserHostAddress;

            business.Inserir(avaliacao);

            return View();
        }

        public ActionResult SegundoAndar()
        {
            Models.tb_log_navegacao log = new Models.tb_log_navegacao();

            log.dt_log = DateTime.Now;
            log.nm_page = "Segundo Andar";
            log.ip_address = Request.UserHostAddress;

            business.InserirLog(log);

            return View();
        }

        public ActionResult PrimeiroAndar()
        {
            Models.tb_log_navegacao log = new Models.tb_log_navegacao();

            log.dt_log = DateTime.Now;
            log.nm_page = "Primeiro Andar";
            log.ip_address = Request.UserHostAddress;

            business.InserirLog(log);

            return View();
        }

        public ActionResult Terreo()
        {
            Models.tb_log_navegacao log = new Models.tb_log_navegacao();

            log.dt_log = DateTime.Now;
            log.nm_page = "Térreo";
            log.ip_address = Request.UserHostAddress;

            business.InserirLog(log);

            return View();
        }
        public ActionResult TerceiroAndar()
        {
            Models.tb_log_navegacao log = new Models.tb_log_navegacao();

            log.dt_log = DateTime.Now;
            log.nm_page = "Terceiro Andar";
            log.ip_address = Request.UserHostAddress;
            business.InserirLog(log);

            return View();
        }
    }
}