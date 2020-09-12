using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibBD;
using Lib_pdv_uth_v1.usuarios;

namespace Lib_pdv_uth_v1.clientes
{
    public class Cliente : Persona, ICrud
    {
        public static string msgError;

        LibMySql bd;

        public Cliente(): base(1,"", "", new DateTime(), "", "", "","", new Domicilio(), "", "", "" )
        {
            bd = new LibMySql("localhost", "root", "123123", "pdv_uth_bd_v1");

        }

        public Cliente(int id, string nombre, string apellidoPaterno, DateTime fecha, string apellidoMaterno, string celular, string telefono, string correo, Domicilio domicilio, object comprobanteINE, string curp, object curpCompro):base(id,  nombre,  apellidoPaterno,  fecha,  apellidoMaterno,  celular,  telefono,  correo,  domicilio,  comprobanteINE,  curp,  curpCompro)  
        {
            bd = new LibMySql("localhost", "root", "123123", "pdv_uth_bd_v1");

        }

        public bool insertar(string nom, string apP, string apM,  string cel, string correo, string  fechaNac,
                             string calle, string numCasa, string colonia, string cp, 
                             string localidad, string municipio, string comprobanteDom, string comproINE, string curp, string curpCompro)
        { 
            bool res = false;
            string valores = "'"+nom+"','"+apP+"','"+apM+"','"+cel+"','"+correo+"','"+fechaNac+"','"+calle+"','"+numCasa+"','"+colonia+"','"+cp+"','"+localidad+"','"+municipio+"','"+comprobanteDom+"','"+comproINE+"','" +curp+ "','" +curpCompro+ "'";
            if (bd.insertar("clientes",
                            "nombre, apellido_paterno,apellido_materno, celular, correo, fecha_de_nacimiento,"+
                            "calle, numero_casa, colonia, codigo_postal, localidad, municipio, img_comprobante_domicilio, ine_comprobante, curp, curp_comprobante",
                            valores))
            {
                res = true;
            }else{
                msgError = "Error al dar de alta nuevo cliente. " + LibMySql.msgError;
            }
            return res;
        }

        public bool actualizar(string nom, string apP, string apM, string cel, string correo, string fechaNac,
                             string calle, string numCasa, string colonia, string cp,
                             string localidad, string municipio, string comprobanteDom, string comproINE, string curp, string curpCompro)
        {
            bool res = false;
            if (bd.actualizar("clientes",
                              "nombre='" + nom + "',apellido_paterno='" + apP + "',apellido_materno='" + apM + "',celular='" + cel + "', correo='" + correo + "'"
                              , " fecha_de_nacimiento='" + fechaNac + "', calle = '" + calle + "', numero_casa='" + numCasa + "', colonia='" + colonia + "', codigo_postal='" + cp
                              + "', localidad='" + localidad + "', municipio='" + municipio + "', img_comprobante_domicilio ='" + comprobanteDom + "', ine_comprobante='"+
                              comproINE + "', curp='"+curp + "', curp_comprobante='"+curpCompro
                            )
                )
            { res = true; }
            else
            {
                msgError = "Error al actualizar cliente. " + LibMySql.msgError;
            }
            return res;
        }

       

        public List<Cliente> consultar(string nombre, string apellido, string calle)
        {
            string where = "nombre LIKE '%" + nombre + "%' AND ( apellido_paterno LIKE '%" + apellido + "%' OR  apellido_materno LIKE '%" + apellido + "%') AND calle LIKE '%" + calle + "%'";
            List<object> listaTemp =  bd.consultar("*", "clientes", where);
            List<Cliente> listaCliente = new List<Cliente>();
            foreach (var registro in listaTemp)
            {
                for (int i = 0; i < listaTemp.Count; i++)
                {
                    object[] arreglo = (object[])registro;
                    //creamos un objeto Cliente
                    Cliente temp = new Cliente
                    {
                        //poner todos los valores en el objeto cliente temp
                        Id = int.Parse(arreglo[0].ToString()),
                        Nombre = arreglo[1].ToString(),
                        ApellidoPaterno = arreglo[2].ToString()
                    };
                    temp.ApellidoPaterno = arreglo[3].ToString();
                    temp.FechaNacimiento =  DateTime.Parse(arreglo[4].ToString());
                    temp.Celular = arreglo[5].ToString();
                    temp.Telefono = arreglo[6].ToString();
                    temp.Correo = arreglo[7].ToString();
                    temp.Domicilio = new Domicilio(arreglo[8].ToString(), 
                        arreglo[9].ToString(), arreglo[10].ToString(), 
                        arreglo[11].ToString(), arreglo[12].ToString(), 
                        arreglo[13].ToString(), arreglo[14].ToString(), arreglo[15].ToString());
                    temp.ComprobanteINE = arreglo[16];
                    temp.Curp = arreglo[17].ToString();
                    temp.CurpCompro = arreglo[18];
                    //ponemos obj temp  en clistacliente
                    listaCliente.Add(temp);
                }
            }
            return listaCliente;
        }

        public bool alta()
        {
            string fechaCorrecta = this.FechaNacimiento.Year + "-" + this.FechaNacimiento.Month + "-" + this.FechaNacimiento.Day;

            return insertar(this.Nombre, this.ApellidoPaterno, this.ApellidoMaterno, this.Celular,
                            this.Correo, fechaCorrecta, this.Domicilio.calle, this.Domicilio.numero,
                            this.Domicilio.colonia, this.Domicilio.codigoPostal, this.Domicilio.localidad,
                            this.Domicilio.municipio, this.Domicilio.fotoComprobante.ToString(), this.ComprobanteINE.ToString(), this.Curp, this.CurpCompro.ToString());
        }

