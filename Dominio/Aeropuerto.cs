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
        public string Nombre
        {
            get { return _nombre; }
        }
        public double CostoDeOperacion
        {
            get { return _costoDeOperacion; }
        }
      
        public Aeropuerto(string codigoIata ,string ciudad, string nombre, double costoDeOperacion, double costoDeTasasAero)
        {
            _codigoIata = codigoIata;
            _ciudad = ciudad;
            _nombre = nombre;
            _costoDeOperacion = costoDeOperacion;
            _costoDeTasasAero = costoDeTasasAero;
        }
        
        public void Validar()
        {
            ValidarCodigoIata();
            ValidacionDeCostos();
        }
        private void ValidarCodigoIata()
        {
            if (!string.IsNullOrEmpty(_codigoIata) && _codigoIata.Length != 3) 
                throw new Exception("El código de IATA debe tener 3 letras");
        }
        private void ValidacionDeCostos()
        {
            if (_costoDeOperacion < 1) throw new Exception("Costo de operación es inválido");
            if (_costoDeTasasAero < 1) throw new Exception("Costo de tasas aéreas es inválido");
        }
        public override bool Equals(object? obj)
        {
            Aeropuerto otro = obj as Aeropuerto;
            return otro != null && _codigoIata.ToUpper() == otro._codigoIata.ToUpper();
        }
        
    }
}
