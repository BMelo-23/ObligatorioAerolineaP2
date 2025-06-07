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
                Console.WriteLine("Ingrese una opción =>");
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
                        MostrarError("ERROR Opcion invalida");
                        PressToContinue();
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
                Console.WriteLine("Cliente ocasional agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            PressToContinue();
        }
        private static void PressToContinue()
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
        private static string PedirValor(string mensaje)
        {
            string valor = "";
            while (valor == "")
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();
                if (string.IsNullOrEmpty(valor))
                {
                    MostrarError("Debe ingresar un valor válido");
                    valor = "";
                }
            }
            return valor;
        }
        private static void MostrarListadoDeClientes()
        {
            Console.Clear();
            Console.WriteLine("*** LISTADO DE CLIENTES ***");
            try
            {

               List<Cliente> clientes  = miSistema.ListarClientes();
                
               foreach ( Cliente c in clientes)
               {
                   Console.WriteLine(c.DatosCliente());
               }
               
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            PressToContinue();
        }
        private static void ListarVuelosXCodigoAeropuerto()
        {

            Console.Clear();
            Console.WriteLine("*** VUELOS POR CÓDIGO DE AEROPUERTO ***");

            string codigo = "";
            bool exito = false;

            while (!exito)
            {
                codigo = PedirValor("Ingrese el código IATA del aeropuerto (o 'S' para volver al menú): ");
                if (codigo.ToLower() == "s")
                {
                    exito = true;
                }
                else
                {
                    try
                    {
                       List<Vuelo> listaVuelos = miSistema.ListarVuelosPorAeropuerto(codigo);
                       foreach (Vuelo v in listaVuelos)
                       {
                           Console.WriteLine(v.ToString());
                           Console.WriteLine("-----------");
                       }
                       exito = true;
                       PressToContinue();
                    }
                    catch (Exception ex)
                    {
                        MostrarError(ex.Message);
                    }
                }
            }
        }
        private static void ListarPasajesEntreFechas()
        {
            Console.Clear();
            Console.WriteLine("*** LISTADO DE PASAJES ENTRE FECHAS ***");

            try
            {
                Console.Write("Ingrese fecha de inicio (formato: yyyy-mm-dd): ");
                string inicio = Console.ReadLine();
                DateTime fechaInicio;
                bool parseoInicio = DateTime.TryParse(inicio, out fechaInicio);

                if (!parseoInicio)
                    throw new Exception("Formato de fecha de inicio inválido");

                Console.Write("Ingrese fecha de fin (formato: yyyy-mm-dd): ");
                string fin = Console.ReadLine();
                DateTime fechaFin;
                bool parseoFin = DateTime.TryParse(fin, out fechaFin);

                if (!parseoFin)
                    throw new Exception("Formato de fecha de fin inválido");

                List<Pasaje> pasajes = miSistema.ListarPasajesEntreFechas(fechaInicio, fechaFin);

                foreach (Pasaje p in pasajes)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }

            PressToContinue();
        }

    }
}



