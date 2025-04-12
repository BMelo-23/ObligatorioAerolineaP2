using Dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
	public class Cliente : Usuario
	{
		private string _documento;
		private string _nombre;
		private string _nacionalidad;

		public string Documento
		{
			get { return _documento; }
		}
		public override string ToString()
        {
            return $"Cliente: {_nombre}, Mail: {_email}, Nac: {_nacionalidad}, Puntos: {_puntos}";
        }

    }
}

