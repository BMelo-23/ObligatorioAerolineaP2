using Microsoft.AspNetCore.Mvc;
using Dominio;
namespace Web.Controllers;

public class ClienteController : Controller
{
    public IActionResult Vuelos()
    {
        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            return RedirectToAction("Login", "Acceso");
        }

        List<Vuelo> lista = Sistema.Instance.Vuelos;
        return View(lista);
    }
    
    [HttpGet]
    public IActionResult Buscar()
    {
        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            return RedirectToAction("Login", "Acceso");
        }

        return View();
    }

    [HttpPost]
    public IActionResult Buscar(string salida, string llegada)
    {
        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            return RedirectToAction("Login", "Acceso");
        }

        List<Vuelo> encontrados = new List<Vuelo>();

        for (int i = 0; i < Sistema.Instance.Vuelos.Count; i++)
        {
            Vuelo v = Sistema.Instance.Vuelos[i];
            string desde = v.RutaAsociada.AeropuertoSalida.CodigoIata.ToUpper();
            string hasta = v.RutaAsociada.AeropuertoDeLlegada.CodigoIata.ToUpper();

            bool coincideSalida = string.IsNullOrEmpty(salida) || desde == salida.ToUpper();
            bool coincideLlegada = string.IsNullOrEmpty(llegada) || hasta == llegada.ToUpper();

            if (coincideSalida && coincideLlegada)
            {
                encontrados.Add(v);
            }
        }

        if (encontrados.Count == 0)
        {
            ViewBag.Mensaje = "No se encontraron vuelos para esos aeropuertos.";
        }

        return View(encontrados);
    }
    // -
    
    [HttpGet]
    public IActionResult Comprar(string numero)
    {
        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            return RedirectToAction("Login", "Acceso");
        }

        Vuelo vuelo = null;
        int i = 0;
        while (vuelo == null && i < Sistema.Instance.Vuelos.Count)
        {
            if (Sistema.Instance.Vuelos[i].NumeroVuelo.ToUpper() == numero.ToUpper())
            {
                vuelo = Sistema.Instance.Vuelos[i];
            }
            else
            {
                i++;
            }
        }

        if (vuelo == null)
        {
            ViewBag.Mensaje = "No se encontró el vuelo.";
            return RedirectToAction("Vuelos");
        }

        ViewBag.Vuelo = vuelo;
        return View();
    }

    [HttpPost]
    public IActionResult Comprar(string numero, DateTime fecha, string equipaje)
    {
        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            return RedirectToAction("Login", "Acceso");
        }

        Vuelo vuelo = null;
        int i = 0;
        while (vuelo == null && i < Sistema.Instance.Vuelos.Count)
        {
            if (Sistema.Instance.Vuelos[i].NumeroVuelo.ToUpper() == numero.ToUpper())
            {
                vuelo = Sistema.Instance.Vuelos[i];
            }
            else
            {
                i++;
            }
        }

        if (vuelo == null)
        {
            ViewBag.Mensaje = "No se encontró el vuelo.";
            return View();
        }

        DiaDeSemana dia = (DiaDeSemana)fecha.DayOfWeek;
        if (!vuelo.Frecuencia.Contains(dia))
        {
            ViewBag.Mensaje = "La fecha seleccionada no coincide con la frecuencia del vuelo.";
            ViewBag.Vuelo = vuelo;
            return View();
        }

        Cliente cliente = null;
        string email = HttpContext.Session.GetString("usuario");

        i = 0;
        while (cliente == null && i < Sistema.Instance.Clientes.Count)
        {
            if (Sistema.Instance.Clientes[i].Email.ToUpper() == email.ToUpper())
            {
                cliente = Sistema.Instance.Clientes[i];
            }
            else
            {
                i++;
            }
        }

        if (cliente == null)
        {
            ViewBag.Mensaje = "No se pudo encontrar el cliente.";
            return View();
        }

        Equipaje tipo = (Equipaje)Enum.Parse(typeof(Equipaje), equipaje);
        int cantidad = 0;

        if (tipo == Equipaje.Bodega)
        {
            cantidad = 2;
        }
        else if (tipo == Equipaje.Cabina)
        {
            cantidad = 1;
        }

        try
        {
            Pasaje nuevo = new Pasaje(fecha, vuelo, cliente, tipo, cantidad);
            nuevo.Validar();
            Sistema.Instance.Pasajes.Add(nuevo);
            ViewBag.Exito = "Pasaje comprado con éxito.";
        }
        catch (Exception ex)
        {
            ViewBag.Mensaje = ex.Message;
        }

        ViewBag.Vuelo = vuelo;
        return View();
    }
    //Pasajes comprados
    public IActionResult Pasajes()
    {
        IActionResult resultado;
        
        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            return RedirectToAction("Login", "Acceso");
        }
        else 
        {
            try
            {
                string email = HttpContext.Session.GetString("usuario");
                List<Pasaje> pasajesCliente = Sistema.Instance.PasajesDeClienteOrdenadosPorPrecio(email);
                resultado = View(pasajesCliente);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                resultado = View(new List<Pasaje>());
            }
        }
        return resultado;
    }
    //Perfil
    public IActionResult Perfil()
    {
        IActionResult resultado;

        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            resultado = RedirectToAction("Login", "Acceso");
        }
        else
        {
            string email = HttpContext.Session.GetString("usuario");
            Cliente cliente = null;
            int i = 0;

            while (cliente == null && i < Sistema.Instance.Clientes.Count)
            {
                if (Sistema.Instance.Clientes[i].Email.ToUpper() == email.ToUpper())
                {
                    cliente = Sistema.Instance.Clientes[i];
                }
                else
                {
                    i++;
                }
            }

            if (cliente == null)
            {
                ViewBag.Mensaje = "No se encontró el cliente.";
            }
            else
            {
                ViewBag.Cliente = cliente;
            }

            resultado = View();
        }

        return resultado;
    }
    //Vuelos
    public IActionResult VuelosPorAeropuerto(string codigo)
    {
        IActionResult resultado;

        if (HttpContext.Session.GetString("usuario") == null || HttpContext.Session.GetString("rol") != "cliente")
        {
            resultado = RedirectToAction("Login", "Acceso");
        }
        else
        {
            try
            {
                List<Vuelo> vuelos = new List<Vuelo>();

                if (!string.IsNullOrEmpty(codigo))
                {
                    vuelos = Sistema.Instance.ListarVuelosPorAeropuerto(codigo);
                }

                ViewBag.Codigo = codigo;
                resultado = View("VuelosPorAeropuerto", vuelos);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                resultado = View("VuelosPorAeropuerto", new List<Vuelo>());
            }
        }

        return resultado;
    }
    
}