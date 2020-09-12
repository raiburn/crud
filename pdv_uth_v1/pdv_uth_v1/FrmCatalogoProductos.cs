using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lib_pdv_uth_v1.productos;
using Lib_pdv_uth_v1;

namespace pdv_uth_v1
{
    public partial class FrmCatalogoProductos : Form
    {
        //var de producto
        Producto prod = new Producto();
        Producto cli = new Producto();
        int idProducto = 0;

        public FrmCatalogoProductos()
        {
            InitializeComponent();
        }

      

        private void iconBtnSalir_Click(object sender, EventArgs e)
        {
            {
                //salir ????
                if (MessageBox.Show("¿Regresar?",
                                    "Salir?",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmMenuPpal frmMenuPpal = new FrmMenuPpal();
                    this.Hide();
                    frmMenuPpal.ShowDialog();
                }
            }
        }

        private void FrmCatalogoProductos_Load(object sender, EventArgs e)
        {
            //set del combo
            comboUnidadDeMedida.SelectedItem = comboUnidadDeMedida.Items[0];
            mostrarRegistrosEnDG();
        }

        private void mostrarRegistrosEnDG()
        {
            dgProductos.DataSource = null;
            //borrar todos los ren del DG
            dgProductos.Rows.Clear();
            //se crea lista de criterios de busqueda
            List<CriteriosBusqueda> criterios = new List<CriteriosBusqueda>();
            //se crea objeto de crioterio para busqueda
            CriteriosBusqueda criterio = new CriteriosBusqueda();
            //se asignan los datos del criterio del WHERE
            criterio.campo = " 1 ";
            criterio.operadorIntermedio = OperadorDeConsulta.IGUAL;
            criterio.valor = "1";
            criterio.operadorFinal = OperadorDeConsulta.NINGUNO;
            //se incluye el criterio en la lista de criterios
            criterios.Add(criterio);
            //se ejecuta la consulta y se asigna el resultado al DtaGrid
            dgProductos.DataSource = cli.consultar(criterios);
            //se refresca el dataGrid para mostrar los datos
            dgProductos.Refresh();

        }
        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {
            
        }

        private void iconBtnGuardar_Click(object sender, EventArgs e)
        {
            //cargar todos los campos en producto
            prod = new Producto();
            prod.Nombre = txtNombre.Text;
            prod.Descripcion = txtDescripcion.Text;
            prod.Precio = double.Parse(txtPrecio.Text);
            prod.CodigoDeBarras = txtCodBarras.Text;
            prod.Imagen = lblImagenAGuardar.Text;
            prod.UnidadDeMedida = (UnidadDeMedida)Enum.Parse(typeof(UnidadDeMedida), comboUnidadDeMedida.SelectedItem.ToString());
            prod.EsPerecedero = checkBoxEsPereceredo.Checked;
            //hacer el insert con m{etodo alta()
            if (prod.alta())
            {
                // obtener el dir de la app
                string bin = System.IO.Path.GetDirectoryName(Application.StartupPath);
                //ir a un dir arriba
                string dir = System.IO.Path.GetDirectoryName(bin);
                //agregar el path para guardar la imagen
                dir += "\\Imagenes\\Productos\\";
                //guardar la imagen
                //picBoxProducto.Image.Save(dir + lblImagenAGuardar.Text);
                //notificar
                MessageBox.Show("EL producto <" + txtNombre.Text + "> se ha almacenado.", "Nuevo Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error, no se almacenó producto. " + Producto.msgError);
           
        }

        private void icoBtnCargarImagen_Click(object sender, EventArgs e)
        {
            //Filtros para abrir imagen
            openFileDialogCargarImagen.Filter = "Image Files|*.png;";
            openFileDialogCargarImagen.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            openFileDialogCargarImagen.Title = "Abrir Imagen para Producto";
            openFileDialogCargarImagen.DefaultExt = ".png";
            //si se abre imagen, se toma archivo
            if (openFileDialogCargarImagen.ShowDialog() == DialogResult.OK)
            {
                //se toma nombre de archivo
                string fileName = openFileDialogCargarImagen.FileName;
                //se carga archivo por su nombre al picBox
                picBoxProducto.Image = Image.FromFile(openFileDialogCargarImagen.FileName);
                //se toma el nmbre original
                lblImagenOriginal.Text = openFileDialogCargarImagen.SafeFileName;
                //calculamos la extension de la img, con los {ultimos 3 caracteres del nombre original
                string extension=lblImagenOriginal.Text.Substring(lblImagenOriginal.Text.Length - 3);
                //si es '.jpeg' va a decir 'peg', asi que acmpletamos
                extension = extension.ToLower() == "peg" ? "jpeg" : extension.ToLower();
                //se crea nombre nuevo UNICO para el Prodcuto, con el DateTime
                lblImagenAGuardar.Text = string.Format(@"prod_{0}."+extension, DateTime.Now.Ticks);
            }
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Zen.Barcode.CodeEan13BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
                //le quitamos el último caracter al CODBARRAS EAN13( quedará 12)
                string codBarras = txtCodBarras.Text.Substring(0, txtCodBarras.Text.Length - 1);
                //con la cadena editada, "pintamos" el código de barras en el picBox
                picBoxCodBarras.Image = barcode.Draw(codBarras, 50);
            }
        }

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconBtnNuevo_Click(object sender, EventArgs e)
        {
            habilitarFrom();
        }
        public void habilitarFrom()
        {
            //habilitar forms
            txtCodBarras.Enabled = txtNombre.Enabled = txtPrecio.Enabled = txtDescripcion.Enabled = comboUnidadDeMedida.Enabled = icoBtnCargarImagen.Enabled = true;
            //change colors txt
            txtCodBarras.BackColor = txtNombre.BackColor = txtPrecio.BackColor = txtDescripcion.BackColor = comboUnidadDeMedida.BackColor = Color.White;
        }
        public void limpiarForm()
        {
            //desabilitamos el form
            txtNombre.Enabled = txtPrecio.Enabled = txtDescripcion.Enabled = comboUnidadDeMedida.Enabled = icoBtnCargarImagen.Enabled = false;
            //limpiamos el form "";
            txtCodBarras.Text = txtNombre.Text = txtPrecio.Text = txtDescripcion.Text = "";
            // cambiar el color de fondo
            txtCodBarras.BackColor = txtNombre.BackColor = txtPrecio.BackColor = txtDescripcion.BackColor = comboUnidadDeMedida.BackColor = Color.DarkGray;
        }

        private void iconBtnEditar_Click(object sender, EventArgs e)
        {
            habilitarFrom();
            Producto paraModif = new Producto();
            List<DatosParaActualizar> datos = new List<DatosParaActualizar>();

            datos.Add(new DatosParaActualizar("nombre", txtNombre.Text));
            datos.Add(new DatosParaActualizar("descripcion", txtDescripcion.Text));
            datos.Add(new DatosParaActualizar("precio", txtPrecio.Text));
            datos.Add(new DatosParaActualizar("codigo_barras", txtCodBarras.Text));
            //datos.Add(new DatosParaActualizar("imagen_producto", lblImagenAGuardar.Text));
            datos.Add(new DatosParaActualizar("unidad_medida", comboUnidadDeMedida.Text));   
            datos.Add(new DatosParaActualizar("es_perecedero", checkBoxEsPereceredo.Checked ? "1" : "0"));
            habilitarFrom();
            dgProductos.Refresh();

            if (paraModif.modificar(datos, idProducto))
            {
                MessageBox.Show("producto modificado");
                mostrarRegistrosEnDG();
            }
            else MessageBox.Show("Error producto no modificado");
        }
    

        private void iconBtnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void iconBtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar este Producto?", "Borrar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (prod.eliminar(idProducto))
                {
                    MessageBox.Show("Producto eliminado ");
                }
                else MessageBox.Show("Error, El Producto no fue eliminado ");
            }
            dgProductos.Refresh();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //desabilitamos el form
            txtNombre.Enabled = txtPrecio.Enabled = txtDescripcion.Enabled = comboUnidadDeMedida.Enabled = icoBtnCargarImagen.Enabled = false;
            //limpiamos el form "";
            txtCodBarras.Text = txtNombre.Text = txtPrecio.Text = txtDescripcion.Text = "";
            // cambiar el color de fondo
            txtCodBarras.BackColor = txtNombre.BackColor = txtPrecio.BackColor = txtDescripcion.BackColor = comboUnidadDeMedida.BackColor = Color.DarkGray;
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = int.Parse(dgProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombre.Text = dgProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = dgProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCodBarras.Text = dgProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrecio.Text = dgProductos.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
