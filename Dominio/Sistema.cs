
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
        private List<Administrador> _administradores = new List<Administrador>();
        
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
        public List<Administrador> Administradores
        {
            get { return _administradores; }
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
            
            AgregarAeropuerto(new Aeropuerto("MVD", "Montevideo", "Carrasco", 2, 3));
            AgregarAeropuerto(new Aeropuerto("EZE", "Buenos Aires", "Ezeiza", 3, 4));
            AgregarAeropuerto(new Aeropuerto("GRU", "Sao Paulo", "Guarulhos", 4, 5));
            AgregarAeropuerto(new Aeropuerto("JFK", "New York", "John F. Kennedy", 5, 6));
            AgregarAeropuerto(new Aeropuerto("LAX", "Los Angeles", "LAX Airport", 6, 7));
            AgregarAeropuerto(new Aeropuerto("CDG", "Paris", "Charles de Gaulle", 7, 8));
            AgregarAeropuerto(new Aeropuerto("LHR", "London", "Heathrow", 8, 9));
            AgregarAeropuerto(new Aeropuerto("SYD", "Sydney", "Kingsford Smith", 9, 10));
            AgregarAeropuerto(new Aeropuerto("NRT", "Tokyo", "Narita", 10, 11));
            AgregarAeropuerto(new Aeropuerto("FRA", "Frankfurt", "Frankfurt Main", 11, 12));
            AgregarAeropuerto(new Aeropuerto("AMS", "Amsterdam", "Schiphol", 12, 13));
            AgregarAeropuerto(new Aeropuerto("BCN", "Barcelona", "El Prat", 13, 14));
            AgregarAeropuerto(new Aeropuerto("BER", "Berlin", "Brandenburg", 14, 15));
            AgregarAeropuerto(new Aeropuerto("MAD", "Madrid", "Barajas", 15, 16));
            AgregarAeropuerto(new Aeropuerto("MIA", "Miami", "Miami Intl", 16, 17));
            AgregarAeropuerto(new Aeropuerto("YYZ", "Toronto", "Pearson", 17, 18));
            AgregarAeropuerto(new Aeropuerto("SCL", "Santiago", "Arturo Merino", 18, 19));
            AgregarAeropuerto(new Aeropuerto("BOG", "Bogotá", "El Dorado", 19, 20));
            AgregarAeropuerto(new Aeropuerto("LIM", "Lima", "Jorge Chávez", 20, 21));
            AgregarAeropuerto(new Aeropuerto("DFW", "Dallas", "Fort Worth", 21, 22));
            
        }
        private void PrecargarAviones()
        {
            
            AgregarAvion(new Avion("Boeing", "737-800", 180, 5500, 4.8));
            AgregarAvion(new Avion("Airbus", "A320neo", 160, 6100, 5.2));
            AgregarAvion(new Avion("Embraer", "E190", 100, 4500, 3.9));
            AgregarAvion(new Avion("Boeing", "787 Dreamliner", 250, 14800, 6.5));
            AgregarAvion(new Avion("Airbus", "A350-900ULR", 170, 18000, 7.5)); // Ultra Long Range
            
        }
        private void PrecargarClientes()
        {
            
            AgregarCliente(new ClientePremium("ana@mail.com", "clave123", "12345678", "Ana", "Uruguaya", 1200));
            AgregarCliente(new ClientePremium("bob@mail.com", "secure456", "87654321", "Bob", "Argentina", 950));
            AgregarCliente(new ClientePremium("carla@mail.com", "mypwd789", "11223344", "Carla", "Brasilera", 1020));
            AgregarCliente(new ClientePremium("david@mail.com", "pass3210", "55667788", "David", "Chileno", 870));
            AgregarCliente(new ClientePremium("emma@mail.com", "key0001", "99887766", "Emma", "Colombiana", 1340));
            AgregarCliente(new ClienteOcasional("lucas@mail.com", "lucas123", "22334455", "Lucas", "Uruguayo", true));
            AgregarCliente(new ClienteOcasional("sara@mail.com", "sara1234", "33445566", "Sara", "Argentina", false));
            AgregarCliente(new ClienteOcasional("martin@mail.com", "martin99", "44556677", "Martín", "Chileno", true));
            AgregarCliente(new ClienteOcasional("valen@mail.com", "vale1234", "55669988", "Valentina", "Brasilera", true));
            AgregarCliente(new ClienteOcasional("nico@mail.com", "nicol4321", "66778899", "Nicolás", "Colombiano", false));
            
        }
        private void PrecargarRutas()
        {
            
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("EZE"), 200));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("GRU"), 700));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("GRU"), BuscarAeropuertoPorCodigo("EZE"), 800));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("LAX"), 4000));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("CDG"), BuscarAeropuertoPorCodigo("LHR"), 350));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LHR"), BuscarAeropuertoPorCodigo("SYD"), 17000));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SYD"), BuscarAeropuertoPorCodigo("NRT"), 7800));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("NRT"), BuscarAeropuertoPorCodigo("FRA"), 9300));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("FRA"), BuscarAeropuertoPorCodigo("AMS"), 400));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("AMS"), BuscarAeropuertoPorCodigo("BCN"), 1200));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BCN"), BuscarAeropuertoPorCodigo("BER"), 1500));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BER"), BuscarAeropuertoPorCodigo("MAD"), 1800));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MAD"), BuscarAeropuertoPorCodigo("MIA"), 7100));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MIA"), BuscarAeropuertoPorCodigo("YYZ"), 2300));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("YYZ"), BuscarAeropuertoPorCodigo("SCL"), 8900));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("SCL"), BuscarAeropuertoPorCodigo("BOG"), 5000));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BOG"), BuscarAeropuertoPorCodigo("LIM"), 1900));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LIM"), BuscarAeropuertoPorCodigo("DFW"), 6200));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("DFW"), BuscarAeropuertoPorCodigo("JFK"), 2200));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("JFK"), BuscarAeropuertoPorCodigo("CDG"), 5850));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("EZE"), BuscarAeropuertoPorCodigo("MIA"), 7100));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MVD"), BuscarAeropuertoPorCodigo("YYZ"), 8900));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("MAD"), BuscarAeropuertoPorCodigo("GRU"), 8200));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BCN"), BuscarAeropuertoPorCodigo("SCL"), 10300));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("BER"), BuscarAeropuertoPorCodigo("BOG"), 9800));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("AMS"), BuscarAeropuertoPorCodigo("LAX"), 9400));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("CDG"), BuscarAeropuertoPorCodigo("SYD"), 16900));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("LHR"), BuscarAeropuertoPorCodigo("DFW"), 7600));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("NRT"), BuscarAeropuertoPorCodigo("JFK"), 10800));
         AgregarRuta(new Ruta(BuscarAeropuertoPorCodigo("FRA"), BuscarAeropuertoPorCodigo("MVD"), 11500));

        }
        private void PrecargarVuelos()
        {
    
            AgregarVuelo(new Vuelo("UA101", BuscarRutaPorId(1), BuscarAvionPorModelo("737-800"), new List<DiaDeSemana> { DiaDeSemana.Lunes }));
            AgregarVuelo(new Vuelo("AF202", BuscarRutaPorId(2), BuscarAvionPorModelo("A320neo"), new List<DiaDeSemana> { DiaDeSemana.Martes }));
            AgregarVuelo(new Vuelo("LH303", BuscarRutaPorId(3), BuscarAvionPorModelo("E190"), new List<DiaDeSemana> { DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("BA404", BuscarRutaPorId(4), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Jueves }));
            AgregarVuelo(new Vuelo("AA505", BuscarRutaPorId(5), BuscarAvionPorModelo("737-800"), new List<DiaDeSemana> { DiaDeSemana.Viernes }));
            AgregarVuelo(new Vuelo("QF606", BuscarRutaPorId(6), BuscarAvionPorModelo("A350-900ULR"), new List<DiaDeSemana> { DiaDeSemana.Sabado }));
            AgregarVuelo(new Vuelo("DL707", BuscarRutaPorId(7), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Domingo }));
            AgregarVuelo(new Vuelo("IB808", BuscarRutaPorId(8), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Lunes }));
            AgregarVuelo(new Vuelo("LA909", BuscarRutaPorId(9), BuscarAvionPorModelo("737-800"), new List<DiaDeSemana> { DiaDeSemana.Martes }));
            AgregarVuelo(new Vuelo("AC010", BuscarRutaPorId(10), BuscarAvionPorModelo("A320neo"), new List<DiaDeSemana> { DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("EK111", BuscarRutaPorId(11), BuscarAvionPorModelo("E190"), new List<DiaDeSemana> { DiaDeSemana.Jueves }));
            AgregarVuelo(new Vuelo("KL222", BuscarRutaPorId(12), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Viernes }));
            AgregarVuelo(new Vuelo("LX333", BuscarRutaPorId(23), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("NH444", BuscarRutaPorId(14), BuscarAvionPorModelo("A320neo"), new List<DiaDeSemana> { DiaDeSemana.Domingo }));
            AgregarVuelo(new Vuelo("TK555", BuscarRutaPorId(25), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Viernes }));
            AgregarVuelo(new Vuelo("SU666", BuscarRutaPorId(16), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Martes }));
            AgregarVuelo(new Vuelo("IB777", BuscarRutaPorId(17), BuscarAvionPorModelo("737-800"), new List<DiaDeSemana> { DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("AR888", BuscarRutaPorId(24), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Jueves, DiaDeSemana.Domingo}));
            AgregarVuelo(new Vuelo("DL999", BuscarRutaPorId(19), BuscarAvionPorModelo("E190"), new List<DiaDeSemana> { DiaDeSemana.Viernes }));
            AgregarVuelo(new Vuelo("AF112", BuscarRutaPorId(20), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Sabado }));
            AgregarVuelo(new Vuelo("KL223", BuscarRutaPorId(26), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Lunes, DiaDeSemana.Miercoles, DiaDeSemana.Sabado }));
            AgregarVuelo(new Vuelo("LX334", BuscarRutaPorId(26), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Martes, DiaDeSemana.Viernes }));
            AgregarVuelo(new Vuelo("NH445", BuscarRutaPorId(23), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Martes }));
            AgregarVuelo(new Vuelo("TK556", BuscarRutaPorId(24), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Miercoles }));
            AgregarVuelo(new Vuelo("SU667", BuscarRutaPorId(25), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Jueves }));
            AgregarVuelo(new Vuelo("IB778", BuscarRutaPorId(26), BuscarAvionPorModelo("A350-900ULR"), new List<DiaDeSemana> { DiaDeSemana.Viernes }));
            AgregarVuelo(new Vuelo("AR889", BuscarRutaPorId(27), BuscarAvionPorModelo("A350-900ULR"), new List<DiaDeSemana> { DiaDeSemana.Sabado }));
            AgregarVuelo(new Vuelo("DL990", BuscarRutaPorId(28), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Domingo }));
            AgregarVuelo(new Vuelo("AF113", BuscarRutaPorId(29), BuscarAvionPorModelo("787 Dreamliner"), new List<DiaDeSemana> { DiaDeSemana.Lunes }));
            AgregarVuelo(new Vuelo("KL224", BuscarRutaPorId(30), BuscarAvionPorModelo("A350-900ULR"), new List<DiaDeSemana> { DiaDeSemana.Martes }));

        }
        private void PrecargarPasajes()
        { 
            
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 2), Vuelos[0], Clientes[0], Equipaje.Cabina, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 3), Vuelos[1], Clientes[1], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 4), Vuelos[2], Clientes[2], Equipaje.Light, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 5), Vuelos[3], Clientes[3], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 6), Vuelos[4], Clientes[4], Equipaje.Cabina, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 7), Vuelos[5], Clientes[5], Equipaje.Bodega, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 8), Vuelos[6], Clientes[6], Equipaje.Cabina, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 9), Vuelos[7], Clientes[7], Equipaje.Light, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 10), Vuelos[8], Clientes[8], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 11), Vuelos[9], Clientes[9], Equipaje.Cabina, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 12), Vuelos[10], Clientes[0], Equipaje.Light, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 13), Vuelos[11], Clientes[1], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 18), Vuelos[12], Clientes[2], Equipaje.Cabina, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 15), Vuelos[13], Clientes[3], Equipaje.Light, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 20), Vuelos[14], Clientes[4], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 17), Vuelos[15], Clientes[5], Equipaje.Cabina, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 18), Vuelos[16], Clientes[6], Equipaje.Bodega, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 19), Vuelos[17], Clientes[7], Equipaje.Light, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 20), Vuelos[18], Clientes[8], Equipaje.Cabina, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 21), Vuelos[19], Clientes[9], Equipaje.Bodega, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 23), Vuelos[20], Clientes[0], Equipaje.Cabina, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 24), Vuelos[21], Clientes[1], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 24), Vuelos[22], Clientes[2], Equipaje.Light, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 25), Vuelos[23], Clientes[3], Equipaje.Bodega, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 26), Vuelos[24], Clientes[4], Equipaje.Cabina, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 27), Vuelos[25], Clientes[5], Equipaje.Bodega, 2));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 28), Vuelos[26], Clientes[6], Equipaje.Light, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 29), Vuelos[27], Clientes[7], Equipaje.Cabina, 0));
            AgregarPasaje(new Pasaje(new DateTime(2025, 6, 30), Vuelos[28], Clientes[8], Equipaje.Bodega, 1));
            AgregarPasaje(new Pasaje(new DateTime(2025, 7, 1), Vuelos[29], Clientes[9], Equipaje.Cabina, 2));
                                    
        }
        private void PrecargarAdministrador()
        {
            
            AgregarAdministrador(new Administrador("admin1@aerolinea.com", "superadmin", "Ibarra"));
            AgregarAdministrador(new Administrador("admin2@aerolinea.com", "adminpass2", "Melo"));

        }
        private void AgregarAdministrador(Administrador a)
        {
            if (a == null) throw new Exception("El administrador no puede ser nulo");
            if (_administradores.Contains(a)) throw new Exception($"El administrador {a.Apodo} ya existe");
            a.Validar();
            _administradores.Add(a);
        }
        private void AgregarAeropuerto(Aeropuerto a)
        {
            if (a == null) throw new Exception("El aeropuerto no puede ser nulo");
            if (_aeropuertos.Contains(a)) throw new Exception($"El aeropuerto {a.Nombre} ya existe");
            a.Validar();
            _aeropuertos.Add(a);
        }
        private void AgregarAvion(Avion a)
        {
            if (a == null) throw new Exception("El avión no puede ser nulo");
            if (_aviones.Contains(a)) throw new Exception($"El avion {a.Fabricante} {a.Modelo} ya existe");
            a.Validar();
            _aviones.Add(a);
        }
        private void AgregarCliente(Cliente c)
        {
            if (c == null) throw new Exception("El cliente no puede ser nulo");
            if (_clientes.Contains(c)) throw new Exception($"El cliente {c.Nombre} {c.Documento} ya existe");
            c.Validar();
            _clientes.Add(c);
        }
        private bool GenerarElegibilidad()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2) == 1;
        }
        private void AgregarRuta(Ruta r)
        {
            if (r == null) throw new Exception("La ruta no puede ser nula");
            if (_rutas.Contains(r)) throw new Exception("La ruta ya existe");
            r.Validar();
            _rutas.Add(r);
            
        }
        private void AgregarVuelo(Vuelo v)
        {
            if (v == null) throw new Exception("El vuelo no puede ser nulo");
            int i = 0;
            bool repetido = false;
            while (!repetido && i < _vuelos.Count)
            {
                if (_vuelos[i].NumeroVuelo.ToUpper() == v.NumeroVuelo.ToUpper())
                {
                    repetido = true;
                }
                i++;
            }
            if (repetido) throw new Exception($"El vuelo {v.NumeroVuelo} ya existe");
            v.Validar();
            _vuelos.Add(v);
        }
        private void AgregarPasaje(Pasaje p)
        {
            if (p == null) throw new Exception("El pasaje no puede ser nulo");
           
            // Control de repetidos: mismo pasajero, mismo vuelo, misma fecha
            bool repetido = false;
            int i = 0;
            while (!repetido && i < _pasajes.Count)
            {
                Pasaje otro = _pasajes[i];
                if (
                    otro.Pasajero.Documento.ToUpper() == p.Pasajero.Documento.ToUpper() &&
                    otro.Vuelo.NumeroVuelo.ToUpper() == p.Vuelo.NumeroVuelo.ToUpper() &&
                    otro.FechaPasaje.Date == p.FechaPasaje.Date
                )
                {
                    repetido = true;
                }
                i++;
            }
            if (repetido) throw new Exception("Ya existe un pasaje para este pasajero, vuelo y fecha");

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
        private Cliente BuscarClientePorDocumento(string documento)
        {
            Cliente encontrado = null;
            int i = 0;
            while (encontrado == null && i < _clientes.Count)
            {
                if (_clientes[i].Documento.ToUpper().Equals(documento.ToUpper()))
                    encontrado = _clientes[i];
                i++;
            }
            return encontrado;
        }
        // Buscar Ruta por Id
        public Ruta BuscarRutaPorId(int id)
        {
            Ruta encontrada = null;
            int i = 0;
            while (encontrada == null && i < _rutas.Count)
            {
                if (_rutas[i].IdRuta == id)
                    encontrada = _rutas[i];
                i++;
            }
            if (encontrada == null)
                throw new Exception($"No se encontró la ruta con ID: {id}");
            return encontrada;
        }

        // Buscar Avión por Modelo (devuelve el primero que encuentra con ese modelo)
        public Avion BuscarAvionPorModelo(string modelo)
        {
            Avion encontrado = null;
            int i = 0;
            while (encontrado == null && i < _aviones.Count)
            {
                if (_aviones[i].Modelo.ToUpper() == modelo.ToUpper())
                    encontrado = _aviones[i];
                i++;
            }
            if (encontrado == null)
                throw new Exception($"No se encontró avión con modelo: {modelo}");
            return encontrado;
        }
        public void AltaClienteOcasional(string email, string contrasenia, string documento, string nombre, string nacionalidad)
        {
            if (BuscarClientePorDocumento(documento) != null) 
                throw new Exception("Ya existe un cliente con ese documento");
            bool elegible = GenerarElegibilidad();
            Cliente nuevo = new ClienteOcasional(email, contrasenia, documento, nombre, nacionalidad, elegible);
            nuevo.Validar();
            AgregarCliente(nuevo);
        }
        public List<Cliente> ListarClientes()
        {
            if (_clientes.Count == 0) throw new Exception("No hay clientes registrados");
            return _clientes;
        }
        public List<Vuelo> ListarVuelosPorAeropuerto(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
                throw new Exception("El código no puede ser vacío, por favor ingrese un valor válido");

            List<Vuelo> encontrados = new List<Vuelo>();
            
            for (int i = 0; i < _vuelos.Count; i++)
            {
                Vuelo v = _vuelos[i];
                string salida = v.RutaAsociada.AeropuertoSalida.CodigoIata.ToUpper();
                string llegada = v.RutaAsociada.AeropuertoDeLlegada.CodigoIata.ToUpper();

                if (salida.Equals(codigo.ToUpper()) || llegada.Equals(codigo.ToUpper()))
                {
                    encontrados.Add(v);
                }
            }

            if (encontrados.Count == 0)
                throw new Exception("No se encontraron vuelos con ese código de aeropuerto");
            return encontrados;
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
