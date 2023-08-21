using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregistro.clases
{
    internal class conexion
    {
        public string conn()
        {
            string miconexion = ("Data Source=DESKTOP-UDV0HQQ;Initial Catalog=vehiculos;Integrated Security=True");
            return miconexion;
        }
    }
}
