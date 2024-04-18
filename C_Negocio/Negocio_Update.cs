using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
   public class Negocio_Update
    {
        Negocio_logica_Updates nu = new Negocio_logica_Updates();
        public Negocio_Update() { }

        public void Actualizar(int ContactoID, int UserId, string ContactoName, string ContactoLastName, string ContactoNumber, string ContactoEmail)
        {
            nu.UpdateContact(ContactoID, UserId, ContactoName, ContactoLastName, ContactoNumber, ContactoEmail);
        }
    }
}
