using Microsoft.AspNetCore.Mvc;
using Dominio;

namespace Web.Controllers;

public class AccesoController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string contrasenia)
    {
        bool encontrado = false;
        int i = 0;

        while (!encontrado && i < Sistema.Instance.Clientes.Count)
        {
            Cliente c = Sistema.Instance.Clientes[i];
            if (c.Email == email && c.Contrasenia == contrasenia)
            {
                HttpContext.Session.SetString("usuario", email);
                HttpContext.Session.SetString("rol", "cliente");
                encontrado = true;
                return RedirectToAction("Vuelos", "Cliente"); // cliente al inicio
            }
            else
            {
                i++;
            }
        }

        i = 0;
        while (!encontrado && i < Sistema.Instance.Administradores.Count)
        {
            Administrador a = Sistema.Instance.Administradores[i];
            if (a.Email == email && a.Contrasenia == contrasenia)
            {
                HttpContext.Session.SetString("usuario", email);
                HttpContext.Session.SetString("rol", "admin");
                encontrado = true;
                return RedirectToAction("VerClientes", "Admin");
            }
            else
            {
                i++;
            }
        }

        ViewBag.Mensaje = "Credenciales incorrectas.";
        return View();
    }
    [HttpGet]
    public IActionResult ClienteOcasional()
    {
        return View();
    }
    [HttpPost]
    public IActionResult ClienteOcasional(string email, string contrasenia, string documento, string nombre, string nacionalidad)
    {
        try
        {
            Sistema.Instance.AltaClienteOcasional(email, contrasenia, documento, nombre, nacionalidad);
            TempData["Mensaje"] = "Cliente registrado con éxito. Ahora podés iniciar sesión.";
            return RedirectToAction("Login", "Acceso");
        }
        catch (Exception ex)
        {
            ViewBag.Mensaje = ex.Message;
            return View();
        }
    }
    
    
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login", "Acceso");
    }
    
}