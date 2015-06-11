using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace punto.Controllers
{
    public class borraController : Controller
    {
        //
        // GET: /borra/

        public ActionResult Index()
        {
            punto.Models.puntoencuentroEntities bd = new Models.puntoencuentroEntities();
            punto.Models.tbevento n = new Models.tbevento();
            n.estado = 1;
            n.titulo = "-";
            bd.tbevento.Add(n);
            try
            {
                if (bd.SaveChanges() == 1)
                {
                    // correcto
                }
                else
                {
                    //errores en informacion
                }
            }
            catch
            {

            }
            return View();
        }

    }
}
