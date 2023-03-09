using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_vestimenta
{
    public partial class FormularioBuscar : Form
    {
        public FormularioBuscar()
        {
            InitializeComponent();
        }

        private void botonesRedondos1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Principal rop = new Principal();
            string id = TxtRutBuscar.Text;


            rop.xedit = true;
            rop.Buscar_Entrega_ParaEditar(id);
            this.Hide(); 
            rop.LblHuella.Visible = false;
            rop.xVerificationControl.Visible = false;
            rop.BtnGuardar.Visible = false;
            rop.BtnEditar.Visible = true;
            rop.ShowDialog();
            
         
        }
    }
}
