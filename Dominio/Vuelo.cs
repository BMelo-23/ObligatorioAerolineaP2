using Dominio.Interfaces;

namespace Dominio
{
	public class Vuelo : IValidable
	{
		private string _numeroVuelo;
		private Ruta _ruta;
		private Avion _aeronave;
		private List<DiaDeSemana> _frecuencia;
		private double _costoXAsiento;

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

		public double CostoXAsiento
		{
			get { return _costoXAsiento; }
		}

		public Vuelo(string numeroVuelo, Ruta ruta, Avion aeronave, List<DiaDeSemana> frecuencia)
		{
			_numeroVuelo = numeroVuelo;
			_ruta = ruta;
			_aeronave = aeronave;
			_frecuencia = frecuencia;
			_costoXAsiento = ((_aeronave.CostoOpXKm * _ruta.Distancia) + _ruta.AeropuertoSalida.CostoDeOperacion 
			                  + _ruta.AeropuertoDeLlegada.CostoDeOperacion) / _aeronave.CantDeAsientos;
		}

		private bool EsNumero(string valor)
		{
			return int.TryParse(valor, out int numero);
		}

		private void ValidarNumeroVuelo()
		{
			if (string.IsNullOrEmpty(_numeroVuelo)) throw new Exception("El número de vuelo no puede estar vacío");

			int largo = _numeroVuelo.Length;
			if (largo < 3 || largo > 6) throw new Exception("El número de vuelo debe tener entre 3 y 6 caracteres");

			bool letrasValidas = true;
			int i = 0;
			while (letrasValidas && i < 2)
			{
				if (EsNumero(_numeroVuelo[i].ToString()) || _numeroVuelo[i].ToString() != _numeroVuelo[i].ToString().ToUpper())
				{
					letrasValidas = false;
				}
				i++;
			}

			if (!letrasValidas) throw new Exception("El número de vuelo debe comenzar con 2 letras mayúsculas");

			string parteNumerica = "";
			for (int j = 2; j < largo; j++)
			{
				parteNumerica += _numeroVuelo[j];
			}

			bool esNumeroValido = EsNumero(parteNumerica);

			if (string.IsNullOrEmpty(parteNumerica) || parteNumerica.Length > 4 || !esNumeroValido)
			{
				throw new Exception("El número de vuelo debe terminar con 1 a 4 dígitos.");
			}
		}

		private string ListaDias() {
			
			string dias = "";
			for (int i = 0; i < _frecuencia.Count; i++)
			{
				dias += _frecuencia[i];
				
				if (i == _frecuencia.Count - 2)
				{
					dias += " y ";
				}
				else if (i < _frecuencia.Count - 2)
				{
					dias += ", ";
				}
			}
			
			return dias;
		}

		public void Validar()
		{
			ValidarNumeroVuelo();
			if (string.IsNullOrEmpty(_numeroVuelo)) throw new Exception("El número de vuelo no puede estar vacío");
			if (_ruta == null) throw new Exception("La ruta no puede ser nula");
			if (_aeronave == null) throw new Exception("El avión no puede ser nulo");
			if (_frecuencia  == null || _frecuencia.Count == 0) throw new Exception("La frecuencia debe tener al menos un día de operación");
			if (_aeronave.Alcance < _ruta.Distancia) throw new Exception("El avión no tiene el alcance suficiente para cubrir esta ruta");
		}
		public override string ToString()
		{
			return $"Vuelo: {_numeroVuelo}\nRuta salida: {_ruta.AeropuertoSalida.Nombre} | Ruta de llegada: {_ruta.AeropuertoDeLlegada.Nombre}\nAvión: {_aeronave.Modelo}\nFrecuencias: {ListaDias()}";
		}
	}
}

