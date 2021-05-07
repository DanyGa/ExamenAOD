
namespace ExamenAOD
{
    partial class FrmAlmacendeAlimentos
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbMedida = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbExistencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cExistencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPorFecha = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbPorProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.Snow;
            this.btnLeer.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnLeer.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLeer.Location = new System.Drawing.Point(29, 397);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(152, 82);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.Snow;
            this.btnEscribir.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnEscribir.ForeColor = System.Drawing.Color.LightCoral;
            this.btnEscribir.Location = new System.Drawing.Point(200, 397);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(152, 82);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir Archivo";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.Snow;
            this.btnProveedor.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnProveedor.ForeColor = System.Drawing.Color.LightCoral;
            this.btnProveedor.Location = new System.Drawing.Point(1093, 395);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(207, 46);
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.Text = "Datos por Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.Snow;
            this.btnFecha.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnFecha.ForeColor = System.Drawing.Color.LightCoral;
            this.btnFecha.Location = new System.Drawing.Point(1093, 466);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(207, 58);
            this.btnFecha.TabIndex = 3;
            this.btnFecha.Text = "Datos por Fecha de Caducidad";
            this.btnFecha.UseVisualStyleBackColor = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.Snow;
            this.btnPorcentaje.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnPorcentaje.ForeColor = System.Drawing.Color.LightCoral;
            this.btnPorcentaje.Location = new System.Drawing.Point(371, 397);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(152, 82);
            this.btnPorcentaje.TabIndex = 4;
            this.btnPorcentaje.Text = "Porcentaje de los Proveedores";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Snow;
            this.lbNombre.Location = new System.Drawing.Point(25, 72);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(228, 23);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre del Producto:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.Snow;
            this.lbPrecio.Location = new System.Drawing.Point(25, 118);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(214, 23);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio del Producto:";
            // 
            // lbMedida
            // 
            this.lbMedida.AutoSize = true;
            this.lbMedida.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedida.ForeColor = System.Drawing.Color.Snow;
            this.lbMedida.Location = new System.Drawing.Point(25, 216);
            this.lbMedida.Name = "lbMedida";
            this.lbMedida.Size = new System.Drawing.Size(90, 23);
            this.lbMedida.TabIndex = 7;
            this.lbMedida.Text = "Medida:";
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProveedor.ForeColor = System.Drawing.Color.Snow;
            this.lbProveedor.Location = new System.Drawing.Point(25, 317);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(120, 23);
            this.lbProveedor.TabIndex = 8;
            this.lbProveedor.Text = "Proveedor:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.Snow;
            this.lbFecha.Location = new System.Drawing.Point(25, 267);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(219, 23);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Fecha de Caducidad:";
            // 
            // lbExistencia
            // 
            this.lbExistencia.AutoSize = true;
            this.lbExistencia.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExistencia.ForeColor = System.Drawing.Color.Snow;
            this.lbExistencia.Location = new System.Drawing.Point(25, 166);
            this.lbExistencia.Name = "lbExistencia";
            this.lbExistencia.Size = new System.Drawing.Size(254, 23);
            this.lbExistencia.TabIndex = 10;
            this.lbExistencia.Text = "Existencia del Producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Snow;
            this.txtNombre.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtNombre.Location = new System.Drawing.Point(313, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Snow;
            this.txtPrecio.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(313, 118);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(222, 26);
            this.txtPrecio.TabIndex = 12;
            // 
            // txtExistencia
            // 
            this.txtExistencia.BackColor = System.Drawing.Color.Snow;
            this.txtExistencia.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtExistencia.Location = new System.Drawing.Point(313, 166);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(222, 26);
            this.txtExistencia.TabIndex = 13;
            // 
            // lvProductos
            // 
            this.lvProductos.BackColor = System.Drawing.Color.Snow;
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cNombre,
            this.cPrecio,
            this.cExistencia,
            this.cMedida,
            this.cFecha,
            this.cProveedor});
            this.lvProductos.Font = new System.Drawing.Font("Century Schoolbook", 7.8F);
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(588, 72);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(712, 281);
            this.lvProductos.TabIndex = 17;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            // 
            // cId
            // 
            this.cId.Text = "Id";
            this.cId.Width = 46;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre del Producto";
            this.cNombre.Width = 152;
            // 
            // cPrecio
            // 
            this.cPrecio.Text = "Precio del Producto";
            this.cPrecio.Width = 70;
            // 
            // cExistencia
            // 
            this.cExistencia.Text = "Existencia del Producto";
            this.cExistencia.Width = 88;
            // 
            // cMedida
            // 
            this.cMedida.Text = "Medida";
            // 
            // cFecha
            // 
            this.cFecha.Text = "Fecha de Caducidad ";
            this.cFecha.Width = 139;
            // 
            // cProveedor
            // 
            this.cProveedor.Text = "Proveedor";
            this.cProveedor.Width = 84;
            // 
            // txtMedida
            // 
            this.txtMedida.BackColor = System.Drawing.Color.Snow;
            this.txtMedida.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtMedida.Location = new System.Drawing.Point(313, 216);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(222, 26);
            this.txtMedida.TabIndex = 18;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.Snow;
            this.txtFecha.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtFecha.Location = new System.Drawing.Point(313, 267);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(222, 26);
            this.txtFecha.TabIndex = 19;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbId.ForeColor = System.Drawing.Color.Snow;
            this.lbId.Location = new System.Drawing.Point(25, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(39, 23);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Snow;
            this.txtId.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtId.Location = new System.Drawing.Point(81, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 21;
            // 
            // txtPorFecha
            // 
            this.txtPorFecha.BackColor = System.Drawing.Color.Snow;
            this.txtPorFecha.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.txtPorFecha.Location = new System.Drawing.Point(862, 483);
            this.txtPorFecha.Name = "txtPorFecha";
            this.txtPorFecha.Size = new System.Drawing.Size(197, 26);
            this.txtPorFecha.TabIndex = 23;
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.Snow;
            this.cbProveedor.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Items.AddRange(new object[] {
            "Panaderia Mayra",
            "Carnes Chuy",
            "Jumex",
            "Kellogg\'s",
            "CocaCola"});
            this.cbProveedor.Location = new System.Drawing.Point(313, 317);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(222, 26);
            this.cbProveedor.TabIndex = 24;
            // 
            // cbPorProveedor
            // 
            this.cbPorProveedor.BackColor = System.Drawing.Color.Snow;
            this.cbPorProveedor.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.cbPorProveedor.FormattingEnabled = true;
            this.cbPorProveedor.Items.AddRange(new object[] {
            "Panaderia Mayra",
            "Carnes Chuy",
            "Jumex",
            "Kellogg\'s",
            "CocaCola"});
            this.cbPorProveedor.Location = new System.Drawing.Point(862, 408);
            this.cbPorProveedor.Name = "cbPorProveedor";
            this.cbPorProveedor.Size = new System.Drawing.Size(197, 26);
            this.cbPorProveedor.TabIndex = 25;
            // 
            // FrmAlmacendeAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1330, 563);
            this.Controls.Add(this.cbPorProveedor);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.txtPorFecha);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbExistencia);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.lbMedida);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlmacendeAlimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen de Alimentos S.A de C.V";
            this.Load += new System.EventHandler(this.FrmAlmacendeAlimentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbMedida;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbExistencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cPrecio;
        private System.Windows.Forms.ColumnHeader cExistencia;
        private System.Windows.Forms.ColumnHeader cMedida;
        private System.Windows.Forms.ColumnHeader cFecha;
        private System.Windows.Forms.ColumnHeader cProveedor;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPorFecha;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbPorProveedor;
    }
}

