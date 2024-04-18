using C_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C_Negocio
{
    public class Negocio_logica_Updates
    {


        public  void UpdateContact(int ContactoID, int UserId, string ContactoName, string ContactoLastName, string ContactoNumber,string ContactoEmail)
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    var UpdatSeleccionado = db.Contactos.FirstOrDefault(fs => fs.ContactoId == ContactoID);
                    UpdatSeleccionado.Nombre_Contacto = ContactoName;
                    UpdatSeleccionado.Apellido_Contacto = ContactoLastName;
                    UpdatSeleccionado.Numero_Contacto = ContactoNumber;
                    UpdatSeleccionado.Correo_Contacto = ContactoEmail;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        public  void UpdateUser(int id, string name, string correo, string pass)
        {

            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    var UpdateSeleccionado = db.UserAgenda.FirstOrDefault(sf => sf.userID == id);
                    UpdateSeleccionado.Nombre = name;
                    UpdateSeleccionado.Correo = correo;
                    UpdateSeleccionado.Pass = pass;

                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
           
        }

    }
}
