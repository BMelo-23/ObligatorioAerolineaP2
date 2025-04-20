namespace Dominio
{
    public class Sistema
    {
        private List<Aeropuerto> _aeropuertos = new List<Aeropuerto>();
        private List<Avion>      _aviones     = new List<Avion>();
        private List<Vuelo>      _vuelos      = new List<Vuelo>();
        private List<Pasajero>   _pasajeros   = new List<Pasajero>();
        private List<Usuario>    _usuarios    = new List<Usuario>();
        private List<Ruta>       _rutas       = new List<Ruta>();
        
        public List<Usuario> Usuarios
        {
            get { return _usuarios; }
        }
        public List<Aeropuerto> Aeropuertos
        {
            get { return _aeropuertos; }
        }
        public List<Avion> Aviones
        {
            get { return _aviones; }
        }
        public List<Vuelo> Vuelos
        {
            get { return _vuelos; }
        }
        public List<Pasajero> Pasajeros
        {
            get { return _pasajeros; }
        }
        public Sistema()
        {
            PrecargarAeropuertos();
            PrecargarAviones();
            PrecargarPasajeros();
            PrecargarVuelos();
        }
        private void PrecargarAeropuertos()
        {
            //TO DO Se debe de agregar dentro de Aeropuerto lo que corresponde
          //  AgregarAeropuerto(new Aeropuerto());
        }
        private void PrecargarAviones()
        {
            //TO DO Se debe de agregar los datos dentro de Avion("Boeing 737",180)
            AgregarAvion(new Avion());
            
        }
        private void PrecargarPasajeros()
        {
            //TO DO se debe de agregar adentro del pasajero los datos
            AgregarPasajero(new Pasajero());
        }
        private void PrecargarVuelos()
        {
            //TO DO Precarga de datos falta cargar datos a vuelo
            Aeropuerto origen  = BuscarAeropuertoPorCodigo("MVD");
            Aeropuerto destino = BuscarAeropuertoPorCodigo("JFK");
            Avion avion = _aviones[0];
          //  AgregarVuelo(new Vuelo());
        }
        public void AgregarAeropuerto(Aeropuerto a)
        {
            if (a == null) throw new Exception("El aeropuerto no puede ser nulo");
            a.Validar();
            _aeropuertos.Add(a);
        }
        public void AgregarAvion(Avion a)
        {
            if (a == null) throw new Exception("El avion no puede ser nulo");
         //   a.Validar();
            _aviones.Add(a);
        }
        public void AgregarVuelo(Avion v)
        {
            if (v == null) throw new Exception("El vuelo no puede ser nulo");
            //v.Validar();
            _aviones.Add(v);
        }
        public void AgregarUsuario(Usuario u)
        {
            if (u == null) throw new Exception("El usuario no puede ser nulo");
            //u.Validar(u);
            _usuarios.Add(u);
        }
        public void AgregarRuta(Ruta r) 
        {
            if (r == null) throw new Exception("La ruta no puede ser nula");
           // r.Validar(r);
            _rutas.Add(r);
        }
        public void AgregarPasajero(Pasajero p)
        {
            if (p == null) throw new Exception("El pasajero no puede ser nulo");
            p.Validar();
            _pasajeros.Add(p);
        }
        public Aeropuerto BuscarAeropuertoPorCodigo(string codigo)
        {
            Aeropuerto buscando = null;
            int i = 0;
            while (buscando == null && i < _aeropuertos.Count)
            {
                if (_aeropuertos[i].CodigoIata.ToUpper() == codigo.ToUpper()) buscando = _aeropuertos[i];
                i++;
            }
            return buscando;
        }
        public Pasajero BuscarPasajeroPorDocumento(string documento)
        {
            Pasajero buscando = null;
            int i = 0;
            while (buscando == null && i < _pasajeros.Count)
            {
                if (_pasajeros[i].DocumentoPasajero == documento) buscando = _pasajeros[i];
                i++;
            }
            return buscando;
        }

    }
}
