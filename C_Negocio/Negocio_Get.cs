using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Datos;

namespace C_Negocio
{
    public class Negocio_Get
    {
        Negocio_logica_Gets ng = new Negocio_logica_Gets();

        public (int,string,string) GetUser(string correo, string pass)
        {
            UserAgenda usuario = ng.GetUserAgenda(correo, pass);

            if (usuario != null)
            {

                return (usuario.userID,usuario.Nombre,usuario.Correo);

            }

            return (0,"","");
        }

        public List<Contactos> GetContactos(int idus)
        {
           

           
            return ng.GetContactos(idus);

        }
    }
}
