using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Datos;

namespace C_Negocio
{
    public class Negocio_logica_Gets
    {
        public  List<UserAgenda> GetUserAgenda()
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    List<UserAgenda> ListDeUsuarios = db.UserAgenda.ToList();
                    return ListDeUsuarios;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            return null; 
           
        }
        public UserAgenda GetUserAgenda(string correo, string pass)
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    UserAgenda ListDeUsuarios = db.UserAgenda.FirstOrDefault(sf=>sf.Correo == correo);

                    if (ListDeUsuarios != null)
                    {
                        if (ListDeUsuarios.Pass.Equals(pass))
                        {
                            return ListDeUsuarios;
                        }
                        else 
                        {
                            return null; 
                        }
                        
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            return null;

        }
        public  List<Contactos> GetContactos()
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    List<Contactos> ListDeContactos = db.Contactos.ToList();
                    return ListDeContactos;
                }

            }catch (Exception ex){

                MessageBox.Show("" + ex);

            }

            return null; 
        }

        public List<Contactos> GetContactos(int iduser)
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    List<Contactos> ListDeContactos = db.Contactos.Where(ws => ws.userID == iduser).ToList();
                    return ListDeContactos;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);

            }

            return null;
        }
    }
}
