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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
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
    }
}
