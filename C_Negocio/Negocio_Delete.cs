using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class Negocio_Delete
    {
        Negocio_logica_Delete nd = new Negocio_logica_Delete();
        public Negocio_Delete() { }

        public void Delete(int id) {

            nd.DeleteContacto(id);
            return;
        
        }
    }
}
