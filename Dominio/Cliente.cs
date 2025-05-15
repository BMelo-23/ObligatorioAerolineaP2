
namespace Dominio
{
	public abstract class Cliente : Usuario
	{
		protected string _documento;
		protected string _nombre;
		protected string _nacionalidad;

		public string Documento
		{
			get { return _documento; }
		}
		public string Nombre
		{
			get {return _nombre; }
		}
		public string Nacionalidad
		{
			get {return _nacionalidad; }
		}

		public Cliente(string email, string contrasenia, string documento, string nombre, string nacionalidad) : base(email, contrasenia)
		{
			_documento = documento;
			_nombre = nombre;
			_nacionalidad = nacionalidad;
		}
		
		public override void Validar()
		{
			base.Validar();

			if (string.IsNullOrEmpty(_documento))
			{
				throw new Exception("El documento no puede estar vacío.");
			}

			if (string.IsNullOrEmpty(_nombre))
			{
				throw new Exception("El nombre no puede estar vacío.");
			}

			if (string.IsNullOrEmpty(_nacionalidad))
			{
				throw new Exception("La nacionalidad no puede estar vacía.");
			}
		}
		public abstract string DatosCliente();
		
    }
}

