using Dominio;

namespace ObligatorioAerolineaP2
{
    internal class Program
    {
        static Sistema miSistema;
        static void Main(string[] args)
        {
            miSistema = new Sistema();

            string opcion = "";
            while (opcion != "0")
            {
                MostrarMenu();
                Console.Write("Ingrese una opcion =>");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                       // "Listar Clientes";
                        // "PressToContinue()";
                        break;

                    case "2":
                      //  "Mostrar vuelos segun codigo de avion";
                       // "PressToContinue()";
                        break;
                    case "3":
                      //  "Alta cliente";
                      //  "PressToContinue()";
                        break;
                    case "4":
                    //    "Listar pasajes segun fechas";
                     //   "PressToContinue()";
                        break;

                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MostrarError("ERROR Opcion invaldia");
                   //     "PressToContinue()";
                        break;

                }
            }
        }
        //PUNTO NRO 1 DEL MENU DEL OBLIGATORIO
        public static void ListadoClientes(List<Cliente> clientes)
        {
            Console.Clear();
            Console.WriteLine("*** LISTADO DE CLIENTES ***");
            Console.WriteLine();
            try
            {
                /*List<Cliente> todosLosUsuarios = Sistema.Usuarios;
                if (todosLosUsuarios.Count == 0) throw new Exception("No hay ningun usuario en el sistema");

                foreach (Cliente c in todosLosUsuarios)
                {
                    Console.WriteLine(c);
                }*/
            }
            catch (Exception ex)
            {
                MostrarError(ex.ToString());
            }
        }
        public static void MostrarMenu()
        {
        }
        public static void MostrarError(string error)
        {
            
            
        }
    }
}



