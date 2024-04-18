using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Datos;

namespace C_Negocio
{
    public class Negocio_New
    {
        Negocio_logica_News nn = new Negocio_logica_News();
       
        public void New_User(string name, string correo, string pass)
        {
           nn.NewUser(name, correo, pass);
        }

        public void New_Contact(int idUser, string Name_Contacto, string apellido_Contacto, string Numero_Del_Contacto, string Correo_Del_Contacto)
        {

            if (Name_Contacto == string.Empty)
            {
                MessageBox.Show("Nombre del contacto esta en blanco");
                return;
            }

            if (Numero_Del_Contacto == string.Empty)
            {
                MessageBox.Show("Numero del contacto esta en blanco");
                return;
            }

            if (Numero_Del_Contacto.Length < 11 || Numero_Del_Contacto.Length > 11)
            {
                MessageBox.Show("Un contacto debe tener exactamente 11 digitos," +
                    " el quie usted digito tiene: " + Numero_Del_Contacto.Length.ToString());
                return;
            }

            if (apellido_Contacto == string.Empty && Correo_Del_Contacto == string.Empty)
            {
                apellido_Contacto = "Vacio";
                Correo_Del_Contacto = "Vacio@";
                nn.NewContact(idUser, Name_Contacto, apellido_Contacto, Numero_Del_Contacto, Correo_Del_Contacto);
                return; 
            }

            if (apellido_Contacto == string.Empty)
            {
                apellido_Contacto = "Vacio";
                nn.NewContact(idUser, Name_Contacto, apellido_Contacto, Numero_Del_Contacto, Correo_Del_Contacto);
                return;
            }

            if (Correo_Del_Contacto == string.Empty)
            {
                Correo_Del_Contacto = "Vacio@";
                nn.NewContact(idUser, Name_Contacto, apellido_Contacto, Numero_Del_Contacto, Correo_Del_Contacto);
                return;
            }

            

        }


    }

    
}
