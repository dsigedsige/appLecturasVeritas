using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecturas_BureauVeritas.Controllers
{
    public class FotosFachadaController : Controller
    {
        //
        // GET: /FotosFachada/

        public ActionResult FotosFachada_Index()
        {
            return View();
        }

        public ActionResult FotosActas_Index()
        {
            return View();
        }

    }
}
