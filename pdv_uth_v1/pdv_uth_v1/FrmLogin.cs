using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lib_pdv_uth_v1.usuarios;

namespace pdv_uth_v1
{
    public partial class FrmLogin : Form
    {
        //instancia de usuario
        public static Usuario us = new Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cerrar la forma
            if (MessageBox.Show("¿esta seguro que deseas cerrar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //login
            if(us.login(txtCorreo.Text, txtContraseña.Text) == TipoUsuario.ADMINISTRADOR)
            {
                //abrimos el menu principal de ADMIN
                FrmMenuPpal frmMenuPpal = new FrmMenuPpal();
                //escondemos el ligin
                this.Hide();
                //mostramos la forma de DIALOG para que est{e sobre todas enfrente
                frmMenuPpal.ShowDialog();
                //mostramos el login de nuevo login
            }
            else if (us.login(txtCorreo.Text, txtContraseña.Text) == TipoUsuario.CAJERO)
            {
                //abrimos el Caja
                FrmMenuPpal frmMenuPpal = new FrmMenuPpal();
                //escondemos el l0gin
                this.Hide();
                //mostramos la forma de DIALOG para que est{e sobre todas enfrente
                frmMenuPpal.ShowDialog();
                //mostramos el login de nuevo login
            }
            else
            {
                //ERROR
                MessageBox.Show("Usuario no existe", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txtContraseña.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtContraseña.MaxLength = 30;
        }
    }
}
