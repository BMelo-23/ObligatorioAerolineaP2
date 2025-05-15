using Dominio.Interfaces;
namespace Dominio {

    public class Aeropuerto : IValidable
    {
        private string _codigoIata;
        private string _ciudad;
        private string _nombre;
        private double _costoDeOperacion;
        private double _costoDeTasasAero;
        
        private List<Vuelo> _vuelos = new List<Vuelo>();
        public string CodigoIata
        {
            get { return _codigoIata;  }
        }
        public string Ciudad
        {
            get { return _ciudad; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public double CostoDeOperacion
        {
            get { return _costoDeOperacion; }
        }
        public double CostoTasas
        {
            get { return _costoDeTasasAero; }
        }
      
        private void ValidarCodigoIata()
        {
            if (!string.IsNullOrEmpty(_codigoIata) && _codigoIata.Length != 3) 
                throw new Exception("El código de IATA debe de tener 3 letras");
        }
        private void ValidacionDeCostos()
        {
            if (_costoDeOperacion < 1) throw new Exception("Costo de operación es inválido");
            if (_costoDeTasasAero < 1) throw new Exception("Costo de tasas aéreas es inválido");
        }
        public List<Vuelo> Vuelos
        {
            get { return _vuelos; }
        }
        public Aeropuerto(string codigoIata ,string ciudad, string nombre, double costoDeOperacion, double costoDeTasasAero)
        {
            _codigoIata = codigoIata;
            _ciudad = ciudad;
            _nombre = nombre;
            _costoDeOperacion = costoDeOperacion;
            _costoDeTasasAero = costoDeTasasAero;
        }
        public void AgregarVuelo(Vuelo vuelo)
        {
            if (vuelo == null) throw new Exception("Vuelo no puede ser vacío");
            _vuelos.Add(vuelo);
        }
        public void Validar()
        {
            ValidarCodigoIata();
            ValidacionDeCostos();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Aeropuerto otro = (Aeropuerto)obj;
            return _codigoIata.ToUpper() == otro.CodigoIata.ToUpper();
        }
        
    }
}