        public bool modificar(List<DatosParaActualizar> datos, int id)
        {
            //crear la lista de datos
            string camposValores = "";
            for (int i = 0; i < datos.Count; i++)
            {
                camposValores += " " + datos[i].campo + " = '" + datos[i].valor+"'";
                if (i < datos.Count - 1) camposValores += ",";                
            }
            //ejecuta el actualizar de BD con los datos
            return bd.actualizar("clientes", camposValores, "id=" + id);
            //regresar el res
        }

        public bool eliminar(int id)
        {
            return bd.eliminar("clientes", " id=" + id);
        }

        public List<object> consultar(List<CriteriosBusqueda> criteriosBusqueda)
        {
            //lista de object para resultado
            List<object> res = new List<object>();
            //hacemos el where
            string where = "";
            //insttterpretamos los operadores de cada condiciones del WHERE
            for (int i = 0; i < criteriosBusqueda.Count; i++)
            {
                string opIntermedio = "";
                switch (criteriosBusqueda[i].operadorIntermedio)
                {
                    case OperadorDeConsulta.IGUAL:     opIntermedio = "="; break;
                    case OperadorDeConsulta.LIKE:      opIntermedio = "LIKE"; break;
                    case OperadorDeConsulta.DIFERENTE: opIntermedio = "<>"; break;
                    case OperadorDeConsulta.NO_IGUAL:  opIntermedio = "!="; break;
                    default: opIntermedio = ""; break;
                }
                string opFinal = "";
                switch (criteriosBusqueda[i].operadorIntermedio)
                {
                    case OperadorDeConsulta.AND: opFinal = "AND"; break;
                    case OperadorDeConsulta.OR: opFinal = "OR"; break;
                 
                    default: opFinal = ""; break;
                }
                where += " " + criteriosBusqueda[i].campo + " " + opIntermedio + " " + criteriosBusqueda[i].valor + " " + opFinal+" ";
            }//for para hacer where
            //hacemos la consulta
            List<object> tmp = bd.consultar("*", "clientes", where);
            //mapeamos cada Object en un Cliente
            foreach (object[] cliTmp in tmp)
            {
                var cli = new
                {
                    Id = int.Parse(cliTmp[0].ToString()),
                    Nombre = cliTmp[1].ToString(),
                    ApellidoPaterno = cliTmp[2].ToString(),
                    ApellidoMaterno = cliTmp[3].ToString(),
                    FechaNacimiento = DateTime.Parse(cliTmp[4].ToString()),
                    Celular = cliTmp[5].ToString(),
                    Telefono = cliTmp[6].ToString(),
                    Correo = cliTmp[7].ToString(),
                    //Domicilio dom = new Domicilio();
                    calle = cliTmp[8].ToString(),
                    numero = cliTmp[9].ToString(),
                    codigoPostal = cliTmp[10].ToString(),
                    colonia = cliTmp[11].ToString(),
                    seccionFraccionamiento = cliTmp[12].ToString(),
                    localidad = cliTmp[13].ToString(),
                    municipio = cliTmp[14].ToString(),
                    fotoComprobante = cliTmp[15].ToString(),
                    ComprobanteINE = cliTmp[16].ToString(),
                    Curp = cliTmp[17].ToString(),
                    CurpCompro = cliTmp[18].ToString()
                };
                res.Add(cli);
            }
            //regresamos la lista de cliente
            return res;
        }

        public List<Cliente> consulta(List<CriteriosBusqueda> criteriosBusqueda) {
            //lista de object para resultado
            List<Cliente> res = new List<Cliente>();
            //hacemos el where
            string where = "";
            //insttterpretamos los operadores de cada condiciones del WHERE
            for (int i = 0; i < criteriosBusqueda.Count; i++)
                where += " " + criteriosBusqueda[i].campo + " " + criteriosBusqueda[i].opIntermedioSql() + " " + criteriosBusqueda[i].valor + " " + criteriosBusqueda[i].opFinalSql() + " ";
            //hacemos la consulta
            List<object> tmp = bd.consultar("*", "clientes", where);
            //mapeamos cada Object en un Cliente
            foreach (object[] cliTmp in tmp)
            {
                Domicilio dom = new Domicilio();
                dom.calle = cliTmp[8].ToString();
                dom.numero = cliTmp[9].ToString();
                dom.codigoPostal = cliTmp[10].ToString();
                dom.colonia = cliTmp[11].ToString();
                dom.seccionFraccionamiento = cliTmp[12].ToString();
                dom.localidad = cliTmp[13].ToString();
                dom.municipio = cliTmp[14].ToString();
                dom.fotoComprobante = cliTmp[15].ToString();
                object cli = new
                {
                    Id = int.Parse(cliTmp[0].ToString()),
                    Nombre = cliTmp[1].ToString(),
                    ApellidoPaterno = cliTmp[2].ToString(),
                    ApellidoMaterno = cliTmp[3].ToString(),
                    FechaNacimiento = DateTime.Parse(cliTmp[4].ToString()),
                    Celular = cliTmp[5].ToString(),
                    Telefono = cliTmp[6].ToString(),
                    Correo = cliTmp[7].ToString(),
                    Domicilio=dom,
                    ComprobanteINE = cliTmp[16].ToString(),
                    Curp = cliTmp[17].ToString(),
                    CurpCompro = cliTmp[18].ToString()
                };
                res.Add((Cliente)cli);
            }
            //regresamos la lista de cliente
            return res;
        }
        
    }
}
