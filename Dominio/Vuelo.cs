using Dominio.Interfaces;

namespace Dominio
{
	public class Vuelo : IValidable
	{
		private string _numeroVuelo;
		private Ruta _ruta;
		private Avion _aeronave;
		private List<DiaDeSemana> _frecuencia;
		private int _costoXAsiento;
		private Avion avion;

		public string NumeroVuelo
		{
			get { return _numeroVuelo; }
		}

		public Ruta RutaAsociada
		{
			get { return _ruta; }
		}

		public Avion Aeronave
		{
			get { return _aeronave; }
	    }

		public List<DiaDeSemana> Frecuencia
		{
			get { return _frecuencia; }
		}
		
		public Vuelo(string numeroVuelo, Ruta ruta, Avion aeronave, List<DiaDeSemana> frecuencia)
		{
			_numeroVuelo = numeroVuelo;
			_ruta = ruta;
			_aeronave = aeronave;
			_frecuencia = frecuencia;
		}


		private void ValidarNumeroVuelo(string NumVuelo)
		{

		}

		private void ValidarAlcance()
		{

		}

		public void Validar()
		{
			if (string.IsNullOrEmpty(_numeroVuelo)) throw new Exception("El número de vuelo no puede estar vacío.");

			ValidarNumeroVuelo();
			
			if (_ruta == null) throw new Exception("La ruta no puede ser nula.");
			
			if (_aeronave == null) throw new Exception("El avión no puede ser nulo.");

			if (_frecuencia == null || _frecuencia.Count == 0) throw new Exception("La frecuencia debe tener al menos un día de operación.");
			
			if (_aeronave.Alcance < _ruta.Distancia) throw new Exception("El avión no tiene el alcance suficiente para cubrir esta ruta.");
		}

		private void ValidarNumeroVuelo()
		{
			if (_numeroVuelo.Length < 3 || _numeroVuelo.Length > 6) 
				throw new Exception("El número de vuelo debe tener entre 3 y 6 caracteres");

			string letras = _numeroVuelo.Substring(0, 2);
			string numeros = _numeroVuelo.Substring(2);

			if (!char.IsLetter(letras[0]) || !char.IsLetter(letras[1]))
				throw new Exception("El número de vuelo debe comenzar con 2 letras");

			for (int i = 0; i < letras.Length; i++)
			{
				if (!char.IsUpper(letras[i]))
					throw new Exception("Las letras del número de vuelo deben estar en mayúsculas");
			}

			if (string.IsNullOrEmpty(numeros) || numeros.Length > 4) //|| !EsNumero(numeros))
				throw new Exception("El número de vuelo debe terminar con 1 a 4 dígitos.");
			
		}

	}

}

