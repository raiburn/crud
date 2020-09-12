using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lib_pdv_uth_v1;
using Lib_pdv_uth_v1.usuarios;

namespace pdv_uth_v1
{
    public partial class FrmUsuarios : Form
    {

        Usuario cli = new Usuario();
        int idUsuario = 0;


        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load_1(object sender, EventArgs e)
        {
            //vamos actualizar el dgUsuarios, con los registro de BD
            mostrarRegistrosEnDG();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario paraAlta = new Usuario();
            paraAlta.Nombre = txtNombre.Text;
            paraAlta.ApellidoPaterno = txtApPat.Text;
            paraAlta.ApellidoMaterno = txtApMat.Text;
            paraAlta.Celular = txtCelular.Text;
            paraAlta.Correo = txtCorreo.Text;
            paraAlta.FechaNacimiento = dtpFechaNacimiento.Value;
            paraAlta.Domicilio.calle = txtCalle.Text;
            paraAlta.Domicilio.numero = txtNumCalle.Text;
            paraAlta.Domicilio.colonia = txtColonia.Text;
            paraAlta.Domicilio.codigoPostal = txtCP.Text;
            paraAlta.Domicilio.localidad = txtLocalidad.Text;
            paraAlta.Domicilio.municipio = txtMunicipio.Text;
            paraAlta.Domicilio.fotoComprobante = txtComprobanteDomicilio.Text;
            paraAlta.ComprobanteINE = txtComproINE.Text;
            paraAlta.Curp = txtcurp.Text;
            paraAlta.CurpCompro = txtcompcurp.Text;
            paraAlta.ActaNacimientoComprobante = txtacta.Text;
            paraAlta.CertificadoEscolar = txtcompestud.Text;
            paraAlta.NumeroSeguroSocial = txtsegsocial.Text;
            paraAlta.TipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), cbtipo.SelectedItem.ToString());
            paraAlta.Contraseña = txtpass.Text;

            if (paraAlta.alta())
            {
                MessageBox.Show("registro correcto");
            }
            else
            {
                MessageBox.Show("Errror al guardar Usuario. "+Usuario.msgError);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente quieres eliminar este usuario?", "Borrar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (cli.eliminar(idUsuario))
                {
                    MessageBox.Show("Usuario eliminado ");
                }
                else MessageBox.Show("Error Usuario NO eliminado ");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtCalle.Text = "";
            txtNumCalle.Text = "";
            txtColonia.Text = "";
            txtCP.Text = "";
            txtLocalidad.Text = "";
            txtMunicipio.Text = "";
            txtComprobanteDomicilio.Text = "";
            txtComproINE.Text = "";
            txtcurp.Text = "";
            txtcompcurp.Text = "";
            txtpass.Text = "";
            txtsegsocial.Text = "";
            txtcompestud.Text = "";
            txtsegsocial.Text = "";
        }

        private void mostrarRegistrosEnDG()
        {
            dgUsuarios.DataSource = null;
            //borrar todos los ren del DG
            dgUsuarios.Rows.Clear();
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
            dgUsuarios.DataSource = cli.consultar(criterios);
            //se refresca el dataGrid para mostrar los datos
            dgUsuarios.Refresh();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario paraModif = new Usuario();


            List<DatosParaActualizar> datos = new List<DatosParaActualizar>();

            datos.Add(new DatosParaActualizar("nombre", txtNombre.Text));

            datos.Add(new DatosParaActualizar("apellido_paterno", txtApPat.Text));

            datos.Add(new DatosParaActualizar("apellido_materno", txtApMat.Text));

            datos.Add(new DatosParaActualizar("celular", txtCelular.Text));

            datos.Add(new DatosParaActualizar("correo", txtCorreo.Text));

            datos.Add(new DatosParaActualizar("fecha_de_nacimiento", dtpFechaNacimiento.Value.Year + "-" + dtpFechaNacimiento.Value.Month + "-" + dtpFechaNacimiento.Value.Day));

            datos.Add(new DatosParaActualizar("calle", txtCalle.Text));

            datos.Add(new DatosParaActualizar("numero_casa", txtNumCalle.Text));

            datos.Add(new DatosParaActualizar("colonia", txtColonia.Text));

            datos.Add(new DatosParaActualizar("codigo_postal", txtCP.Text));

            datos.Add(new DatosParaActualizar("localidad", txtLocalidad.Text));

            datos.Add(new DatosParaActualizar("municipio", txtMunicipio.Text));

            datos.Add(new DatosParaActualizar("img_comprobante_domicilio", txtComprobanteDomicilio.Text));

            datos.Add(new DatosParaActualizar("ine_comprobante", txtComproINE.Text));

            datos.Add(new DatosParaActualizar("curp", txtcurp.Text));

            datos.Add(new DatosParaActualizar("curp_comprobante", txtcompcurp.Text));

            datos.Add(new DatosParaActualizar("acta_nacimiento", txtacta.Text ));

            datos.Add(new DatosParaActualizar("certificado_estudios", txtcompestud.Text));
            
            datos.Add(new DatosParaActualizar("numero_seguro_social", txtsegsocial.Text));
            
            datos.Add(new DatosParaActualizar("tipo_usuario",  cbtipo.SelectedItem.ToString()));
            
            datos.Add(new DatosParaActualizar("pwd", txtpass.Text));

            if (paraModif.modificar(datos, idUsuario))
            {
                MessageBox.Show("cliente modificado");
                mostrarRegistrosEnDG();
            }
            else MessageBox.Show("Error cliente no modificado");
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = int.Parse(dgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombre.Text = dgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApPat.Text = dgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApMat.Text = dgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpFechaNacimiento.Value = DateTime.Parse(dgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtCelular.Text = dgUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txtTelefono.Text = dgClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCorreo.Text = dgUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCalle.Text = dgUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtNumCalle.Text = dgUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtCP.Text = dgUsuarios.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtColonia.Text = dgUsuarios.Rows[e.RowIndex].Cells[11].Value.ToString();
            //txtFraccionamiento.Text = dgClientes.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtLocalidad.Text = dgUsuarios.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtMunicipio.Text = dgUsuarios.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtComprobanteDomicilio.Text = dgUsuarios.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtComproINE.Text = dgUsuarios.Rows[e.RowIndex].Cells[16].Value.ToString();
            txtcurp.Text = dgUsuarios.Rows[e.RowIndex].Cells[17].Value.ToString();
            txtcompcurp.Text = dgUsuarios.Rows[e.RowIndex].Cells[18].Value.ToString();
            txtacta.Text = dgUsuarios.Rows[e.RowIndex].Cells[19].Value.ToString();
            txtcompestud.Text = dgUsuarios.Rows[e.RowIndex].Cells[20].Value.ToString();
            txtsegsocial.Text = dgUsuarios.Rows[e.RowIndex].Cells[21].Value.ToString();
            
        }

        private void btnback_Click(object sender, EventArgs e)
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
    }
}
