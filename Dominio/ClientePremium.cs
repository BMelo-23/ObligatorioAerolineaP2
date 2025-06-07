
namespace Dominio
{
	public class ClientePremium : Cliente
	{
		private int _puntos;
		
		public ClientePremium(string email, string contrasenia, string documento, string nombre, string nacionalidad, int puntos)
			: base(email, contrasenia, documento, nombre, nacionalidad)
		{
			_puntos = puntos;
		}

		public override void Validar()
		{
			base.Validar();
			if (_puntos <= 0) throw new Exception("Los puntos deben deben ser mayor 0");
		}
		public override string DatosCliente()
		{
			return $"Nombre {Nombre} Email {Email} Nacionalidad {Nacionalidad} Puntos: {_puntos}";
		}
	}

}

