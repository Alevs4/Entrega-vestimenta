using Entrega_vestimenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_vestimenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ValidarTexbox()
        {
            if (TxtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsuario.Focus();
                return false;

            }
            if (TxtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPass.Focus();
                return false;

            }
            return true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            AccederAlSistema();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtUsuario.Focus();
        }
        private void AccederAlSistema()
        {
            RN_Usuarios obj = new RN_Usuarios();
            DataTable dt = new DataTable();
            int veces = 0;

            if (ValidarTexbox() == false)
                return;

            string usu, pass;
            usu = TxtUsuario.Text.Trim();
            pass = TxtPass.Text.Trim();

            if (obj.RN_Verificar_Acceso(usu, pass) == true)
            {
                //los datos son correctos
                //MessageBox.Show("Bienvenido al Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cls_Libreria.Usuario = usu;

                dt = obj.RN_Lerr_Datos_Usuario(usu);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Usu"]);
                    Cls_Libreria.Apellidos = Convert.ToString(dr["Nombre_Completo"]);
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Rol"]);
                    Cls_Libreria.Rol = dr["NomRol"].ToString();
                    Cls_Libreria.Foto = dr["Avatar"].ToString();
                }


                Principal principal = new Principal();
                this.Hide();
                principal.Show();
                principal.Cargar_Datos_Usuario();
        
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtUsuario.Text = "";
                TxtPass.Text = "";
                TxtUsuario.Focus();
                veces += 1;

                if (veces == 3)
                {
                    MessageBox.Show("Numero de intentos Superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

    }
}
