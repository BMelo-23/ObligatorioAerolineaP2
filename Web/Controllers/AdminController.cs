using Microsoft.AspNetCore.Mvc;
using Dominio;
namespace Web.Controllers;
public class AdminController : Controller
{
    public IActionResult VerPasajes(DateTime fechaInicio, DateTime fechaFin)
    {
        IActionResult resultado;

        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "admin")
        {
            resultado = RedirectToAction("Login", "Acceso");
        }
        else
        {
            bool busquedaHecha = fechaInicio != DateTime.MinValue && fechaFin != DateTime.MinValue;
            ViewBag.Busqueda = busquedaHecha;
            
            try
            {
                List<Pasaje> filtrados = Sistema.Instance.ListarPasajesEntreFechas(fechaInicio, fechaFin);
                resultado = View("PasajesFiltrados", filtrados); // usa la misma vista
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                resultado = View("PasajesFiltrados", new List<Pasaje>());
            }
        }

        return resultado;
    }
    //Ver clientes
    public IActionResult VerClientes()
    {
        IActionResult resultado;

        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "admin")
        {
            resultado = RedirectToAction("Login", "Acceso");
        }
        else
        {
            try
            {
                List<Cliente> clientes = Sistema.Instance.ClientesOrdenadosPorDocumento();
                resultado = View("VerClientes", clientes);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                resultado = View("VerClientes", new List<Cliente>());
            }
        }

        return resultado;
    }
    
}