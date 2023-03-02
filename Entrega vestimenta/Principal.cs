using Entrega_vestimenta.Datos;
using Entrega_vestimenta.Entidad;
using Entrega_vestimenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_vestimenta
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private DPFP.Verification.Verification Verificar;
        private DPFP.Verification.Verification.Result Resultado;
        public void Cargar_Datos_Usuario()
        {
            try
            {

                MessageBox.Show("Bienvenido/a" + Cls_Libreria.Apellidos, "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Lbl_NomUsu.Text = Cls_Libreria.Apellidos;
                lbl_rolNom.Text = Cls_Libreria.Rol;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Verificar = new DPFP.Verification.Verification();
            Resultado = new DPFP.Verification.Verification.Result();
        }
        private int xint = 1;
        private void xVerificationControl_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            DPFP.Template template = new DPFP.Template();
            RN_Personal obj = new RN_Personal();
            DataTable dtpersonas = new DataTable();

            string NroIDPersona = "";
            byte[] finguerByte;
            bool TerminarBucle = false;
            int totalFila = 0;

            try
            {
                dtpersonas = obj.RN_Leer_todaPersona();
                totalFila = dtpersonas.Rows.Count;
                if (dtpersonas.Rows.Count <= 0) return;

                var datoper = dtpersonas.Rows[0];
                foreach (DataRow xitem in dtpersonas.Rows)
                {
                    if (TerminarBucle == true) return;
                    finguerByte = (byte[])xitem["FinguerPrint"];
                    NroIDPersona = Convert.ToString(xitem["Id_Pernl"]);

                    template.DeSerialize(finguerByte);
                    Verificar.Verify(FeatureSet, template, ref Resultado);

                    if (Resultado.Verified == true)
                    {
                        TxtId.Text = Convert.ToString(xitem["Id_Pernl"]);
                        TxtNombre.Text = Convert.ToString(xitem["Nombre_Completo"]);
                        TxtRut.Text = Convert.ToString(xitem["DNIPR"]);
                        TxtArea.Text = Convert.ToString(xitem["Rol"]);
                        TxtEstado.Text = Convert.ToString(xitem["Estado_Per"]);
                        TxtSexo.Text = Convert.ToString(xitem["Sexo"]);
                        TxtTurno.Text = Convert.ToString(xitem["Turno"]);

                    }else
                    {
                        if (xint == totalFila)
                        {
                            if (TerminarBucle == false)
                            {
                                MessageBox.Show("Huella Digital no Existe en el sistema");
                                xVerificationControl.Enabled = true;
                       
                            }
                        }
                    }
                    xint += 1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //LimpiarFormulario();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("Estas seguro que quiere cerrar la APP", "Requerimiento del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Mensaje == DialogResult.OK)
                Application.Exit();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar_Personal();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void botonesRedondos1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Guardar_Personal()
        {

            RN_Ropa obj = new RN_Ropa();
            EN_Ropa per = new EN_Ropa();

      
            try
            {
                per.Idpersonal = TxtId.Text;
                per.Nombres= TxtRut.Text;
                per.Dni = TxtNombre.Text;
                per.Rol = TxtArea.Text;
                per.Estado = TxtEstado.Text;
                per.Sexo = TxtSexo.Text;
                per.Turno = TxtTurno.Text;
                per.Kimono = Convert.ToInt32(Txt1.Text);
                per.Delantal_Rojo = Convert.ToInt32(Txt2.Text);
                per.Delantal_blanco = Convert.ToInt32(Txt3.Text);
                per.Zapatos = Convert.ToInt32(Txt4.Text);
                per.ChalecoR = Convert.ToInt32(Txt5.Text);
                per.ParcaTer = Convert.ToInt32(Txt6.Text);
                per.JardineraTer = Convert.ToInt32(Txt7.Text);
                per.GuantesMultiflex = Convert.ToInt32(Txt8.Text);
                per.GuantesG = Convert.ToInt32(Txt9.Text);
                per.GuantesP = Convert.ToInt32(Txt10.Text);
                per.GorroP = Convert.ToInt32(Txt11.Text);
                per.CuelloP = Convert.ToInt32(Txt12.Text);
                per.CofiaR = Convert.ToInt32(Txt13.Text);
                per.Jockey = Convert.ToInt32(Txt14.Text);
                per.Manguillas = Convert.ToInt32(Txt15.Text);
                per.TrajeAgua = Convert.ToInt32(Txt16.Text);
                per.CubreCalzado = Convert.ToInt32(Txt17.Text);
                per.BotasAgua = Convert.ToInt32(Txt18.Text);
                per.PoleraLarga = Convert.ToInt32(Txt19.Text);
                per.Poleron = Convert.ToInt32(Txt20.Text);
                per.PantalonCargo = Convert.ToInt32(Txt21.Text);
                per.Pechera = Convert.ToInt32(Txt22.Text);
                per.Oberol = Convert.ToInt32(Txt23.Text);
                per.Otro = Convert.ToInt32(Txt24.Text);
                obj.RN_Registrar_Ropa(per);

                if (BD_Entrega_Ropa.saved == true)
                {

                    MessageBox.Show("Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}