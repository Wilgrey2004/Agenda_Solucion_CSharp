using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Datos;
using System.Windows;
using System.Windows.Forms;

namespace C_Negocio
{
    public class Negocio_logica_News
    {

        public  void NewUser(string name, string correo, string pass)
        {
            try
            {
                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                            {
                                var existe = db.UserAgenda.FirstOrDefault( sf => sf.Correo == correo );
                
                                if (existe != null)
                                {
                                    MessageBox.Show("Correo en uso...");
                                    return;
                                }

                                UserAgenda us = new UserAgenda
                                {
                                    Nombre = name,
                                    Correo = correo,
                                    Pass = pass
                                };

                                db.UserAgenda.Add(us);
                                db.SaveChanges();
                                MessageBox.Show("Usuario Creado...");

                                return;
                            }
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }


        public  void NewContact(int idUser, string Name_Contacto, string apellido_Contacto, string Numero_Del_Contacto, string Correo_Del_Contacto)
        {
            try
            {

                using (AgendaVirtualEntities db = new AgendaVirtualEntities())
                {
                    Contactos cn = new Contactos();
                    cn.userID = idUser;
                    cn.Nombre_Contacto = Name_Contacto;
                    cn.Apellido_Contacto = apellido_Contacto;
                    cn.Numero_Contacto = Numero_Del_Contacto;
                    cn.Correo_Contacto = Correo_Del_Contacto;
                    db.Contactos.Add(cn);
                    db.SaveChanges();
                    MessageBox.Show("Contacto Creado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}
