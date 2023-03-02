﻿using Entrega_vestimenta.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_vestimenta.Datos
{
    internal class BD_Entrega_Ropa : Conexion
    {
        public static bool saved = false;
        public static bool editar = false;
        //Metodo Para Registrar Personal
        public void BD_Registrar_Ropa(EN_Ropa ropa)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Insertar_ropa", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Id_personal", ropa.Idpersonal);              
                cmd.Parameters.AddWithValue("@nombreComplto", ropa.Nombres); 
                cmd.Parameters.AddWithValue("@dni", ropa.Dni);
                cmd.Parameters.AddWithValue("@rol", ropa.Rol);              
                cmd.Parameters.AddWithValue("@estado", ropa.Estado);
                cmd.Parameters.AddWithValue("@Sexo", ropa.Sexo);
                cmd.Parameters.AddWithValue("@turno", ropa.Turno);
                cmd.Parameters.AddWithValue("@kimonoR", ropa.Kimono);
                cmd.Parameters.AddWithValue("@delantalR", ropa.Delantal_Rojo);
                cmd.Parameters.AddWithValue("@delantalB", ropa.Delantal_blanco);
                cmd.Parameters.AddWithValue("@zapatos", ropa.Zapatos);
                cmd.Parameters.AddWithValue("@chalecoR", ropa.ChalecoR);
                cmd.Parameters.AddWithValue("@parcaT", ropa.ParcaTer);
                cmd.Parameters.AddWithValue("@jardineraT", ropa.JardineraTer);
                cmd.Parameters.AddWithValue("@guantesM", ropa.GuantesMultiflex);
                cmd.Parameters.AddWithValue("@guantesG", ropa.GuantesG);
                cmd.Parameters.AddWithValue("@guantesP", ropa.GuantesP);
                cmd.Parameters.AddWithValue("@gorroP", ropa.GorroP);
                cmd.Parameters.AddWithValue("@cuelloP", ropa.CuelloP);
                cmd.Parameters.AddWithValue("@cofiaR", ropa.CofiaR);
                cmd.Parameters.AddWithValue("@jockey", ropa.Jockey);
                cmd.Parameters.AddWithValue("@manguillas", ropa.Manguillas);
                cmd.Parameters.AddWithValue("@trajeAgua", ropa.TrajeAgua);
                cmd.Parameters.AddWithValue("@cubreCalzado", ropa.CubreCalzado);
                cmd.Parameters.AddWithValue("@botasAgua", ropa.BotasAgua);
                cmd.Parameters.AddWithValue("@poleraLarga", ropa.PoleraLarga);
                cmd.Parameters.AddWithValue("@poleron", ropa.Poleron);
                cmd.Parameters.AddWithValue("@pantalonC", ropa.PantalonCargo);
                cmd.Parameters.AddWithValue("@pechera", ropa.Pechera);
                cmd.Parameters.AddWithValue("@oberol", ropa.Oberol);
                cmd.Parameters.AddWithValue("@otro", ropa.Otro);
            

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                saved = true;
            }
            catch (Exception ex)
            {
                saved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
