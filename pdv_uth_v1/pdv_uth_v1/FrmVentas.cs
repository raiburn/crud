using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lib_pdv_uth_v1;

namespace pdv_uth_v1
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            //mostrarRegistrosEnDG();
        }
    }
}
