
namespace Dominio
{
    public class Sistema
    {
        private List<Aeropuerto> _aeropuertos = new List<Aeropuerto>();
        private List<Avion> _aviones = new List<Avion>();
        private List<Ruta> _rutas = new List<Ruta>();
        private List<Vuelo> _vuelos = new List<Vuelo>();
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Pasaje> _pasajes = new List<Pasaje>();

        public List<Aeropuerto> Aeropuertos
        {
            get { return _aeropuertos; }
        }
        public List<Avion> Aviones
        {
            get { return _aviones; }
        }
        public List<Ruta> Rutas
        {
            get { return _rutas; }
        }
        public List<Vuelo> Vuelos
        {
            get { return _vuelos; }
        }
        public List<Cliente> Clientes
        {
            get { return _clientes; }
        }
        public List<Pasaje> Pasajes
        {
            get { return _pasajes; }
        }
        public Sistema()
        {
            PrecargarAeropuertos();
            PrecargarAviones();
            PrecargarClientes();
            PrecargarRutas();
            PrecargarVuelos();
            PrecargarPasajes();
            PrecargarAdministrador();
        }
        private void PrecargarAeropuertos()
        {
            
            AgregarAeropuerto(new Aeropuerto("MDR", "MADRID", "Benabeu", 1, 1));
            AgregarAeropuerto(new Aeropuerto("MVD", "MONTEVIDEO", "Carrasco", 2, 2));
            AgregarAeropuerto(new Aeropuerto("SYD", "SYDNEY", "Dolphin", 3, 3));
            AgregarAeropuerto(new Aeropuerto("JFK", "NEW YORK", "John F. Kennedy", 4, 4));
            AgregarAeropuerto(new Aeropuerto("LHR", "LONDON", "Heathrow", 5, 5));
            AgregarAeropuerto(new Aeropuerto("CDG", "PARIS", "Charles de Gaulle", 6, 6));
            AgregarAeropuerto(new Aeropuerto("FRA", "FRANKFURT", "Frankfurt Main", 7, 7));
            AgregarAeropuerto(new Aeropuerto("GRU", "SAO PAULO", "Guarulhos", 8, 8));
            AgregarAeropuerto(new Aeropuerto("EZE", "BUENOS AIRES", "Ezeiza", 9, 9));
            AgregarAeropuerto(new Aeropuerto("AMS", "AMSTERDAM", "Schiphol", 10, 10));
            AgregarAeropuerto(new Aeropuerto("DXB", "DUBAI", "Dubai Intl", 11, 11));
            AgregarAeropuerto(new Aeropuerto("HND", "TOKYO", "Haneda", 12, 12));
            AgregarAeropuerto(new Aeropuerto("PEK", "BEIJING", "Capital Intl", 13, 13));
            AgregarAeropuerto(new Aeropuerto("LAX", "LOS ANGELES", "LAX", 14, 14));
            AgregarAeropuerto(new Aeropuerto("YYZ", "TORONTO", "Pearson", 15, 15));
            AgregarAeropuerto(new Aeropuerto("BCN", "BARCELONA", "El Prat", 16, 16));
            AgregarAeropuerto(new Aeropuerto("SCL", "SANTIAGO", "Arturo Merino", 17, 17));
            AgregarAeropuerto(new Aeropuerto("MEX", "MEXICO CITY", "Benito Juárez", 18, 18));
            AgregarAeropuerto(new Aeropuerto("LIM", "LIMA", "Jorge Chávez", 19, 19));
            AgregarAeropuerto(new Aeropuerto("BKK", "BANGKOK", "Suvarnabhumi", 20, 20));
            
        }
        private void PrecargarAviones()
        {
            AgregarAvion(new Avion("Boeing", "737", 180, 10000, 5));
            AgregarAvion(new Avion("Airbus", "A320", 160, 9500, 4.8));
            AgregarAvion(new Avion("Embraer", "E190", 100, 5000, 3.5));
            AgregarAvion(new Avion("Boeing", "787 Dreamliner", 250, 14800, 6.2));
        }
        private void PrecargarClientes()
        {
            AgregarCliente(new ClientePremium("ana@mail.com", "clave123", "12345678", "Ana", "Uruguaya", 1200));
            AgregarCliente(new ClienteOcasional("pepe@mail.com", "clave123", "87654321", "Pepe", "Uruguayo", true));
            AgregarCliente(new ClientePremium("jose@mail.com", "clave123", "12345678", "Jose", "Uruguaya", 100));
            AgregarCliente(new ClientePremium("juan@mail.com", "clave456", "22345678", "Juan", "Aleman", 5600));
            AgregarCliente(new ClientePremium("ana@mail.com", "clave789", "33456789", "Ana", "USA", 6000));
            AgregarCliente(new ClientePremium("pedro@mail.com", "clave222", "21345678", "Pedro", "Peruano", 7500));
            AgregarCliente(new ClientePremium("fernanda@mail.com", "clave333", "98765436", "Fernanda", "Ingles", 6543));
            AgregarCliente(new ClienteOcasional("luis@mail.com", "clave111", "40364628", "Luis", "Irlandes", false));
            AgregarCliente(new ClienteOcasional("fernan@mail.com", "clave223", "50749278", "Fernan", "Brasilero", false));
            AgregarCliente(new ClienteOcasional("Diego@mail.com", "clave336", "87651234", "Diego", "Chileno", true));
            AgregarCliente(new ClienteOcasional("Juana@mail.com", "clave957", "87321123", "Juana", "Paraguayo", true));
        }
        private void PrecargarRutas()
        {
            
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("MDR"), 8000));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SYD"), BuscarAeropuertoPorCodigo("MVD"), 13000));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LHR"), BuscarAeropuertoPorCodigo("FRA"), 800));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("MVD"), 8600));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LHR"), BuscarAeropuertoPorCodigo("MVD"), 11100));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("LHR"), 5550));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MDR"), BuscarAeropuertoPorCodigo("CDG"), 1050));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("CDG"), BuscarAeropuertoPorCodigo("FRA"), 450));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("FRA"), BuscarAeropuertoPorCodigo("GRU"), 9800));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("GRU"), BuscarAeropuertoPorCodigo("EZE"), 1650));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("EZE"), BuscarAeropuertoPorCodigo("MVD"), 200));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("AMS"), 11100));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("AMS"), BuscarAeropuertoPorCodigo("DXB"), 5160));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("DXB"), BuscarAeropuertoPorCodigo("HND"), 7930));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("HND"), BuscarAeropuertoPorCodigo("PEK"), 2100));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("PEK"), BuscarAeropuertoPorCodigo("SYD"), 8900));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SYD"), BuscarAeropuertoPorCodigo("LAX"), 12050));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LAX"), BuscarAeropuertoPorCodigo("JFK"), 3980));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("YYZ"), 600));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("YYZ"), BuscarAeropuertoPorCodigo("BCN"), 6100));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BCN"), BuscarAeropuertoPorCodigo("LIM"), 9460));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LIM"), BuscarAeropuertoPorCodigo("MEX"), 4250));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MEX"), BuscarAeropuertoPorCodigo("SCL"), 6600));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SCL"), BuscarAeropuertoPorCodigo("BKK"), 18200));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BKK"), BuscarAeropuertoPorCodigo("SYD"), 7500));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BKK"), BuscarAeropuertoPorCodigo("DXB"), 4900));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("DXB"), BuscarAeropuertoPorCodigo("MVD"), 13400));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("EZE"), 200));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MEX"), BuscarAeropuertoPorCodigo("JFK"), 3300));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LAX"), BuscarAeropuertoPorCodigo("LIM"), 6700));
            AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("PEK"), BuscarAeropuertoPorCodigo("MEX"), 12800));

        }
        private void PrecargarVuelos()
        {
    
            AgregarVuelo(new Vuelo("AA123", _rutas[0], _aviones[0], new List<DiaDeSemana> { DiaDeSemana.Lunes, DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("AA101", _rutas[0], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Lunes }));
           // AgregarVuelo(new Vuelo("BA202", _rutas[1], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Martes }));
            AgregarVuelo(new Vuelo("CA303", _rutas[2], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("DA404", _rutas[3], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Jueves }));
            //AgregarVuelo(new Vuelo("EA505", _rutas[4], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Viernes }));
            //AgregarVuelo(new Vuelo("FA606", _rutas[5], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Sabado }));
            // AgregarVuelo(new Vuelo("GA707", _rutas[6], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Domingo }));
             AgregarVuelo(new Vuelo("HA808", _rutas[7], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Lunes, DiaDeSemana.Viernes }));
             AgregarVuelo(new Vuelo("IA909", _rutas[8], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Martes, DiaDeSemana.Sabado }));
             AgregarVuelo(new Vuelo("JA010", _rutas[9], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Miercoles, DiaDeSemana.Domingo }));
             AgregarVuelo(new Vuelo("KA111", _rutas[10], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Jueves }));
             AgregarVuelo(new Vuelo("LA222", _rutas[11], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Viernes }));
             AgregarVuelo(new Vuelo("MA333", _rutas[12], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Sabado }));
             AgregarVuelo(new Vuelo("NA444", _rutas[13], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Domingo }));
             AgregarVuelo(new Vuelo("OA555", _rutas[14], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Lunes }));
             AgregarVuelo(new Vuelo("PA666", _rutas[15], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Martes }));
             //AgregarVuelo(new Vuelo("QA777", _rutas[16], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Miercoles }));
             AgregarVuelo(new Vuelo("RA888", _rutas[17], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Jueves }));
             AgregarVuelo(new Vuelo("SA999", _rutas[18], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Viernes }));
             AgregarVuelo(new Vuelo("TA100", _rutas[19], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Sabado }));
             AgregarVuelo(new Vuelo("UB111", _rutas[20], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Domingo }));
             AgregarVuelo(new Vuelo("VC222", _rutas[21], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Lunes, DiaDeSemana.Miercoles }));
            // AgregarVuelo(new Vuelo("WD333", _rutas[22], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Martes }));
            // AgregarVuelo(new Vuelo("XE444", _rutas[23], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Jueves, DiaDeSemana.Sabado }));
             AgregarVuelo(new Vuelo("YF555", _rutas[24], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Viernes }));
             AgregarVuelo(new Vuelo("ZG666", _rutas[25], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Lunes, DiaDeSemana.Viernes }));
            // AgregarVuelo(new Vuelo("AH777", _rutas[26], _aviones[2], new List<DiaDeSemana>{ DiaDeSemana.Miercoles }));
             AgregarVuelo(new Vuelo("BI888", _rutas[27], _aviones[3], new List<DiaDeSemana>{ DiaDeSemana.Martes }));
             AgregarVuelo(new Vuelo("CJ999", _rutas[28], _aviones[0], new List<DiaDeSemana>{ DiaDeSemana.Sabado, DiaDeSemana.Domingo }));
             AgregarVuelo(new Vuelo("DK100", _rutas[29], _aviones[1], new List<DiaDeSemana>{ DiaDeSemana.Jueves }));
            
        }
        private void PrecargarPasajes()
        {
            
             //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 1), _vuelos[0], _clientes[0], Equipaje.Cabina, 0));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 2), _vuelos[1], _clientes[1], Equipaje.Bodega, 1));
             //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 3), _vuelos[2], _clientes[2], Equipaje.Cabina, 0));
             //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 4), _vuelos[3], _clientes[3], Equipaje.Bodega, 2));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 5), _vuelos[4], _clientes[4], Equipaje.Cabina, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 6), _vuelos[0], _clientes[1], Equipaje.Bodega, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 7), _vuelos[1], _clientes[2], Equipaje.Cabina, 0));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 8), _vuelos[2], _clientes[3], Equipaje.Bodega, 2));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 9), _vuelos[3], _clientes[4], Equipaje.Cabina, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 10), _vuelos[4], _clientes[0], Equipaje.Bodega, 2));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 11), _vuelos[0], _clientes[2], Equipaje.Cabina, 0));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 12), _vuelos[1], _clientes[3], Equipaje.Bodega, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 13), _vuelos[2], _clientes[4], Equipaje.Cabina, 0));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 14), _vuelos[3], _clientes[0], Equipaje.Bodega, 2));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 15), _vuelos[4], _clientes[1], Equipaje.Cabina, 1));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 16), _vuelos[0], _clientes[3], Equipaje.Cabina, 0));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 17), _vuelos[1], _clientes[4], Equipaje.Bodega, 1));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 18), _vuelos[2], _clientes[0], Equipaje.Cabina, 0));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 19), _vuelos[3], _clientes[1], Equipaje.Bodega, 2));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 20), _vuelos[4], _clientes[2], Equipaje.Cabina, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 21), _vuelos[1], _clientes[0], Equipaje.Cabina, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 22), _vuelos[2], _clientes[1], Equipaje.Bodega, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 23), _vuelos[3], _clientes[2], Equipaje.Cabina, 1));
            //AgregarPasaje(new Pasaje(new DateTime(2025, 6, 24), _vuelos[4], _clientes[3], Equipaje.Bodega, 2));
             AgregarPasaje(new Pasaje(new DateTime(2025, 6, 25), _vuelos[0], _clientes[4], Equipaje.Cabina, 0));

        }
        private void PrecargarAdministrador()
        {

            Administrador a1 = new Administrador("mibarra@gmail.com", "1234", "Ibarra");
            Administrador a2 = new Administrador("bmelo@gmail.com", "abcd", "Melo");

        }
        private void AgregarAeropuerto(Aeropuerto a)
        {
            if (a == null) throw new Exception("El aeropuerto no puede ser nulo");
            a.Validar();
            _aeropuertos.Add(a);
        }
        private void AgregarAvion(Avion a)
        {
            if (a == null) throw new Exception("El avión no puede ser nulo");
            a.Validar();
            _aviones.Add(a);
        }
        private void AgregarCliente(Cliente c)
        {
            if (c == null) throw new Exception("El cliente no puede ser nulo");
            c.Validar();
            _clientes.Add(c);
        }
        public void AltaClienteOcasional(string email, string contrasenia, string documento, string nombre, string nacionalidad)
        {
            bool elegible = GenerarElegibilidad();
            Cliente nuevo = new ClienteOcasional(email, contrasenia, documento, nombre, nacionalidad, elegible);
            nuevo.Validar();

            if ( BuscarClientePorDocumento(documento))
                throw new Exception("Ya existe un cliente con ese documento");

            AgregarCliente(nuevo);
        }
        private bool GenerarElegibilidad()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2) == 1;
        }
        private void AgregarRuta(Ruta r)
        {
            if (r == null) throw new Exception("La ruta no puede ser nula");
            
            r.Validar();
            _rutas.Add(r);
            
        }
        private void AgregarVuelo(Vuelo v)
        {
            if (v == null) throw new Exception("El vuelo no puede ser nulo");
            v.Validar();
            _vuelos.Add(v);
        }
        private void AgregarPasaje(Pasaje p)
        {
            if (p == null) throw new Exception("El pasaje no puede ser nulo");
            p.Validar();
            _pasajes.Add(p);
        }
        private Aeropuerto BuscarAeropuertoPorCodigo(string codigo)
        {
            Aeropuerto encontrado = null;
            int i = 0;
            while (encontrado == null && i < _aeropuertos.Count)
            {
                if (_aeropuertos[i].CodigoIata.ToUpper().Equals(codigo.ToUpper()))
                    encontrado = _aeropuertos[i];
                i++;
            }

            if (encontrado == null)
                throw new Exception($"No se encontró aeropuerto con código: {codigo}");

            return encontrado;
        }

        private bool BuscarClientePorDocumento(string documento)
        {
            bool encontrado = false;
            int i = 0;
            while (encontrado == false && i < _clientes.Count)
            {
                if (_clientes[i].Documento.ToUpper().Equals(documento.ToUpper()))
                    encontrado = true;
                i++;
            }

            if (!encontrado)
                throw new Exception($"No se encontró cliente con documento: {documento}");

            return encontrado;
        }

        public void ListarClientes()
        {
            if (_clientes.Count == 0) throw new Exception("No hay clientes registrados");
            foreach (Cliente c in _clientes)
            {
                Console.WriteLine(c.DatosCliente());
            }
        }
        public void ListarVuelosPorAeropuerto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
                throw new Exception("El código no puede ser vacío, por favor ingrese un valor valido");

            bool seEncontraron = false;
            for (int i = 0; i < _vuelos.Count; i++)
            {
                Vuelo v = _vuelos[i];
                string salida = v.RutaAsociada.AeropuertoSalida.CodigoIata.ToUpper();
                string llegada = v.RutaAsociada.AeropuertoDeLlegada.CodigoIata.ToUpper();

                if (salida.Equals(codigo.ToUpper()) || llegada.Equals(codigo.ToUpper()))
                {
                    seEncontraron = true;
                    Console.WriteLine(v.ToString());
                }
            }

            if (!seEncontraron)
                throw new Exception("No se encontraron vuelos con ese código de aeropuerto");
        }
        public List<Pasaje> ListarPasajesEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Pasaje> resultado = new List<Pasaje>();

            if (fechaInicio > fechaFin)
                throw new Exception("La fecha de inicio no puede ser posterior a la fecha final");

            for (int i = 0; i < _pasajes.Count; i++)
            {
                Pasaje p = _pasajes[i];
                if (p.FechaPasaje.Date >= fechaInicio.Date && p.FechaPasaje.Date <= fechaFin.Date)
                {
                    resultado.Add(p);
                }
            }

            if (resultado.Count == 0)
                throw new Exception("No se encontraron pasajes entre esas fechas");

            return resultado;
        }
    }
}
