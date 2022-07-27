﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DSIGE;
using DSIGE.Modelo;
using DSIGE.Negocio;

using Excel = OfficeOpenXml;
using Style = OfficeOpenXml.Style;
using System.Web.UI;
namespace DSIGE.Web.Controllers
{
    public class Ubicacion_OperariosController : Controller
    {
        //
        // GET: /Ubicacion_Operarios/

        public ActionResult Inicio()
        {
            ViewBag.IdPerfil = ((Sesion)Session["Session_Usuario_Acceso"]).usuario.idPerfil;
            return View();
        }

        public ActionResult Inicio_new()
        {
            ViewBag.IdPerfil = ((Sesion)Session["Session_Usuario_Acceso"]).usuario.idPerfil;
            return View();
        }

        /// <summary>
        /// Autor: rcontreras
        /// Fecha: 30-09-2015
        /// </summary>
        /// <returns></returns>
        
        [HttpPost]
        public ActionResult JsonUbicacion_OperariosGPS(string __a, string __b,string lista, int id_supervisor, int id_operario_supervisor)
        {
            int idSuper=0;
            if(__a=="" || __a== null ) { idSuper = 0; }else{idSuper = Convert.ToInt32(__a);}
            return new ContentResult
            {
                Content = MvcApplication._Serialize(new NUbicacion_Operarios().NListaOperariosGPS(
                __b,
                idSuper, 
                Convert.ToInt32(((Sesion)Session["Session_Usuario_Acceso"]).usuario.idPerfil), 
                lista, id_supervisor, id_operario_supervisor
                )),
                ContentType = "application/json"
            };
        }



        [HttpPost]
        public JsonResult ListandoServicios()
        {
            
            try
            {
                Cls_Negocio_AsignarOrdenTrabajo obj_negocio = new Cls_Negocio_AsignarOrdenTrabajo();
                var loDatos = obj_negocio.Capa_Negocio_Get_ListaServicioXusuario(((Sesion)Session["Session_Usuario_Acceso"]).usuario.usu_id);
                // loDatos = obj_negocio.Capa_Negocio_Get_ListaServicioXusuario();
                return Json(loDatos, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
               throw ex;
            }

        }


        ///// <summary>
        ///// Autor: rcontreras
        ///// Fecha: 08-09-2015
        ///// </summary>
        ///// <param name="__a"></param>
        ///// <returns></returns>
        //[HttpGet]
        //public ActionResult ExportaExcel(string __a)
        //{
        //    ViewBag.DatosExcel = new NUbicacion_Operarios().NListaOperariosGPS(Convert.ToInt32(__a));

        //    string archivo = "Operarios_Pendientes_Por_Liquidar" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xls";
        //    Response.AddHeader("content-disposition", "attachment; filename=" + archivo);
        //    Response.ContentType = "application/x-ms-excel";

        //    return View();
        //}

    }
}
