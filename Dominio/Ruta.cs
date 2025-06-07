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
		
		public int IdRuta
		{
			get { return _idRuta; }
		}
		public Aeropuerto AeropuertoSalida
		{
			get { return _aeroDeSalida; }
		}
		public Aeropuerto AeropuertoDeLlegada
		{
			get { return _aeroDeLlegada; }
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
			Ruta otra = obj as Ruta;
			return otra != null &&
			       _aeroDeSalida.Equals(otra._aeroDeSalida) &&
			       _aeroDeLlegada.Equals(otra._aeroDeLlegada);
		}
		
		public void Validar()
		{
			if ( _aeroDeSalida  == null ) throw new Exception("El aeropuerto de salida no puede ser nulo");
			if ( _aeroDeLlegada == null ) throw new Exception("El aeropuerto de llegada no puede ser nulo");
			if (_aeroDeSalida.Equals(_aeroDeLlegada))
				throw new Exception("La ruta no puede ser entre el mismo aeropuerto");
			if ( _distancia <= 0 ) throw new Exception("la distancia debe ser mayor 0");
		}
	}

}

