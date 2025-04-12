
namespace Dominio
{
	public class Pasajero : IValidable
	{
		private int _idPasaje;
		private Vuelo _vuelo;
		private DateTime _fechaPasaje;
		private Cliente _pasajero;
		private Equipaje _equipaje;
		private double _precio;
		private Vuelo vuelo;

		public string DocumentoPasajero
		{
			get { return _pasajero.Documento; }
		}

		private void ValidarFechaDelVuelo()
		{

		}

		public List<Pasajero> ListarPasajes(DateTime fechaInicio, DateTime fechaFin)
		{
			return null;
		}

		public void Validar()
		{

		}

	}

}

