using C_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class Negocio_Buscar
    {
        Negocio_logica_Buscar _Logica_Buscar = new Negocio_logica_Buscar();

        

        public Negocio_Buscar()
        {
        }

        public List<Contactos> BuscarContacto(string Busqueda, int iduser)
        {
            return _Logica_Buscar.BuscarContacto(Busqueda,iduser);
        }
    }
}
