namespace pdv_uth_v1
{
    partial class FrmCatalogoProductos
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
            this.iconBtnSalir = new FontAwesome.Sharp.IconButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.panelImgProducto = new System.Windows.Forms.Panel();
            this.lblImagenAGuardar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblImagenOriginal = new System.Windows.Forms.Label();
            this.icoBtnCargarImagen = new FontAwesome.Sharp.IconButton();
            this.picBoxProducto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFrm = new System.Windows.Forms.Panel();
            this.picBoxCodBarras = new System.Windows.Forms.PictureBox();
            this.checkBoxEsPereceredo = new System.Windows.Forms.CheckBox();
            this.comboUnidadDeMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.iconBtnConsultar = new FontAwesome.Sharp.IconButton();
            this.iconBtnEliminar = new FontAwesome.Sharp.IconButton();
            this.iconBtnEditar = new FontAwesome.Sharp.IconButton();
            this.iconBtnNuevo = new FontAwesome.Sharp.IconButton();
            this.iconBtnGuardar = new FontAwesome.Sharp.IconButton();
            this.openFileDialogCargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.panelBanner.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            this.panelImgProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProducto)).BeginInit();
            this.panelFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCodBarras)).BeginInit();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBanner.Controls.Add(this.iconBtnSalir);
            this.panelBanner.Controls.Add(this.labelTitulo);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Margin = new System.Windows.Forms.Padding(2);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(852, 81);
            this.panelBanner.TabIndex = 0;
            // 
            // iconBtnSalir
            // 
            this.iconBtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconBtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnSalir.IconColor = System.Drawing.Color.Brown;
            this.iconBtnSalir.IconSize = 99;
            this.iconBtnSalir.Location = new System.Drawing.Point(772, 0);
            this.iconBtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnSalir.Name = "iconBtnSalir";
            this.iconBtnSalir.Rotation = 0D;
            this.iconBtnSalir.Size = new System.Drawing.Size(80, 81);
            this.iconBtnSalir.TabIndex = 1;
            this.iconBtnSalir.UseVisualStyleBackColor = false;
            this.iconBtnSalir.Click += new System.EventHandler(this.iconBtnSalir_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitulo.Location = new System.Drawing.Point(329, 21);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(198, 49);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Productos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDataGrid.Controls.Add(this.dgProductos);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 505);
            this.panelDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(852, 104);
            this.panelDataGrid.TabIndex = 1;
            // 
            // dgProductos
            // 
            this.dgProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProductos.Location = new System.Drawing.Point(0, -18);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(852, 122);
            this.dgProductos.TabIndex = 0;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelFormulario.Controls.Add(this.groupBoxProductos);
            this.panelFormulario.Controls.Add(this.panelAcciones);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(0, 81);
            this.panelFormulario.Margin = new System.Windows.Forms.Padding(2);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(852, 424);
            this.panelFormulario.TabIndex = 2;
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.AutoSize = true;
            this.groupBoxProductos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxProductos.Controls.Add(this.panelImgProducto);
            this.groupBoxProductos.Controls.Add(this.panelFrm);
            this.groupBoxProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxProductos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductos.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProductos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProductos.Size = new System.Drawing.Size(852, 343);
            this.groupBoxProductos.TabIndex = 1;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Información de Productos";
            // 
            // panelImgProducto
            // 
            this.panelImgProducto.Controls.Add(this.lblImagenAGuardar);
            this.panelImgProducto.Controls.Add(this.label6);
            this.panelImgProducto.Controls.Add(this.lblImagenOriginal);
            this.panelImgProducto.Controls.Add(this.icoBtnCargarImagen);
            this.panelImgProducto.Controls.Add(this.picBoxProducto);
            this.panelImgProducto.Controls.Add(this.label3);
            this.panelImgProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelImgProducto.Location = new System.Drawing.Point(397, 21);
            this.panelImgProducto.Margin = new System.Windows.Forms.Padding(2);
            this.panelImgProducto.Name = "panelImgProducto";
            this.panelImgProducto.Size = new System.Drawing.Size(453, 320);
            this.panelImgProducto.TabIndex = 18;
            // 
            // lblImagenAGuardar
            // 
            this.lblImagenAGuardar.AutoSize = true;
            this.lblImagenAGuardar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenAGuardar.Location = new System.Drawing.Point(6, 171);
            this.lblImagenAGuardar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenAGuardar.Name = "lblImagenAGuardar";
            this.lblImagenAGuardar.Size = new System.Drawing.Size(112, 18);
            this.lblImagenAGuardar.TabIndex = 23;
            this.lblImagenAGuardar.Text = "Nombre Original";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre a Almacenar";
            // 
            // lblImagenOriginal
            // 
            this.lblImagenOriginal.AutoSize = true;
            this.lblImagenOriginal.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenOriginal.Location = new System.Drawing.Point(6, 63);
            this.lblImagenOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenOriginal.Name = "lblImagenOriginal";
            this.lblImagenOriginal.Size = new System.Drawing.Size(112, 18);
            this.lblImagenOriginal.TabIndex = 21;
            this.lblImagenOriginal.Text = "Nombre Original";
            // 
            // icoBtnCargarImagen
            // 
            this.icoBtnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnCargarImagen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnCargarImagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.icoBtnCargarImagen.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.icoBtnCargarImagen.IconSize = 66;
            this.icoBtnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icoBtnCargarImagen.Location = new System.Drawing.Point(10, 278);
            this.icoBtnCargarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.icoBtnCargarImagen.Name = "icoBtnCargarImagen";
            this.icoBtnCargarImagen.Rotation = 0D;
            this.icoBtnCargarImagen.Size = new System.Drawing.Size(201, 52);
            this.icoBtnCargarImagen.TabIndex = 20;
            this.icoBtnCargarImagen.Text = "Cargar Imagen";
            this.icoBtnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnCargarImagen.UseVisualStyleBackColor = true;
            this.icoBtnCargarImagen.Click += new System.EventHandler(this.icoBtnCargarImagen_Click);
            // 
            // picBoxProducto
            // 
            this.picBoxProducto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBoxProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxProducto.Location = new System.Drawing.Point(240, 41);
            this.picBoxProducto.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxProducto.Name = "picBoxProducto";
            this.picBoxProducto.Size = new System.Drawing.Size(207, 291);
            this.picBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProducto.TabIndex = 18;
            this.picBoxProducto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre Original Imagen";
            // 
            // panelFrm
            // 
            this.panelFrm.Controls.Add(this.picBoxCodBarras);
            this.panelFrm.Controls.Add(this.checkBoxEsPereceredo);
            this.panelFrm.Controls.Add(this.comboUnidadDeMedida);
            this.panelFrm.Controls.Add(this.label4);
            this.panelFrm.Controls.Add(this.txtPrecio);
            this.panelFrm.Controls.Add(this.label2);
            this.panelFrm.Controls.Add(this.txtCodBarras);
            this.panelFrm.Controls.Add(this.lblCodBarras);
            this.panelFrm.Controls.Add(this.txtDescripcion);
            this.panelFrm.Controls.Add(this.label1);
            this.panelFrm.Controls.Add(this.txtNombre);
            this.panelFrm.Controls.Add(this.lblNombre);
            this.panelFrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFrm.Location = new System.Drawing.Point(2, 21);
            this.panelFrm.Margin = new System.Windows.Forms.Padding(2);
            this.panelFrm.Name = "panelFrm";
            this.panelFrm.Size = new System.Drawing.Size(438, 320);
            this.panelFrm.TabIndex = 19;
            // 
            // picBoxCodBarras
            // 
            this.picBoxCodBarras.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBoxCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCodBarras.Location = new System.Drawing.Point(256, 142);
            this.picBoxCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxCodBarras.Name = "picBoxCodBarras";
            this.picBoxCodBarras.Size = new System.Drawing.Size(135, 50);
            this.picBoxCodBarras.TabIndex = 28;
            this.picBoxCodBarras.TabStop = false;
            // 
            // checkBoxEsPereceredo
            // 
            this.checkBoxEsPereceredo.AutoSize = true;
            this.checkBoxEsPereceredo.Location = new System.Drawing.Point(14, 321);
            this.checkBoxEsPereceredo.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEsPereceredo.Name = "checkBoxEsPereceredo";
            this.checkBoxEsPereceredo.Size = new System.Drawing.Size(143, 26);
            this.checkBoxEsPereceredo.TabIndex = 27;
            this.checkBoxEsPereceredo.Text = "¿Es Perecedero?";
            this.checkBoxEsPereceredo.UseVisualStyleBackColor = true;
            // 
            // comboUnidadDeMedida
            // 
            this.comboUnidadDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboUnidadDeMedida.FormattingEnabled = true;
            this.comboUnidadDeMedida.Items.AddRange(new object[] {
            "UNIDAD",
            "LITRO",
            "KILO",
            "CAJA",
            "PAQUETE"});
            this.comboUnidadDeMedida.Location = new System.Drawing.Point(155, 278);
            this.comboUnidadDeMedida.Margin = new System.Windows.Forms.Padding(2);
            this.comboUnidadDeMedida.Name = "comboUnidadDeMedida";
            this.comboUnidadDeMedida.Size = new System.Drawing.Size(150, 30);
            this.comboUnidadDeMedida.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Unidad de Medida";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(104, 227);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 26);
            this.txtPrecio.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Precio";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(104, 142);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(124, 26);
            this.txtCodBarras.TabIndex = 22;
            this.txtCodBarras.TextChanged += new System.EventHandler(this.txtCodBarras_TextChanged);
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(10, 146);
            this.lblCodBarras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(92, 22);
            this.lblCodBarras.TabIndex = 21;
            this.lblCodBarras.Text = "Cod. Barras";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 64);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(321, 63);
            this.txtDescripcion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 22);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 22);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAcciones.Controls.Add(this.btnlimpiar);
            this.panelAcciones.Controls.Add(this.iconBtnConsultar);
            this.panelAcciones.Controls.Add(this.iconBtnEliminar);
            this.panelAcciones.Controls.Add(this.iconBtnEditar);
            this.panelAcciones.Controls.Add(this.iconBtnNuevo);
            this.panelAcciones.Controls.Add(this.iconBtnGuardar);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcciones.Location = new System.Drawing.Point(0, 343);
            this.panelAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(852, 81);
            this.panelAcciones.TabIndex = 0;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlimpiar.IconSize = 99;
            this.btnlimpiar.Location = new System.Drawing.Point(702, 0);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Rotation = 0D;
            this.btnlimpiar.Size = new System.Drawing.Size(88, 81);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // iconBtnConsultar
            // 
            this.iconBtnConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnConsultar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.iconBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnConsultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnConsultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconBtnConsultar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnConsultar.IconSize = 99;
            this.iconBtnConsultar.Location = new System.Drawing.Point(596, 0);
            this.iconBtnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnConsultar.Name = "iconBtnConsultar";
            this.iconBtnConsultar.Rotation = 0D;
            this.iconBtnConsultar.Size = new System.Drawing.Size(88, 81);
            this.iconBtnConsultar.TabIndex = 4;
            this.iconBtnConsultar.UseVisualStyleBackColor = false;
            this.iconBtnConsultar.Click += new System.EventHandler(this.iconBtnConsultar_Click);
            // 
            // iconBtnEliminar
            // 
            this.iconBtnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnEliminar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.iconBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconBtnEliminar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnEliminar.IconSize = 99;
            this.iconBtnEliminar.Location = new System.Drawing.Point(455, 0);
            this.iconBtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnEliminar.Name = "iconBtnEliminar";
            this.iconBtnEliminar.Rotation = 0D;
            this.iconBtnEliminar.Size = new System.Drawing.Size(88, 81);
            this.iconBtnEliminar.TabIndex = 3;
            this.iconBtnEliminar.UseVisualStyleBackColor = false;
            this.iconBtnEliminar.Click += new System.EventHandler(this.iconBtnEliminar_Click);
            // 
            // iconBtnEditar
            // 
            this.iconBtnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnEditar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.iconBtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconBtnEditar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnEditar.IconSize = 99;
            this.iconBtnEditar.Location = new System.Drawing.Point(339, 0);
            this.iconBtnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnEditar.Name = "iconBtnEditar";
            this.iconBtnEditar.Rotation = 0D;
            this.iconBtnEditar.Size = new System.Drawing.Size(88, 81);
            this.iconBtnEditar.TabIndex = 2;
            this.iconBtnEditar.UseVisualStyleBackColor = false;
            this.iconBtnEditar.Click += new System.EventHandler(this.iconBtnEditar_Click);
            // 
            // iconBtnNuevo
            // 
            this.iconBtnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnNuevo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.iconBtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconBtnNuevo.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnNuevo.IconSize = 99;
            this.iconBtnNuevo.Location = new System.Drawing.Point(12, 0);
            this.iconBtnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnNuevo.Name = "iconBtnNuevo";
            this.iconBtnNuevo.Rotation = 0D;
            this.iconBtnNuevo.Size = new System.Drawing.Size(88, 81);
            this.iconBtnNuevo.TabIndex = 1;
            this.iconBtnNuevo.UseVisualStyleBackColor = false;
            this.iconBtnNuevo.Click += new System.EventHandler(this.iconBtnNuevo_Click);
            // 
            // iconBtnGuardar
            // 
            this.iconBtnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.iconBtnGuardar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.iconBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconBtnGuardar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconBtnGuardar.IconSize = 99;
            this.iconBtnGuardar.Location = new System.Drawing.Point(193, 0);
            this.iconBtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnGuardar.Name = "iconBtnGuardar";
            this.iconBtnGuardar.Rotation = 0D;
            this.iconBtnGuardar.Size = new System.Drawing.Size(88, 81);
            this.iconBtnGuardar.TabIndex = 0;
            this.iconBtnGuardar.UseVisualStyleBackColor = false;
            this.iconBtnGuardar.Click += new System.EventHandler(this.iconBtnGuardar_Click);
            // 
            // openFileDialogCargarImagen
            // 
            this.openFileDialogCargarImagen.FileName = "openFileDialog1";
            // 
            // FrmCatalogoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 609);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelBanner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCatalogoProductos";
            this.Text = "FrmCatalogoProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCatalogoProductos_Load);
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.groupBoxProductos.ResumeLayout(false);
            this.panelImgProducto.ResumeLayout(false);
            this.panelImgProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProducto)).EndInit();
            this.panelFrm.ResumeLayout(false);
            this.panelFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCodBarras)).EndInit();
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.OpenFileDialog openFileDialogCargarImagen;
        private FontAwesome.Sharp.IconButton iconBtnSalir;
        private System.Windows.Forms.Panel panelFrm;
        private System.Windows.Forms.CheckBox checkBoxEsPereceredo;
        private System.Windows.Forms.ComboBox comboUnidadDeMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelImgProducto;
        private System.Windows.Forms.PictureBox picBoxProducto;
        private FontAwesome.Sharp.IconButton iconBtnGuardar;
        private System.Windows.Forms.PictureBox picBoxCodBarras;
        private FontAwesome.Sharp.IconButton icoBtnCargarImagen;
        private System.Windows.Forms.Label lblImagenAGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImagenOriginal;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton iconBtnConsultar;
        private FontAwesome.Sharp.IconButton iconBtnEliminar;
        private FontAwesome.Sharp.IconButton iconBtnEditar;
        private FontAwesome.Sharp.IconButton iconBtnNuevo;
    }
}