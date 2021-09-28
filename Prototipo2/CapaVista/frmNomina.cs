using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmNomina : Form
    {
        public frmNomina()
        {
            InitializeComponent();
        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.concepto' Puede moverla o quitarla según sea necesario.
            this.conceptoTableAdapter.Fill(this.dataSet5.concepto);
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dataSet4.empleado);
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.nominad' Puede moverla o quitarla según sea necesario.
            this.nominadTableAdapter.Fill(this.dataSet3.nominad);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompletarEncabezado_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtDocumento.Text;
        }
    }
}
