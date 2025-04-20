
namespace Dominio
{
	public class ClienteOcacional : Cliente
	{
		private bool _elegibleParaRegalo;

		public bool ElegibleParaRegalo
		{
			get { return _elegibleParaRegalo; }
		}
		public ClienteOcacional(string email, string contrasenia, string documento, string nombre, string nacionalidad, bool elegibleParaRegalo) : base(email, contrasenia, documento, nombre, nacionalidad)
		{
			_elegibleParaRegalo = elegibleParaRegalo;
		}

		public override string ToString()
		{
			return base.ToString() + $" - Elegible para regalo: {(_elegibleParaRegalo ? "Sí" : "No")}";
		}

	}

}

