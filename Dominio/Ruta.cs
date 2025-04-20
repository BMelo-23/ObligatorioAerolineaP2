using Dominio.Interfaces;
namespace Dominio                                               
{
	public class Ruta : IValidable
	{
		private static int _contadorId = 1;
		
		private int _idRuta;
		private Aeropuerto _aeroDeSalida;
		private Aeropuerto _aeroDeLlegada;
		private double _distancia;
		//private Aeropuerto[] aeropuerto;

		public int IdRuta
		{
			get { return _idRuta; }
		}
		public Aeropuerto AeropuertoSalida
		{
			get { return _aeroDeSalida; } //.CodigoIata; }
		}
		public Aeropuerto AeropuertoDeLlegada
		{
			get { return _aeroDeLlegada; } //.CodigoIata; }
		}
		public double Distancia
		{
			get { return _distancia; }
		}
		public Ruta(Aeropuerto aeroDeSalida, Aeropuerto aeroDeLlegada, double distancia)
		{
			_idRuta = _contadorId;
			_contadorId++;
			
			_aeroDeSalida  = aeroDeSalida;
			_aeroDeLlegada = aeroDeLlegada;
			_distancia     = distancia;
		}
		public override bool Equals(object? obj)
		{
			if (obj is null) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((Ruta)obj);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(_aeroDeSalida, _aeroDeLlegada, _distancia);
		}

		public void Validar()
		{
			if ( _aeroDeSalida  == null ) throw new Exception("El aeropuerto de salida no puede ser nulo");
			if ( _aeroDeLlegada == null ) throw new Exception("El aeropuerto de llegada no puede ser nulo");
			if ( _distancia <= 0 ) throw new Exception("la distancia debe ser mayor 0");
		}
	}

}

