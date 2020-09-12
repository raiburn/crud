namespace Lib_pdv_uth_v1.cajas
{
    public class ProductosAVender
    {
        public int idProducto;
        public double cantidad;
        public string codBarras;

        public ProductosAVender(int idProducto, double cantidad, string codBarras)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.codBarras = codBarras;
        }
    }
}