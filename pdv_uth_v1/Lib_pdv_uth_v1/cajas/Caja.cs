using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibBD;

namespace Lib_pdv_uth_v1.cajas
{
    public class Caja
    {
        //prop de BD
        LibMySql bd;
        //var de errores
        public static string msgError = "";
        //props de caja
        private int id;
        private string nombre;
        private List<ProductosAVender> listaProductos = new List<ProductosAVender>();
        //id de Usuario que ABRE LA CAJA
        int idUsuario = 0;
        //la caja esta cerrada por default
        public bool cerrada=true;

        //constructor
        public Caja(int id, string nombre, List<ProductosAVender> listaProductos)
        {
            //mi bd en nube
            bd = new LibMySql("localhost", "root", "123123", "pdv_uth_bd_v1");
            //encapsulamiento de props
            this.id = id;
            this.nombre = nombre;
            this.listaProductos = listaProductos;
        }
        public Caja()
        {
            //mi bd en nube
            bd = new LibMySql("localhost", "root", "123123", "pdv_uth_bd_v1");
            //encapsulamiento de props
        }
        //getters y settres
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<ProductosAVender> ListaProductos { get => listaProductos; set => listaProductos = value; }

        //métodos de VENDER
        /// <summary>
        /// Vender productos con método de pago SOLO EFECTIVO. Para que funcione, deben
        /// estar capturados TODOS los productos a vender en la lista 'listaProductos'
        /// </summary>
        /// <param name="idUsuario">Usuario que abri{o la caja para operaci{on</param>
        /// <param name="efectivo">El total de efectivo con el que el CLIEITNE paga la venta.</param>
        /// <param name="totalDeVenta">El total de la venta que el cliente paga.</param>
        /// <returns>true si se registra la VENTA y todos sus VENTAS DETALLES. False si hay error</returns>
        public bool vender(int idUsuario, double efectivo, double totalDeVenta)
        {
            bool res = false;
            //valore de venta (gral)
            string valoresVenta = "(SELECT MAX(folio) + 1 FROM ventas folioVenta)," + this.id + "," + idUsuario + ",CURDATE(), " + totalDeVenta;
            if (bd.insertar("ventas", "folio, caja_id, usuario_id, fecha_hora, total_venta", valoresVenta))
            {
                //obtenemos el ID de la VENTA, con datos scalar
                int idDeVentaNueva = int.Parse(bd.consultarUnSoloDato("LAST_INSERT_ID()", "ventas", "1").ToString());
                //si se puede registral la venta, ahora se registran los productos
                foreach (ProductosAVender prod in this.listaProductos)
                {
                    //sacamos los valores de cada ProductoAVender... de la lista
                    string valoresDetalle = idDeVentaNueva + "," + prod.idProducto + "," + prod.cantidad;
                    //por cada producto insertamos en ventas detalle
                    if (bd.insertar("ventas_detalles", "venta_id, producto_id, cantidad", valoresDetalle) == false)
                    {
                        //hubo error al insertar
                        res = false;
                        msgError = "Error al insertar en 'ventas_detalles' <" + idDeVentaNueva + "," + prod.idProducto + "," + prod.cantidad + ">";
                        break;
                        //romper el forEach
                    }//insertar detalles ventas
                    else res = true;// si se insertan los detalles de venta yyyyyyy la venta
                }//por cada producto a vender de la venta registrando
            }//insertar DATOS GNERALES DE  venta 
            else
            {
                res = false;
                msgError = "Error al registrar los DATOS GENERALES DE LA VENTA. " + LibMySql.msgError;
            }
            return res;
        }//select

