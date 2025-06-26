using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Dominio;
namespace Web.Controllers;

public class RegistroController : Controller
{
    [HttpGet]
    public IActionResult ClienteOcasional()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ClienteOcasional(string nombre, string nacionalidad, string documento, string email, string contrasenia)
    {
        try
        {
            if (string.IsNullOrEmpty(contrasenia) || contrasenia.Length < 8 || !Regex.IsMatch(contrasenia, @"^[a-zA-Z0-9]+$"))
            {
                ViewBag.Mensaje = "La contraseña debe ser alfanumérica y tener al menos 8 caracteres.";
                return View();
            }

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
}