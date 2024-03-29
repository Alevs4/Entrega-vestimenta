﻿using Entrega_vestimenta.Datos;
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
using System.Runtime.ConstrainedExecution;
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
            LblHuella.Visible = false;
            xVerificationControl.Visible = false;


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

                    } else
                    {
                        if (xint == totalFila)
                        {
                            if (TerminarBucle == false)
                            {
                                MessageBox.Show("Huella Digital no Existe en el sistema");
                                xVerificationControl.Enabled = false;

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
            Guardar_ropa();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar_EntregaRopa();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void botonesRedondos1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Guardar_ropa()
        {
     
            try
            {
            RN_Ropa obj = new RN_Ropa();
            EN_Ropa per = new EN_Ropa();
                string id = TxtId.Text;    
            DataTable dt = new DataTable();
                dt = obj.RN_Leer_toda_Entrga(id);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe registro porfavor editar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    per.Idpersonal = TxtId.Text;
                    per.Nombres = TxtNombre.Text;
                    per.Dni = TxtRut.Text;
                    per.Rol = TxtArea.Text;
                    per.Estado = TxtEstado.Text;
                    per.Sexo = TxtSexo.Text;
                    per.Turno = TxtTurno.Text;
                    per.Kimono = Txt1.Text;
                    per.Delantal_Rojo = Txt2.Text;
                    per.Delantal_blanco = Txt3.Text;
                    per.Zapatos = Txt4.Text;
                    per.ChalecoR = Txt5.Text;
                    per.ParcaTer = Txt6.Text;
                    per.JardineraTer = Txt7.Text;
                    per.GuantesMultiflex = Txt8.Text;
                    per.GuantesG = Txt9.Text;
                    per.GuantesP = Txt10.Text;
                    per.GorroP = Txt11.Text;
                    per.CuelloP = Txt12.Text;
                    per.CofiaR = Txt13.Text;
                    per.Jockey = Txt14.Text;
                    per.Manguillas = Txt15.Text;
                    per.TrajeAgua = Txt16.Text;
                    per.CubreCalzado = Txt17.Text;
                    per.BotasAgua = Txt18.Text;
                    per.PoleraLarga = Txt19.Text;
                    per.Poleron = Txt20.Text;
                    per.PantalonCargo = Txt21.Text;
                    per.Pechera = Txt22.Text;
                    per.Oberol = Txt23.Text;
                    per.Otro = Txt24.Text;
                    validarTextos();
                    obj.RN_Registrar_Ropa(per);

                    if (BD_Entrega_Ropa.saved == true)
                    {

                        MessageBox.Show("Agregado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscar buscar = new FormularioBuscar();
            this.Hide();
            BtnEditar.Visible = true;
            BtnEliminar.Visible = true;
            buscar.ShowDialog();
        }
        private void validarTextos()
        {
            if (TxtNombre.Text == "" || TxtRut.Text == "" || TxtId.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool xedit = false;
        public void Buscar_Entrega_ParaEditar(string id)
        {
            try
            {
                RN_Ropa obj = new RN_Ropa();
                DataTable dt = new DataTable();


                dt = obj.RN_Buscar_entrega_xValor(id);
                if (dt.Rows.Count == 0) return;
                {
                    TxtRut.Text = Convert.ToString(dt.Rows[0]["rut"]);
                    TxtNombre.Text = Convert.ToString(dt.Rows[0]["Nombre"]);
                    TxtId.Text = Convert.ToString(dt.Rows[0]["Id_personal"]);
                    TxtArea.Text = Convert.ToString(dt.Rows[0]["area"]);
                    TxtEstado.Text = Convert.ToString(dt.Rows[0]["estado"]);
                    TxtSexo.Text = Convert.ToString(dt.Rows[0]["sexo"]);
                    TxtTurno.Text = Convert.ToString(dt.Rows[0]["turno"]);
                    Txt1.Text = Convert.ToString(dt.Rows[0]["Kimono_rojo"]);
                    Txt2.Text = Convert.ToString(dt.Rows[0]["Delantal_azul"]);
                    Txt3.Text = Convert.ToString(dt.Rows[0]["Delantal_blanco"]);
                    Txt4.Text = Convert.ToString(dt.Rows[0]["Zapatos"]);
                    Txt5.Text = Convert.ToString(dt.Rows[0]["Chaleco_reflectante"]);
                    Txt6.Text = Convert.ToString(dt.Rows[0]["parca_termica"]);
                    Txt7.Text = Convert.ToString(dt.Rows[0]["Jardinera_termica"]);
                    Txt8.Text = Convert.ToString(dt.Rows[0]["guantes_multiflex"]);
                    Txt9.Text = Convert.ToString(dt.Rows[0]["guante_goma"]);
                    Txt10.Text = Convert.ToString(dt.Rows[0]["guante_polar"]);
                    Txt11.Text = Convert.ToString(dt.Rows[0]["gorro_polar"]);
                    Txt12.Text = Convert.ToString(dt.Rows[0]["Cuello_polar"]);
                    Txt13.Text = Convert.ToString(dt.Rows[0]["cofia_roja"]);
                    Txt14.Text = Convert.ToString(dt.Rows[0]["Jockey"]);
                    Txt15.Text = Convert.ToString(dt.Rows[0]["manguillas"]);
                    Txt16.Text = Convert.ToString(dt.Rows[0]["traje_agua"]);
                    Txt17.Text = Convert.ToString(dt.Rows[0]["cubre_calzado"]);
                    Txt18.Text = Convert.ToString(dt.Rows[0]["botas_agua"]);
                    Txt19.Text = Convert.ToString(dt.Rows[0]["polera_larga"]);
                    Txt20.Text = Convert.ToString(dt.Rows[0]["poleron"]);
                    Txt21.Text = Convert.ToString(dt.Rows[0]["pantalon_cargo"]);
                    Txt22.Text = Convert.ToString(dt.Rows[0]["pechera"]);
                    Txt23.Text = Convert.ToString(dt.Rows[0]["oberol"]);
                    Txt24.Text = Convert.ToString(dt.Rows[0]["otro"]);

                }

                xedit = true;
                BtnEditar.Enabled = true;
                //Pic_persona.Load(xFotoruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los Datos: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LblHuella.Visible = true;
            xVerificationControl.Visible = true;
            BtnGuardar.Visible = true;
            BtnEliminar.Visible = false;
            BtnEditar.Visible = false;
            limpiar();
        }
         public void limpiar()
        {
            TxtId.Text="";
            TxtNombre.Text ="";
            TxtRut.Text="";
            TxtArea.Text="";
            TxtEstado.Text="";
            TxtSexo.Text="";
            TxtTurno.Text="";
            Txt1.Text="";
            Txt2.Text="";
            Txt3.Text="";
            Txt4.Text="";
            Txt5.Text="";
            Txt6.Text="";
            Txt7.Text="";
            Txt8.Text = "";
            Txt9.Text = "";
            Txt10.Text = "";
            Txt11.Text = "";
            Txt12.Text = "";
            Txt13.Text = "";
            Txt14.Text = "";
            Txt15.Text = "";
            Txt16.Text = "";
            Txt17.Text = "";
            Txt18.Text = "";
            Txt19.Text = "";
            Txt20.Text = "";
            Txt21.Text = "";
            Txt22.Text = "";
            Txt23.Text = "";
            Txt24.Text = "";

        }
        private void Editar_EntregaRopa()
        {

            RN_Ropa obj = new RN_Ropa();
            EN_Ropa per = new EN_Ropa();

            try
            {
                per.Idpersonal = TxtId.Text;
                per.Kimono = Txt1.Text;
                per.Delantal_blanco = Txt2.Text;
                per.Delantal_Rojo = Txt3.Text;
                per.Zapatos = Txt4.Text;
                per.ChalecoR = Txt5.Text;
                per.ParcaTer = Txt6.Text;
                per.JardineraTer = Txt7.Text;
                per.GuantesMultiflex = Txt8.Text;
                per.GuantesG = Txt9.Text;
                per.GuantesP = Txt10.Text;
                per.GorroP = Txt11.Text;
                per.CuelloP = Txt12.Text;
                per.CofiaR = Txt13.Text;
                per.Jockey = Txt14.Text;
                per.Manguillas = Txt15.Text;
                per.TrajeAgua = Txt16.Text;
                per.CubreCalzado = Txt17.Text;
                per.BotasAgua = Txt18.Text;
                per.PoleraLarga = Txt19.Text;
                per.Poleron = Txt20.Text;
                per.PantalonCargo = Txt21.Text;
                per.Pechera = Txt22.Text;
                per.Oberol = Txt23.Text;
                per.Otro = Txt24.Text;
                obj.RN_Editar_Ropa(per);

                if (BD_Entrega_Ropa.editar == true)
                {
                    MessageBox.Show("Datos Modificados Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }

}