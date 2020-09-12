
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Usuario : Persona , ICrud {

	public Usuario() {
	}

	private Image actaNacimientoComprobante;

	private Image cartaNoAntecedentesP;

	private Image certificadoEscolar;

	private string numeroSeguroSocial;

	private TipoUsuario tipoUsuario;

	private string contraseña;



	/// <summary>
	/// @return
	/// </summary>
	public bool alta() {
		// TODO implement here
		return False;
	}

	/// <summary>
	/// @param datos 
	/// @param id 
	/// @return
	/// </summary>
	public bool modificar(Usuario datos, int id) {
		// TODO implement here
		return False;
	}

	/// <summary>
	/// @param id 
	/// @return
	/// </summary>
	public bool eliminar(int id) {
		// TODO implement here
		return False;
	}

	/// <summary>
	/// @param criteriosBusqueda 
	/// @return
	/// </summary>
	public List<Usuario> consultar(object criteriosBusqueda) {
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @param us 
	/// @param contraseña 
	/// @return
	/// </summary>
	public TipoUsuario login(string us, string contraseña) {
		// TODO implement here
		return null;
	}

}