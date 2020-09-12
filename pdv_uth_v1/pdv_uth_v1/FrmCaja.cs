using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lib_pdv_uth_v1.cajas;
using Lib_pdv_uth_v1.productos;

namespace pdv_uth_v1
{
    public partial class FrmCaja : Form
    {
        //instancia de objeto CAJAS
        Caja caja = new Caja();
        public FrmCaja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            //verificamos si ;

  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod = prod.consultarPorCodigoDeBarras(txtCodBarras.Text);

            //agregamos un renglon con la info del producto CAPTURADo al DG
            if (prod.CodigoDeBarras != null)
            {
                //pasar producto obj a obj[]
                //agregar el producto al DataGrid
                dgListaProductos.Rows.Add(new object[] { prod.Id, prod.CodigoDeBarras, prod.Nombre, prod.Descripcion, prod.Precio, numericCantidad.Value.ToString(), (prod.Precio * double.Parse(numericCantidad.Value.ToString())) });
                //agregar el produ a caja.ListaProductos
                caja.ListaProductos.Add(new ProductosAVender(prod.Id, double.Parse(numericCantidad.Value.ToString()), prod.CodigoDeBarras));
                //limpiamos los text
                txtCodBarras.Clear();
                numericCantidad.Value = 1;
            }
            else
            {
                //producto NO EXISTE
                MessageBox.Show("El producto con el Código de Barras <" + txtCodBarras.Text + ">, no Existe. ", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cursor a CodBarras y select all
                txtCodBarras.Focus();
                txtCodBarras.SelectAll();
            }
            
            

            double temp = 0;
            for (int i = 0; i < dgListaProductos.RowCount - 1; i++)
            {
                temp = temp +
                    double.Parse(dgListaProductos.Rows[i].Cells[dgListaProductos.ColumnCount - 1].Value.ToString());
            }
            txtTotal.Text = temp.ToString();
            txtSubTotal.Text = (temp * 0.84).ToString();
            txtIva.Text = (temp * 0.16).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelDatosCredito.Visible = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //salir ????
            if (MessageBox.Show("¿Desea cerrar la caja?",
                                "Salir", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmMenuPpal frmMenuPpal = new FrmMenuPpal();
                this.Hide();
                frmMenuPpal.ShowDialog();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double pago = double.Parse(txtEfectivo.Text) + double.Parse(txtTarjeta.Text) + double.Parse(txtFiado.Text);
            double feria = pago - double.Parse(txtTotal.Text);
            //venta con metodo de pago efectivo
            if (txtTarjeta.Text == "0.00")
            {
                if (caja.vender(1, double.Parse(txtEfectivo.Text), double.Parse(txtTotal.Text)))
                {
                    if (feria >= 0)
                        MessageBox.Show("la venta ha sido registrada, el cambio es " + feria);
                }
                else MessageBox.Show("Error en el registro de la venta. " + Caja.msgError);
            }
            else
            {
                if (caja.vender(1, double.Parse(txtTarjeta.Text), double.Parse(txtTotal.Text),tbVigM.Text, tbVigM.Text, tbAutNum.Text ))
                {
                    if (feria >= 0)
                        MessageBox.Show("la venta ha sido registrada ");
                }
                else MessageBox.Show("Error en el registro de la venta. " + Caja.msgError);
            }
            
              
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
