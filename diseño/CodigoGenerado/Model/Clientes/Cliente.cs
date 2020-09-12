
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cliente : Persona , ICrud {

	public Cliente() {
	}

	private List<PersonaAlternativa> listaPersonasAlternativas;


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
	public bool modificar(Cliente datos, int id) {
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
	public List<Cliente> consultar(object criteriosBusqueda) {
		// TODO implement here
		return null;
	}

}