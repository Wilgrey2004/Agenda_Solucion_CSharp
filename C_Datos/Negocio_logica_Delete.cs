using C_Datos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace C_Negocio
{
    public class Negocio_logica_Delete
    {
        public  void DeleteUser(int id)
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    var deleteUser = db.UserAgenda.FirstOrDefault(sf => sf.userID.Equals(id));

                    if (deleteUser != null)
                    {
                        db.UserAgenda.Remove(deleteUser);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        public  void DeleteContacto(int id)
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    var deleteContact = db.Contactos.FirstOrDefault(sf => sf.ContactoId.Equals(id));

                    if (deleteContact != null)
                    {
                        db.Contactos.Remove(deleteContact);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
           
        }

    }
}
