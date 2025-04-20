using Dominio.Interfaces;
namespace Dominio
{
	public class Avion : IValidable
	{
		private string _fabricante;
		private string _modelo;
		private int    _cantDeAsientos;
		private double _alcance;
		private double _costoOpXKm;

		public string Fabricante
		{
			get { return _fabricante;}
		}
		public string Modelo
		{
			get { return _modelo;}
		}
		public int CantDeAsientos
		{
			get { return _cantDeAsientos; }
		}
		public double Alcance
		{
			get { return _alcance; }
		}
		public double CostoOpXKm
		{
			get { return _costoOpXKm; }
	}
		public Avion(string fabricante, string modelo, int cantDeAsientos, double alcance, double costoOpXKm)
		{
			_fabricante     = fabricante;
			_modelo         = modelo;
			_cantDeAsientos = cantDeAsientos;
			_alcance        = alcance;
			_costoOpXKm     = costoOpXKm;
		}

		public void Validar()
		{
			if (string.IsNullOrEmpty(_fabricante)) throw new Exception("El fabricante no puede estar vacío");

			if (string.IsNullOrEmpty(_modelo))  throw new Exception("El modelo no puede estar vacío");

			if (_cantDeAsientos <= 0) throw new Exception("La cantidad de asientos debe ser mayor a cero");

			if (_alcance <= 0) throw new Exception("El alcance debe ser mayor a cero");

			if (_costoOpXKm <= 0) throw new Exception("El costo de operación por km debe ser mayor a cero");
		}
		
		public override string ToString()
		{
			return $"Avión: {_fabricante} {_modelo}, Asientos: {_cantDeAsientos}, Alcance: {_alcance} km, Costo por km: ${_costoOpXKm}";
		}
	}

}

