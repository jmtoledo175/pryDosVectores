using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDosVectores
{
    public partial class fmrDosVectores : Form
    {
        public fmrDosVectores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            for (int i = 0; i < Meses.Length; i++)
            {
                dgvListado.Rows.Add(Meses[i],Importe[i]);
            }
        }

        string[] Meses = new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        decimal[] Importe = new decimal[12];
        Int32 indice = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 i = cmbMes.SelectedIndex; 
            decimal importe = Convert.ToDecimal(cmbImporte.Text);
            Importe[i] = Importe[i]+importe;
            MessageBox.Show("Dato cargado");
        }

        private void fmrDosVectores_Load(object sender, EventArgs e)
        {   
            cmbMes.Items.Clear();
            for (int i = 0; i < Meses.Length; i++) {
                cmbMes.Items.Add(Meses[i]);
            }
            cmbMes.SelectedIndex = 0;      
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();
            int i = 0;
            while (i < Meses.Length)
            {
                dgvListado.Rows.Add(Meses[i], Importe[i]);
                i++;
            }
        }
    }
}
