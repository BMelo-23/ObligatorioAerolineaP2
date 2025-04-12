using Dominio;

namespace Dominio
{
	public class Ruta
	{
		private int _idRuta;
		private Aeropuerto _aeroDeSalida;
		private Aeropuerto _aeroDeLlegada;
		private double _distancia;
		private Aeropuerto[] aeropuerto;

		public string AeropuertoSalida
		{
			get { return _aeroDeSalida.CodigoIata; }
		}
		public string AeropuertoDeLlegada
		{
			get { return _aeroDeLlegada.CodigoIata; }
		}
		public Ruta(Aeropuerto aeroDeSalida, Aeropuerto aeroDeLlegada, double distancia)
		{
			_aeroDeSalida = aeroDeSalida;
			_aeroDeLlegada = aeroDeLlegada;
			_distancia = distancia;
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
	}

}

