using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pdv_uth_v1
{
    public partial class FrmMenuPpal : Form
    {
        public FrmMenuPpal()
        {
            InitializeComponent();
        }

        private void FrmMenuPpal_Load(object sender, EventArgs e)
        {
            lblTitulo.PointToScreen( new Point((panelBanner.Width / 2) - 100, panelBanner.Height/2));
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
        private void btnCreditos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCreditos frm = new FrmCreditos();
            frm.Show();
        }

        

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCatalogoCliente frm = new FrmCatalogoCliente();
            frm.Show();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCatalogoProductos frm = new FrmCatalogoProductos();
            frm.Show();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
        }

        private void btnLogs_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCaja frm = new FrmCaja();
            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVentas frm = new FrmVentas();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //salir ????
            if (MessageBox.Show("¿Regresar?",
                                "Salir?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                this.Hide();
                frmLogin.ShowDialog();
            }
        }

    }
}
