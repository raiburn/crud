namespace pdv_uth_v1
{
    partial class FrmCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBanner = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCaja = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dgListaProductos = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMetodosYTotales = new System.Windows.Forms.Panel();
            this.panelDatosCredito = new System.Windows.Forms.Panel();
            this.lblFechaProxPago = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCreditoDisponible = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblClienteCredito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMetodosDePago = new System.Windows.Forms.Panel();
            this.panelPagar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFiado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.pbEfectivo = new System.Windows.Forms.PictureBox();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panelCantidades = new System.Windows.Forms.Panel();
            this.panelCodBarras = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultaProducto = new System.Windows.Forms.TextBox();
            this.tbAutNum = new System.Windows.Forms.TextBox();
            this.tbVigM = new System.Windows.Forms.TextBox();
            this.tbVigA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBanner.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelCaja.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProductos)).BeginInit();
            this.panelMetodosYTotales.SuspendLayout();
            this.panelDatosCredito.SuspendLayout();
            this.panelMetodosDePago.SuspendLayout();
            this.panelPagar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfectivo)).BeginInit();
            this.panelTotales.SuspendLayout();
            this.panelCantidades.SuspendLayout();
            this.panelCodBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.panelConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelBanner.Controls.Add(this.btnSalir);
            this.panelBanner.Controls.Add(this.label1);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Margin = new System.Windows.Forms.Padding(2);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(790, 63);
            this.panelBanner.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::pdv_uth_v1.Properties.Resources.Login_37128;
            this.btnSalir.Location = new System.Drawing.Point(734, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 63);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(314, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAJA #1";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelFooter.Controls.Add(this.label7);
            this.panelFooter.Controls.Add(this.label5);
            this.panelFooter.Controls.Add(this.label4);
            this.panelFooter.Controls.Add(this.tbVigA);
            this.panelFooter.Controls.Add(this.tbVigM);
            this.panelFooter.Controls.Add(this.tbAutNum);
            this.panelFooter.Controls.Add(this.label2);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 432);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(790, 81);
            this.panelFooter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(316, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "footer";
            // 
            // panelCaja
            // 
            this.panelCaja.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelCaja.Controls.Add(this.panelDataGrid);
            this.panelCaja.Controls.Add(this.panelMetodosYTotales);
            this.panelCaja.Controls.Add(this.panelCantidades);
            this.panelCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaja.Location = new System.Drawing.Point(0, 63);
            this.panelCaja.Margin = new System.Windows.Forms.Padding(2);
            this.panelCaja.Name = "panelCaja";
            this.panelCaja.Size = new System.Drawing.Size(790, 369);
            this.panelCaja.TabIndex = 2;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.Yellow;
            this.panelDataGrid.Controls.Add(this.dgListaProductos);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGrid.Location = new System.Drawing.Point(0, 57);
            this.panelDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(790, 169);
            this.panelDataGrid.TabIndex = 2;
            // 
            // dgListaProductos
            // 
            this.dgListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColCodBarras,
            this.ColNombre,
            this.ColDescripcion,
            this.ColCantidad,
            this.ColPrecio,
            this.ColSubTotal});
            this.dgListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListaProductos.Location = new System.Drawing.Point(0, 0);
            this.dgListaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgListaProductos.Name = "dgListaProductos";
            this.dgListaProductos.RowTemplate.Height = 24;
            this.dgListaProductos.Size = new System.Drawing.Size(790, 169);
            this.dgListaProductos.TabIndex = 0;
            this.dgListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaProductos_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 70;
            // 
            // ColCodBarras
            // 
            this.ColCodBarras.HeaderText = "Cod. Barras";
            this.ColCodBarras.MinimumWidth = 13;
            this.ColCodBarras.Name = "ColCodBarras";
            this.ColCodBarras.ReadOnly = true;
            this.ColCodBarras.Width = 150;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Producto";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 300;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 600;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 78;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 75;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 88;
            // 
            // panelMetodosYTotales
            // 
            this.panelMetodosYTotales.BackColor = System.Drawing.Color.Aquamarine;
            this.panelMetodosYTotales.Controls.Add(this.panelDatosCredito);
            this.panelMetodosYTotales.Controls.Add(this.panelMetodosDePago);
            this.panelMetodosYTotales.Controls.Add(this.panelTotales);
            this.panelMetodosYTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMetodosYTotales.Location = new System.Drawing.Point(0, 226);
            this.panelMetodosYTotales.Margin = new System.Windows.Forms.Padding(2);
            this.panelMetodosYTotales.Name = "panelMetodosYTotales";
            this.panelMetodosYTotales.Size = new System.Drawing.Size(790, 143);
            this.panelMetodosYTotales.TabIndex = 1;
            // 
            // panelDatosCredito
            // 
            this.panelDatosCredito.Controls.Add(this.lblFechaProxPago);
            this.panelDatosCredito.Controls.Add(this.label8);
            this.panelDatosCredito.Controls.Add(this.lblCreditoDisponible);
            this.panelDatosCredito.Controls.Add(this.label6);
            this.panelDatosCredito.Controls.Add(this.lblClienteCredito);
            this.panelDatosCredito.Controls.Add(this.label3);
            this.panelDatosCredito.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDatosCredito.Location = new System.Drawing.Point(434, 0);
            this.panelDatosCredito.Margin = new System.Windows.Forms.Padding(2);
            this.panelDatosCredito.Name = "panelDatosCredito";
            this.panelDatosCredito.Size = new System.Drawing.Size(89, 143);
            this.panelDatosCredito.TabIndex = 2;
            this.panelDatosCredito.Visible = false;
            // 
            // lblFechaProxPago
            // 
            this.lblFechaProxPago.AutoSize = true;
            this.lblFechaProxPago.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaProxPago.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFechaProxPago.Location = new System.Drawing.Point(104, 98);
            this.lblFechaProxPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaProxPago.Name = "lblFechaProxPago";
            this.lblFechaProxPago.Size = new System.Drawing.Size(124, 26);
            this.lblFechaProxPago.TabIndex = 5;
            this.lblFechaProxPago.Text = "10/10/2020";
            this.lblFechaProxPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Prox. Pago";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCreditoDisponible
            // 
            this.lblCreditoDisponible.AutoSize = true;
            this.lblCreditoDisponible.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditoDisponible.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCreditoDisponible.Location = new System.Drawing.Point(104, 57);
            this.lblCreditoDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditoDisponible.Name = "lblCreditoDisponible";
            this.lblCreditoDisponible.Size = new System.Drawing.Size(110, 26);
            this.lblCreditoDisponible.TabIndex = 3;
            this.lblCreditoDisponible.Text = "$1,000.00";
            this.lblCreditoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Disponible:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClienteCredito
            // 
            this.lblClienteCredito.AutoSize = true;
            this.lblClienteCredito.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteCredito.ForeColor = System.Drawing.Color.IndianRed;
            this.lblClienteCredito.Location = new System.Drawing.Point(104, 12);
            this.lblClienteCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteCredito.Name = "lblClienteCredito";
            this.lblClienteCredito.Size = new System.Drawing.Size(211, 26);
            this.lblClienteCredito.TabIndex = 1;
            this.lblClienteCredito.Text = "Luis F. Lñopez Lopez";
            this.lblClienteCredito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente:";
            // 
            // panelMetodosDePago
            // 
            this.panelMetodosDePago.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelMetodosDePago.Controls.Add(this.panelPagar);
            this.panelMetodosDePago.Controls.Add(this.panel3);
            this.panelMetodosDePago.Controls.Add(this.panel2);
            this.panelMetodosDePago.Controls.Add(this.panel1);
            this.panelMetodosDePago.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMetodosDePago.Location = new System.Drawing.Point(0, 0);
            this.panelMetodosDePago.Margin = new System.Windows.Forms.Padding(2);
            this.panelMetodosDePago.Name = "panelMetodosDePago";
            this.panelMetodosDePago.Size = new System.Drawing.Size(434, 143);
            this.panelMetodosDePago.TabIndex = 1;
            // 
            // panelPagar
            // 
            this.panelPagar.Controls.Add(this.button1);
            this.panelPagar.Controls.Add(this.btnPagar);
            this.panelPagar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPagar.Location = new System.Drawing.Point(297, 0);
            this.panelPagar.Margin = new System.Windows.Forms.Padding(2);
            this.panelPagar.Name = "panelPagar";
            this.panelPagar.Size = new System.Drawing.Size(118, 143);
            this.panelPagar.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.BackgroundImage = global::pdv_uth_v1.Properties.Resources.ticket_alt_icon_125124;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::pdv_uth_v1.Properties.Resources._3440910_ecommerce_find_magnifier_search_seo_1075231;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPagar.BackgroundImage = global::pdv_uth_v1.Properties.Resources.ticket_alt_icon_125124;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Image = global::pdv_uth_v1.Properties.Resources.ticket_alt_icon_125124;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(0, 72);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(116, 72);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.txtFiado);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(198, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 143);
            this.panel3.TabIndex = 2;
            // 
            // txtFiado
            // 
            this.txtFiado.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiado.Location = new System.Drawing.Point(7, 83);
            this.txtFiado.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiado.Name = "txtFiado";
            this.txtFiado.Size = new System.Drawing.Size(82, 29);
            this.txtFiado.TabIndex = 1;
            this.txtFiado.Text = "0.00";
            this.txtFiado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::pdv_uth_v1.Properties.Resources.ic_credit_card_128_28282;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::pdv_uth_v1.Properties.Resources._16_client_cat_icon_icons_com_76692;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(27, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 54);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.txtTarjeta);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(99, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 143);
            this.panel2.TabIndex = 1;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(7, 83);
            this.txtTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(82, 29);
            this.txtTarjeta.TabIndex = 1;
            this.txtTarjeta.Text = "0.00";
            this.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::pdv_uth_v1.Properties.Resources.ic_credit_card_128_28282;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::pdv_uth_v1.Properties.Resources.ic_credit_card_128_28282;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.txtEfectivo);
            this.panel1.Controls.Add(this.pbEfectivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 143);
            this.panel1.TabIndex = 0;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(7, 83);
            this.txtEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(82, 29);
            this.txtEfectivo.TabIndex = 1;
            this.txtEfectivo.Text = "0.00";
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbEfectivo
            // 
            this.pbEfectivo.BackgroundImage = global::pdv_uth_v1.Properties.Resources.business_color_money_coins_icon_icons_com_53446;
            this.pbEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEfectivo.Image = global::pdv_uth_v1.Properties.Resources.business_color_money_coins_icon_icons_com_53446;
            this.pbEfectivo.ImageLocation = "";
            this.pbEfectivo.Location = new System.Drawing.Point(23, 24);
            this.pbEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.pbEfectivo.Name = "pbEfectivo";
            this.pbEfectivo.Size = new System.Drawing.Size(50, 43);
            this.pbEfectivo.TabIndex = 0;
            this.pbEfectivo.TabStop = false;
            // 
            // panelTotales
            // 
            this.panelTotales.BackColor = System.Drawing.Color.Honeydew;
            this.panelTotales.Controls.Add(this.txtTotal);
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Controls.Add(this.txtIva);
            this.panelTotales.Controls.Add(this.lblIva);
            this.panelTotales.Controls.Add(this.txtSubTotal);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTotales.Location = new System.Drawing.Point(527, 0);
            this.panelTotales.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(263, 143);
            this.panelTotales.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(110, 99);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(147, 33);
            this.txtTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(16, 99);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 27);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(110, 57);
            this.txtIva.Margin = new System.Windows.Forms.Padding(2);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(147, 33);
            this.txtIva.TabIndex = 12;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(46, 59);
            this.lblIva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(42, 27);
            this.lblIva.TabIndex = 11;
            this.lblIva.Text = "IVA";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(110, 19);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(147, 33);
            this.txtSubTotal.TabIndex = 10;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(6, 21);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(95, 27);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // panelCantidades
            // 
            this.panelCantidades.BackColor = System.Drawing.Color.LightYellow;
            this.panelCantidades.Controls.Add(this.panelCodBarras);
            this.panelCantidades.Controls.Add(this.panelConsultar);
            this.panelCantidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCantidades.Location = new System.Drawing.Point(0, 0);
            this.panelCantidades.Margin = new System.Windows.Forms.Padding(2);
            this.panelCantidades.Name = "panelCantidades";
            this.panelCantidades.Size = new System.Drawing.Size(790, 57);
            this.panelCantidades.TabIndex = 0;
            // 
            // panelCodBarras
            // 
            this.panelCodBarras.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelCodBarras.Controls.Add(this.btnAgregar);
            this.panelCodBarras.Controls.Add(this.numericCantidad);
            this.panelCodBarras.Controls.Add(this.lblCantidad);
            this.panelCodBarras.Controls.Add(this.txtCodBarras);
            this.panelCodBarras.Controls.Add(this.lblCodBarras);
            this.panelCodBarras.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCodBarras.Location = new System.Drawing.Point(0, 0);
            this.panelCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.panelCodBarras.Name = "panelCodBarras";
            this.panelCodBarras.Size = new System.Drawing.Size(633, 57);
            this.panelCodBarras.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::pdv_uth_v1.Properties.Resources.ic_add_shopping_cart_128_28122;
            this.btnAgregar.Location = new System.Drawing.Point(578, 3);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 53);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numericCantidad
            // 
            this.numericCantidad.DecimalPlaces = 3;
            this.numericCantidad.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantidad.Location = new System.Drawing.Point(464, 13);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(82, 33);
            this.numericCantidad.TabIndex = 10;
            this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(359, 17);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 27);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(196, 15);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(147, 33);
            this.txtCodBarras.TabIndex = 8;
            this.txtCodBarras.TextChanged += new System.EventHandler(this.txtCodBarras_TextChanged);
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(12, 15);
            this.lblCodBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(179, 27);
            this.lblCodBarras.TabIndex = 7;
            this.lblCodBarras.Text = "Código de Barras";
            // 
            // panelConsultar
            // 
            this.panelConsultar.BackColor = System.Drawing.Color.Gold;
            this.panelConsultar.Controls.Add(this.btnConsultar);
            this.panelConsultar.Controls.Add(this.txtConsultaProducto);
            this.panelConsultar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConsultar.Location = new System.Drawing.Point(404, 0);
            this.panelConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(386, 57);
            this.panelConsultar.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(277, 14);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 32);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsultaProducto
            // 
            this.txtConsultaProducto.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaProducto.Location = new System.Drawing.Point(15, 14);
            this.txtConsultaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultaProducto.Name = "txtConsultaProducto";
            this.txtConsultaProducto.Size = new System.Drawing.Size(248, 33);
            this.txtConsultaProducto.TabIndex = 6;
            // 
            // tbAutNum
            // 
            this.tbAutNum.Location = new System.Drawing.Point(506, 25);
            this.tbAutNum.Name = "tbAutNum";
            this.tbAutNum.Size = new System.Drawing.Size(161, 20);
            this.tbAutNum.TabIndex = 1;
            // 
            // tbVigM
            // 
            this.tbVigM.Location = new System.Drawing.Point(67, 25);
            this.tbVigM.Name = "tbVigM";
            this.tbVigM.Size = new System.Drawing.Size(161, 20);
            this.tbVigM.TabIndex = 2;
            // 
            // tbVigA
            // 
            this.tbVigA.Location = new System.Drawing.Point(283, 25);
            this.tbVigA.Name = "tbVigA";
            this.tbVigA.Size = new System.Drawing.Size(161, 20);
            this.tbVigA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vigencia Anio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vigencia Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero autorizacion";
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 513);
            this.Controls.Add(this.panelCaja);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelBanner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCaja";
            this.Text = "FrmCaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelCaja.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaProductos)).EndInit();
            this.panelMetodosYTotales.ResumeLayout(false);
            this.panelDatosCredito.ResumeLayout(false);
            this.panelDatosCredito.PerformLayout();
            this.panelMetodosDePago.ResumeLayout(false);
            this.panelPagar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfectivo)).EndInit();
            this.panelTotales.ResumeLayout(false);
            this.panelTotales.PerformLayout();
            this.panelCantidades.ResumeLayout(false);
            this.panelCodBarras.ResumeLayout(false);
            this.panelCodBarras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.panelConsultar.ResumeLayout(false);
            this.panelConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCaja;
        private System.Windows.Forms.Panel panelMetodosYTotales;
        private System.Windows.Forms.Panel panelMetodosDePago;
        private System.Windows.Forms.Panel panelTotales;
        private System.Windows.Forms.Panel panelCantidades;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Panel panelConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultaProducto;
        private System.Windows.Forms.Panel panelCodBarras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.DataGridView dgListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.PictureBox pbEfectivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFiado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelPagar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Panel panelDatosCredito;
        private System.Windows.Forms.Label lblFechaProxPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCreditoDisponible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClienteCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVigA;
        private System.Windows.Forms.TextBox tbVigM;
        private System.Windows.Forms.TextBox tbAutNum;
    }
}