        public bool vender(int idUsuario, double efectivo, double totalDeVenta, string vigenciaMes, string vigenciaAnio, string autorizacionNum)
        {
            bool res = false;
            //valore de venta (gral)
            string valoresVenta = "(SELECT MAX(folio) + 1 FROM ventas folioVenta)," + this.id + "," + idUsuario + ",CURDATE(), " + totalDeVenta;
            
            if (bd.insertar("ventas", "folio, caja_id, usuario_id, fecha_hora, total_venta", valoresVenta))
            {
                //obtenemos el ID de la VENTA, con datos scalar
                int idDeVentaNueva = int.Parse(bd.consultarUnSoloDato("LAST_INSERT_ID()", "ventas", "1").ToString());
                string TarjetaDetalles = idDeVentaNueva+"," +vigenciaMes + "," + vigenciaAnio + "," + autorizacionNum + ",CURDATE()";
                //si se puede registral la venta, ahora se registran los productos
                foreach (ProductosAVender prod in this.listaProductos)
                {
                    //sacamos los valores de cada ProductoAVender... de la lista
                    string valoresDetalle = idDeVentaNueva + "," + prod.idProducto + "," + prod.cantidad;
                    //por cada producto insertamos en ventas detalle
                    if (bd.insertar("ventas_detalles", "venta_id, producto_id, cantidad", valoresDetalle) == false)
                    {
                        //hubo error al insertar
                        res = false;
                        msgError = "Error al insertar en 'ventas_detalles' <" + idDeVentaNueva + "," + prod.idProducto + "," + prod.cantidad + ">";
                        break;
                        //romper el forEach
                    }//insertar detalles ventas
                    
                    else res = true;// si se insertan los detalles de venta yyyyyyy la venta
                }//por cada producto a vender de la venta registrando
                
                    if (bd.insertar("ventas_con_tarjetas", "venta_id, vigencia_mes, vigencia_anio, numero_autorizacion, fecha_hora", TarjetaDetalles) == false)
                    {
                        res = false;
                        msgError = "Error al insertar en 'ventas_con_tarjetas' <" + TarjetaDetalles + ">";
                    }

                    else res = true;// si se insertan los detalles de la tarjeta
            }//insertar DATOS GNERALES DE  venta 
            else
            {
                res = false;
                msgError = "Error al registrar los DATOS GENERALES DE LA VENTA. " + LibMySql.msgError;
            }
            return res;
        }//select


        //TODO: ABRIR CAJA
        /// <summary>
        /// Método de apertura de Caja, indicando el Id del Usuario que la abre.
        /// El default de Dinero de Fondo son $500.00. Sin observaciones
        /// </summary>
        /// <param name="idUsuario">El ID del usuario que APERTURA la caja para operación.</param>
        /// <returns>true si se abre caja, flase en caso de error (Caja.msgError para detalles)</returns>
        public bool abrirCaja(int idUsuario)
        {
            bool res = false;
            //guardamos el id del Usuario
            this.idUsuario = idUsuario;
            //hacemos el registro de la apertura de la caja, siempre el fondo son $500.00
            if (bd.insertar("operacion_cajas", "usuario_id, caja_id, fondo, tipo_operacion, fecha_hr", idUsuario + "," + this.Id + "," + 500 + ",'APERTURA', CURDATE()"))
            {
                res = true;
                //se realizó corte, por lo que se ABRE la caja
                this.cerrada = false;
            }
            else
                msgError = "Error al APERTURAR Caja '" + this.nombre + "' para Operación. " + LibMySql.msgError;
            return res;
        }
        /// <summary>
        /// Permite APERTURAR la caja cno un fondo diferente al default de $500.00
        /// </summary>
        /// <param name="idUsuario">El usuario que abre la caja</param>
        /// <param name="fondo">La cantidad de FONDO para el inicio de operaciones en la caja</param>
        /// <returns>true, si se abre la caja correctamente, false si hay error</returns>
        public bool abrirCaja(int idUsuario, double fondo)
        {
            bool res = false;
            //guardamos el id del Usuario
            this.idUsuario = idUsuario;
            //hacemos el registro de la apertura de la caja, siempre el fondo son $500.00
            if (bd.insertar("operacion_cajas", "usuario_id, caja_id, fondo, tipo_operacion, fecha_hr", idUsuario + "," + this.Id + "," + fondo + ",'APERTURA', CURDATE()"))
            {
                res = true;
                //se realizó corte, por lo que se ABRE la caja
                this.cerrada = false;
            }
            else
                msgError = "Error al APERTURAR Caja '" + this.nombre + "' para Operación. " + LibMySql.msgError;
            return res;
        }

        //TODO: CERRAR CAJA

        public double corteDeCaja(int idUsuario, double montoDinero)
        {
            double res = 0;
            //guardamos el id del Usuario
            this.idUsuario = idUsuario;
            //hacemos el registro de la apertura de la caja, siempre el fondo son $500.00
            if (bd.insertar("operacion_cajas", "usuario_id, caja_id, fondo, tipo_operacion ", 
                                idUsuario + "," + this.Id + "," + montoDinero+",'CORTE'"))
            {
                //Calcular el TOTAL de efectivo que debe de haber en caja
                res = 1000 - montoDinero;
                //guardar en logs si salio Debiendo, o le SOBRO, o FUe 0!!!
                //se realizó corte, por lo que se cierra la caja
                this.cerrada = true;
            }
            else
                msgError = "Error al realizar CORTE de Caja '" + this.nombre + "'. " + LibMySql.msgError;
            return res;
        }
    }
}
