﻿using Entrega_vestimenta.Datos;
using Entrega_vestimenta.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_vestimenta.Negocio
{
    internal class RN_Ropa
    {
        public void RN_Registrar_Ropa(EN_Ropa per)
        {
            BD_Entrega_Ropa obj = new BD_Entrega_Ropa();
            obj.BD_Registrar_Ropa(per);
        }
        public DataTable RN_Buscar_entrega_xValor(string valor)
        {
            BD_Entrega_Ropa obj = new BD_Entrega_Ropa();
            return obj.BD_Buscar_Entrega_XRut(valor);
        }
        public DataTable RN_Leer_toda_Entrga(string id)
        {
            BD_Entrega_Ropa obj = new BD_Entrega_Ropa();
            return obj.BD_Leer_Entrega(id);

        }
        public void RN_Editar_Ropa(EN_Ropa ropa)
        {
            BD_Entrega_Ropa obj = new BD_Entrega_Ropa();
            obj.BD_Editar_Ropa(ropa);
        }
        public void RN_EliminarEntregaRopa(string ropa)
        {
            BD_Entrega_Ropa obj = new BD_Entrega_Ropa();
            obj.BD_EliminarEntregaRopa(ropa);
        }
    }
}
