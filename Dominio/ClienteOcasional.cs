
namespace Dominio
{
	public class ClienteOcasional : Cliente
	{
		private bool _elegibleParaRegalo;

		public bool ElegibleParaRegalo
		{
			get { return _elegibleParaRegalo; }
		}

		public ClienteOcasional(string email, string contrasenia, string documento, string nombre, string nacionalidad, bool elegibleParaRegalo) 
			: base(email, contrasenia, documento, nombre, nacionalidad)
		{
			_elegibleParaRegalo = elegibleParaRegalo;
		}
		
		public override string DatosCliente()
		{
			return $"Nombre {Nombre} Email {Email} Nacionalidad {Nacionalidad}  Elegible para regalo {(_elegibleParaRegalo ? "Sí" : "No")}";
		}

	}

}

