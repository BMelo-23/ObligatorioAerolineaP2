using Dominio;

namespace ObligatorioAerolineaP2
{
    internal class Program
    {
        static Sistema miSistema;
        static void Main(string[] args)
        {
            try
            {
                miSistema = new Sistema();
                MostrarMenu();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private static void MostrarMenu()
        {
            string opcion = "";
            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("*** MENÚ PRINCIPAL ***");
                Console.WriteLine("1 - Listado de todos los clientes");
                Console.WriteLine("2 - Listar vuelos por código de aeropuerto");
                Console.WriteLine("3 - Alta de cliente ocasional");
                Console.WriteLine("4 - Listar pasajes entre fechas");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Ingrese una opción: ");
                opcion = Console.ReadLine();
                
                switch (opcion)
                {
                    case "1":
                        MostrarListadoDeClientes();
                        break;
                    case "2":
                        ListarVuelosXCodigoAeropuerto();
                        break;
                    case "3":
                        AltaClienteOcasional();
                        break;
                    case "4":
                        ListarPasajesEntreFechas();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MostrarError("ERROR: Opción inválida");
                        PresioneParaContinuar();
                        break;
                }
            }

        }
        private static void AltaClienteOcasional()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("*** ALTA DE CLIENTE OCASIONAL ***");
                            
                string nombre = PedirValor("Ingrese un nombre: ");
                string documento = PedirValor("Ingrese un documento: ");
                string nacionalidad = PedirValor("Ingrese una nacionalidad: ");
                string email = PedirValor("Ingrese un email: ");
                string contrasenia = PedirValor("Ingrese una contraseña: ");
                miSistema.AltaClienteOcasional(email, contrasenia, documento, nombre, nacionalidad);
                Console.WriteLine("Cliente ocasional agregado exitosamente");
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            PresioneParaContinuar();
        }
        private static void MostrarListadoDeClientes()
        {
            Console.Clear();
            Console.WriteLine("*** LISTADO DE CLIENTES ***");
            try
            {
               foreach ( Cliente c in miSistema.ListarClientes())
               {
                   Console.WriteLine(c.DatosCliente());
               }
               
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            PresioneParaContinuar();
        }
        private static void ListarVuelosXCodigoAeropuerto()
        {
            Console.Clear();
            Console.WriteLine("*** VUELOS POR CÓDIGO DE AEROPUERTO ***");
            string codigo = PedirValor("Ingrese el código IATA del aeropuerto");
            
            try
            {
               foreach (Vuelo v in miSistema.ListarVuelosPorAeropuerto(codigo))
               {
                   Console.WriteLine(v.ToString());
                   Console.WriteLine("-----------");
               }
               PresioneParaContinuar();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
        private static void ListarPasajesEntreFechas()
        {
            Console.Clear();
            Console.WriteLine("*** LISTADO DE PASAJES ENTRE FECHAS ***");

            DateTime fechaInicio = PedirFecha("Ingrese fecha de inicio (formato: yyyy/mm/dd)");
            DateTime fechaFin = PedirFecha("Ingrese fecha de fin (formato: yyyy/mm/dd)");
            
            try
            {
                List<Pasaje> pasajes = miSistema.ListarPasajesEntreFechas(fechaInicio, fechaFin);

                foreach (Pasaje p in pasajes)
                {
                    Console.WriteLine(p.ToString());
                    Console.WriteLine("----------------------");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }

            PresioneParaContinuar();
        }
        private static DateTime PedirFecha(string mensaje)
        {
            DateTime fecha = new DateTime();
            string valor = "";
            bool esValida = false;

            while (!esValida)
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();
                
                if (string.IsNullOrEmpty(valor))
                {
                    MostrarError("Debe ingresar una fecha (no puede estar vacío)");
                    esValida = false;
                }
                else
                {
                    esValida = DateTime.TryParse(valor, out fecha);
                    if (!esValida)
                    {
                        MostrarError("La fecha ingresada no es válida. Formato esperado: yyyy/mm/dd");
                        esValida = false;
                    }
                }
            }
            return fecha;
        }
        private static string PedirValor(string mensaje)
        {
            string valor = "";
            bool esValido = false;

            while (!esValido)
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();
                if (string.IsNullOrEmpty(valor))
                {
                    MostrarError("Debe ingresar un valor válido");
                    esValido = false;
                }
                else
                {
                    esValido = true;
                }
            }
            return valor;
        }
        private static void PresioneParaContinuar()
        {
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        private static void MostrarError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}



