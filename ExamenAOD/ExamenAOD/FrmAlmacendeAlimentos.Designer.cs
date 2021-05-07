
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cExistencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.Snow;
            this.btnProveedor.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnProveedor.ForeColor = System.Drawing.Color.LightCoral;
            this.btnProveedor.Location = new System.Drawing.Point(369, 397);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(152, 82);
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.Text = "Datos por Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = false;
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.Snow;
            this.btnFecha.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnFecha.ForeColor = System.Drawing.Color.LightCoral;
            this.btnFecha.Location = new System.Drawing.Point(541, 397);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(152, 82);
            this.btnFecha.TabIndex = 3;
            this.btnFecha.Text = "Datos por Fecha de Caducidad";
            this.btnFecha.UseVisualStyleBackColor = false;
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.Snow;
            this.btnPorcentaje.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btnPorcentaje.ForeColor = System.Drawing.Color.LightCoral;
            this.btnPorcentaje.Location = new System.Drawing.Point(713, 397);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(152, 82);
            this.btnPorcentaje.TabIndex = 4;
            this.btnPorcentaje.Text = "Porcentaje de los Proveedores";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.textBox1.Location = new System.Drawing.Point(313, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 26);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Snow;
            this.textBox2.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.textBox2.Location = new System.Drawing.Point(313, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Snow;
            this.textBox3.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.textBox3.Location = new System.Drawing.Point(313, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 26);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Snow;
            this.textBox4.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.textBox4.Location = new System.Drawing.Point(313, 317);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 26);
            this.textBox4.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Snow;
            this.comboBox1.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pieza",
            "Kg"});
            this.comboBox1.Location = new System.Drawing.Point(313, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 26);
            this.comboBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Schoolbook", 9F);
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Snow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cNombre,
            this.cPrecio,
            this.cExistencia,
            this.cMedida,
            this.cFecha,
            this.cProveedor});
            this.listView1.Font = new System.Drawing.Font("Century Schoolbook", 7.8F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(588, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 281);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // FrmAlmacendeAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1330, 514);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cPrecio;
        private System.Windows.Forms.ColumnHeader cExistencia;
        private System.Windows.Forms.ColumnHeader cMedida;
        private System.Windows.Forms.ColumnHeader cFecha;
        private System.Windows.Forms.ColumnHeader cProveedor;
    }
}

