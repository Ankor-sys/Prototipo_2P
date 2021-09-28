namespace CapaVista
{
    partial class frmNomina
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
            this.btnCompletarEncabezado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoBodega = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet3 = new CapaVista.DataSet3();
            this.nominadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominadTableAdapter = new CapaVista.DataSet3TableAdapters.nominadTableAdapter();
            this.codigonominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoconceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valornominaDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSet4 = new CapaVista.DataSet4();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new CapaVista.DataSet4TableAdapters.empleadoTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataSet5 = new CapaVista.DataSet5();
            this.conceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoTableAdapter = new CapaVista.DataSet5TableAdapters.conceptoTableAdapter();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompletarEncabezado
            // 
            this.btnCompletarEncabezado.Location = new System.Drawing.Point(52, 174);
            this.btnCompletarEncabezado.Name = "btnCompletarEncabezado";
            this.btnCompletarEncabezado.Size = new System.Drawing.Size(157, 23);
            this.btnCompletarEncabezado.TabIndex = 77;
            this.btnCompletarEncabezado.Text = "Completar Encabezado";
            this.btnCompletarEncabezado.UseVisualStyleBackColor = true;
            this.btnCompletarEncabezado.Click += new System.EventHandler(this.btnCompletarEncabezado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(124, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 75;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgProductos
            // 
            this.dgProductos.AutoGenerateColumns = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigonominaDataGridViewTextBoxColumn,
            this.codigoempleadoDataGridViewTextBoxColumn,
            this.codigoconceptoDataGridViewTextBoxColumn,
            this.valornominaDDataGridViewTextBoxColumn});
            this.dgProductos.DataSource = this.nominadBindingSource;
            this.dgProductos.Location = new System.Drawing.Point(297, 24);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(495, 205);
            this.dgProductos.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 37);
            this.label11.TabIndex = 71;
            this.label11.Text = "DETALLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 37);
            this.label10.TabIndex = 70;
            this.label10.Text = "ENCABEZADO";
            // 
            // txtCodigoBodega
            // 
            this.txtCodigoBodega.Location = new System.Drawing.Point(124, 339);
            this.txtCodigoBodega.Name = "txtCodigoBodega";
            this.txtCodigoBodega.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoBodega.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(13, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Valor Nomina:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 258);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(13, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Codigo Concepto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Codigo Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Codigo Nomina";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(124, 139);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(134, 20);
            this.txtStatus.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha Inicial:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(124, 64);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(134, 20);
            this.txtDocumento.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominadBindingSource
            // 
            this.nominadBindingSource.DataMember = "nominad";
            this.nominadBindingSource.DataSource = this.dataSet3;
            // 
            // nominadTableAdapter
            // 
            this.nominadTableAdapter.ClearBeforeFill = true;
            // 
            // codigonominaDataGridViewTextBoxColumn
            // 
            this.codigonominaDataGridViewTextBoxColumn.DataPropertyName = "codigo_nomina";
            this.codigonominaDataGridViewTextBoxColumn.HeaderText = "codigo_nomina";
            this.codigonominaDataGridViewTextBoxColumn.Name = "codigonominaDataGridViewTextBoxColumn";
            // 
            // codigoempleadoDataGridViewTextBoxColumn
            // 
            this.codigoempleadoDataGridViewTextBoxColumn.DataPropertyName = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.HeaderText = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.Name = "codigoempleadoDataGridViewTextBoxColumn";
            // 
            // codigoconceptoDataGridViewTextBoxColumn
            // 
            this.codigoconceptoDataGridViewTextBoxColumn.DataPropertyName = "codigo_concepto";
            this.codigoconceptoDataGridViewTextBoxColumn.HeaderText = "codigo_concepto";
            this.codigoconceptoDataGridViewTextBoxColumn.Name = "codigoconceptoDataGridViewTextBoxColumn";
            // 
            // valornominaDDataGridViewTextBoxColumn
            // 
            this.valornominaDDataGridViewTextBoxColumn.DataPropertyName = "valor_nominaD";
            this.valornominaDDataGridViewTextBoxColumn.HeaderText = "valor_nominaD";
            this.valornominaDDataGridViewTextBoxColumn.Name = "valornominaDDataGridViewTextBoxColumn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker2.TabIndex = 79;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadoBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 80;
            this.comboBox1.ValueMember = "codigo_empleado";
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.dataSet4;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.conceptoBindingSource;
            this.comboBox2.DisplayMember = "codigo_concepto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 81;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conceptoBindingSource
            // 
            this.conceptoBindingSource.DataMember = "concepto";
            this.conceptoBindingSource.DataSource = this.dataSet5;
            // 
            // conceptoTableAdapter
            // 
            this.conceptoTableAdapter.ClearBeforeFill = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(655, 236);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 82;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCompletarEncabezado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigoBodega);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Name = "frmNomina";
            this.Text = "frmNomina";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompletarEncabezado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoBodega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource nominadBindingSource;
        private DataSet3TableAdapters.nominadTableAdapter nominadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigonominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoconceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valornominaDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DataSet4TableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource conceptoBindingSource;
        private DataSet5TableAdapters.conceptoTableAdapter conceptoTableAdapter;
        private System.Windows.Forms.Button btnFinalizar;
    }
}