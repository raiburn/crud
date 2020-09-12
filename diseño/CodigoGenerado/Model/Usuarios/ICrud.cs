
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICrud {

	public abstract void alta()();

	public abstract void modificar(datos:object, id:int)();

	public abstract void eliminar(id:int)();

	public abstract void consultar(criteriosBusqueda:object)();

}