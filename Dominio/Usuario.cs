using System;
using Dominio.Interfaces;
namespace Dominio
{
	public abstract class Usuario : IValidable
	{
		protected string _email;
		protected string _contrasenia;

		public string Email
		{
			get { return _email; }
		}
		public string Contrasenia
		{
			get { return _contrasenia; }
		}

		public Usuario(string email, string contrasenia)
		{
			_email = email;
			_contrasenia = contrasenia;
		}

		public virtual void Validar()
		{
			if (string.IsNullOrEmpty(_email) || !_email.Contains('@')) throw new Exception("El mail no es válido");
			if (string.IsNullOrEmpty(_contrasenia) || _contrasenia.Length < 6)
				throw new Exception("La contraseña debe tener al menos 6 caracteres");
		}

		public abstract override string ToString();

	}
	
}

