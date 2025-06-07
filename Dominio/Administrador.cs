
namespace Dominio
{
	public class Administrador : Usuario
	{
		private string _apodo;

		public string Apodo
		{
			get { return _apodo; }
		}
		public Administrador(string email, string contrasenia, string apodo) : base(email, contrasenia)
		{
			_apodo = apodo;
		}

		public override void Validar()
		{
			base.Validar();
			if (string.IsNullOrEmpty(_apodo)) throw new Exception("El apodo no puede estar vacio");

		}

		public override string ToString()
		{
			return $"Apodo: {_apodo} Email: {_email}";
		}
		
		public override bool Equals(object obj)
		{
			Administrador otro = obj as Administrador;
			return otro != null && _email.ToUpper() == otro._email.ToUpper();
		}
		
	}
}

