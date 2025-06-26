using Dominio.Interfaces;

namespace Dominio
{
    public class Pasaje : IValidable
    {
        private static int _ultimoId = 1;
        private int _idPasaje;
        private DateTime _fechaPasaje;
        private Vuelo _vuelo;
        private Cliente _pasajero;
        private Equipaje _tipoEquipaje;
        private double _precio;

        public int IdPasaje
        {
            get { return _idPasaje; }
        }

        public DateTime FechaPasaje
        {
            get { return _fechaPasaje; }
        }

        public Vuelo Vuelo
        {
            get { return _vuelo; }
        }

        public Cliente Pasajero
        {
            get { return _pasajero; }
        }

        public Equipaje TipoEquipaje
        {
            get { return _tipoEquipaje; }
        }

        public double Precio
        {
            get { return _precio; }
        }

        public Pasaje(DateTime fechaPasaje, Vuelo vuelo, Cliente pasajero, Equipaje tipoEquipaje, double precio)
        {
            _idPasaje = _ultimoId++;
            _fechaPasaje = fechaPasaje;
            _vuelo = vuelo;
            _pasajero = pasajero;
            _tipoEquipaje = tipoEquipaje;
            _precio = precio;
        }

        public void Validar()
        {
            if (_fechaPasaje == DateTime.MinValue) throw new Exception("La fecha del pasaje no puede estar vacía");
            if (_vuelo == null) throw new Exception("El vuelo no puede ser nulo");
            if (_pasajero == null) throw new Exception("El pasajero no puede ser nulo");

            ValidarFrecuencia();
        }

        public override string ToString()
        {
            return $"Pasaje {_idPasaje} Fecha {_fechaPasaje.ToShortDateString()}  Vuelo {_vuelo.NumeroVuelo}  Pasajero {_pasajero.Nombre}  Precio ${_precio:F2}";
        }
        
        private void ValidarFrecuencia()
        {
            DiaDeSemana diaPasaje = TraducirDayOfWeek(_fechaPasaje.DayOfWeek);

            bool diaEnFrecuencia = false;
            int i = 0;
            while (!diaEnFrecuencia && i < _vuelo.Frecuencia.Count)
            {
                if (_vuelo.Frecuencia[i] == diaPasaje)
                {
                    diaEnFrecuencia = true;
                }
                i++;
            }

            if (!diaEnFrecuencia)
                throw new Exception($"La fecha del vuelo {_vuelo.NumeroVuelo} nombre {_pasajero.Nombre} documento {_pasajero.Documento} no coincide con la frecuencia del vuelo");
        }

        private DiaDeSemana TraducirDayOfWeek(DayOfWeek dia)
        {
            DiaDeSemana esDia;
            switch (dia)
            {
                case DayOfWeek.Monday: esDia = DiaDeSemana.Lunes; 
                    break;
                case DayOfWeek.Tuesday: esDia = DiaDeSemana.Martes; 
                    break;
                case DayOfWeek.Wednesday: esDia = DiaDeSemana.Miercoles; 
                    break;
                case DayOfWeek.Thursday: esDia = DiaDeSemana.Jueves; 
                    break;
                case DayOfWeek.Friday: esDia = DiaDeSemana.Viernes; 
                    break;
                case DayOfWeek.Saturday: esDia = DiaDeSemana.Sabado; 
                    break;
                case DayOfWeek.Sunday: esDia = DiaDeSemana.Domingo; 
                    break;
                default:
                    throw new Exception("El día ingresado no es válido");
            }
            return esDia;
        }
    }
}
