namespace CapaVista
{
    partial class frmEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.btnInhabilitado = new System.Windows.Forms.RadioButton();
            this.btnHabilitado = new System.Windows.Forms.RadioButton();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNombreaplicacion = new System.Windows.Forms.Label();
            this.labelIdaplicacion = new System.Windows.Forms.Label();
            this.dataSet1 = new CapaVista.DataSet1();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new CapaVista.DataSet1TableAdapters.empleadoTableAdapter();
            this.codigoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigodepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoempleadoDataGridViewTextBoxColumn,
            this.nombreempleadoDataGridViewTextBoxColumn,
            this.codigopuestoDataGridViewTextBoxColumn,
            this.codigodepartamentoDataGridViewTextBoxColumn,
            this.sueldoempleadoDataGridViewTextBoxColumn,
            this.estatusempleadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(144, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 49;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(594, 119);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(594, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(594, 56);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(443, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 45;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 40;
            // 
            // gbxEstado
            // 
            this.gbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.gbxEstado.Controls.Add(this.btnInhabilitado);
            this.gbxEstado.Controls.Add(this.btnHabilitado);
            this.gbxEstado.Location = new System.Drawing.Point(237, 143);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(200, 100);
            this.gbxEstado.TabIndex = 44;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado Aplicacion";
            // 
            // btnInhabilitado
            // 
            this.btnInhabilitado.AutoSize = true;
            this.btnInhabilitado.Location = new System.Drawing.Point(115, 41);
            this.btnInhabilitado.Name = "btnInhabilitado";
            this.btnInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.btnInhabilitado.TabIndex = 4;
            this.btnInhabilitado.TabStop = true;
            this.btnInhabilitado.Text = "Inhabilitado";
            this.btnInhabilitado.UseVisualStyleBackColor = true;
            // 
            // btnHabilitado
            // 
            this.btnHabilitado.AutoSize = true;
            this.btnHabilitado.Location = new System.Drawing.Point(7, 41);
            this.btnHabilitado.Name = "btnHabilitado";
            this.btnHabilitado.Size = new System.Drawing.Size(72, 17);
            this.btnHabilitado.TabIndex = 3;
            this.btnHabilitado.TabStop = true;
            this.btnHabilitado.Text = "Habilitado";
            this.btnHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(594, 27);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 41;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 39;
            // 
            // labelNombreaplicacion
            // 
            this.labelNombreaplicacion.AutoSize = true;
            this.labelNombreaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreaplicacion.Location = new System.Drawing.Point(132, 90);
            this.labelNombreaplicacion.Name = "labelNombreaplicacion";
            this.labelNombreaplicacion.Size = new System.Drawing.Size(99, 13);
            this.labelNombreaplicacion.TabIndex = 43;
            this.labelNombreaplicacion.Text = "Nombre Aplicación:";
            // 
            // labelIdaplicacion
            // 
            this.labelIdaplicacion.AutoSize = true;
            this.labelIdaplicacion.BackColor = System.Drawing.Color.Transparent;
            this.labelIdaplicacion.Location = new System.Drawing.Point(132, 52);
            this.labelIdaplicacion.Name = "labelIdaplicacion";
            this.labelIdaplicacion.Size = new System.Drawing.Size(73, 13);
            this.labelIdaplicacion.TabIndex = 42;
            this.labelIdaplicacion.Text = "ID Aplicación:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.dataSet1;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // codigoempleadoDataGridViewTextBoxColumn
            // 
            this.codigoempleadoDataGridViewTextBoxColumn.DataPropertyName = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.HeaderText = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.Name = "codigoempleadoDataGridViewTextBoxColumn";
            // 
            // nombreempleadoDataGridViewTextBoxColumn
            // 
            this.nombreempleadoDataGridViewTextBoxColumn.DataPropertyName = "nombre_empleado";
            this.nombreempleadoDataGridViewTextBoxColumn.HeaderText = "nombre_empleado";
            this.nombreempleadoDataGridViewTextBoxColumn.Name = "nombreempleadoDataGridViewTextBoxColumn";
            // 
            // codigopuestoDataGridViewTextBoxColumn
            // 
            this.codigopuestoDataGridViewTextBoxColumn.DataPropertyName = "codigo_puesto";
            this.codigopuestoDataGridViewTextBoxColumn.HeaderText = "codigo_puesto";
            this.codigopuestoDataGridViewTextBoxColumn.Name = "codigopuestoDataGridViewTextBoxColumn";
            // 
            // codigodepartamentoDataGridViewTextBoxColumn
            // 
            this.codigodepartamentoDataGridViewTextBoxColumn.DataPropertyName = "codigo_departamento";
            this.codigodepartamentoDataGridViewTextBoxColumn.HeaderText = "codigo_departamento";
            this.codigodepartamentoDataGridViewTextBoxColumn.Name = "codigodepartamentoDataGridViewTextBoxColumn";
            // 
            // sueldoempleadoDataGridViewTextBoxColumn
            // 
            this.sueldoempleadoDataGridViewTextBoxColumn.DataPropertyName = "sueldo_empleado";
            this.sueldoempleadoDataGridViewTextBoxColumn.HeaderText = "sueldo_empleado";
            this.sueldoempleadoDataGridViewTextBoxColumn.Name = "sueldoempleadoDataGridViewTextBoxColumn";
            // 
            // estatusempleadoDataGridViewTextBoxColumn
            // 
            this.estatusempleadoDataGridViewTextBoxColumn.DataPropertyName = "estatus_empleado";
            this.estatusempleadoDataGridViewTextBoxColumn.HeaderText = "estatus_empleado";
            this.estatusempleadoDataGridViewTextBoxColumn.Name = "estatusempleadoDataGridViewTextBoxColumn";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNombreaplicacion);
            this.Controls.Add(this.labelIdaplicacion);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton btnInhabilitado;
        private System.Windows.Forms.RadioButton btnHabilitado;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNombreaplicacion;
        private System.Windows.Forms.Label labelIdaplicacion;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DataSet1TableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigodepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusempleadoDataGridViewTextBoxColumn;
    }
}