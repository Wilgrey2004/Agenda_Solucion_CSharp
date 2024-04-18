using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Datos
{
    public class Negocio_logica_Buscar
    {


        public Negocio_logica_Buscar() { 
        
        }



        public List<Contactos> BuscarContacto(string Busqueda,int idUser)
        {

            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    var ListaDeCoincidencias = db.Contactos.Where(wc =>
                                wc.Nombre_Contacto.Contains(Busqueda) ||
                                wc.Apellido_Contacto.Contains(Busqueda) ||
                                wc.Numero_Contacto.Contains(Busqueda) ||
                                wc.Correo_Contacto.Contains(Busqueda) && 
                                wc.userID == idUser).ToList();

                    return ListaDeCoincidencias;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("" +ex);
            }


            return null; 

        }

    }
}
