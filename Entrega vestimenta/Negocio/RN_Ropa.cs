using Entrega_vestimenta.Datos;
using Entrega_vestimenta.Entidad;
using System;
using System.Collections.Generic;
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
    }
}
