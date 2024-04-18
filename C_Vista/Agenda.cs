using C_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Vista
{
    public partial class Agenda : Form
    {
        public string userNametxt;
        
        public string userEmailtxt;

        public int idContact;

        public int idUser;

        string[] ColumnasDatos = new string[5];

        Negocio_Get ng = new Negocio_Get();
        
        Negocio_New nn = new Negocio_New();
        
        Negocio_Update nu = new Negocio_Update();

        Negocio_Delete nd = new Negocio_Delete();

        Negocio_Buscar nb = new Negocio_Buscar();
        public Agenda()
        {
            InitializeComponent();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            if (userNametxt != null && idUser != 0 && userEmailtxt != null)
            {
                userName.Text = userNametxt;
                userGmail.Text = userEmailtxt;
                Actualizar();
            }

        }

        private void Actualizar()
        {
            Mydata.DataSource = ng.GetContactos(idUser);
            DataGridViewColumn Columna = Mydata.Columns["ContactoId"];
            Columna.Visible = false;
            DataGridViewColumn Columna2 = Mydata.Columns["userID"];
            Columna2.Visible = false;
            DataGridViewColumn Columna3 = Mydata.Columns["UserAgenda"];
            Columna3.Visible = false;
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mydata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mydata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Mydata.Rows[e.RowIndex];

                if (row != null)
                {
                    
                    ColumnasDatos[0] = row.Cells["ContactoId"].Value.ToString();
                    ColumnasDatos[1] = row.Cells["Nombre_Contacto"].Value.ToString();
                    ColumnasDatos[2] = row.Cells["Apellido_Contacto"].Value.ToString();
                    ColumnasDatos[3] = row.Cells["Numero_Contacto"].Value.ToString();
                    ColumnasDatos[4] = row.Cells["Correo_Contacto"].Value.ToString();

                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            nn.New_Contact(idUser, txtName.Text, txtLastName.Text, txtNumber.Text, txtEmail.Text);
            Actualizar();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            if (ColumnasDatos[0] == string.Empty)
            {
                MessageBox.Show("Ningun contacto seleccionado");
                return;
            }

            int.TryParse(ColumnasDatos[0], out idContact);
            txtName.Text = ColumnasDatos[1];
            txtLastName.Text = ColumnasDatos[2];
            txtNumber.Text = ColumnasDatos[3];
            txtEmail.Text = ColumnasDatos[4];
            return;

        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            idContact = 0;
            txtName.Text = "";
            txtLastName.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
            return; 
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            nu.Actualizar(idContact,idUser,txtName.Text,txtLastName.Text,txtNumber.Text,txtEmail.Text);
            Actualizar();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (idContact != 0)
            {
                nd.Delete(idContact);
                Actualizar();  
                return;
            }

            MessageBox.Show("No hay un contacto seleccionado....");

        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            ActualizarBuscar();
        }

        private void ActualizarBuscar()
        {
            if (txtTextoBuscar.Text != string.Empty)
            {
                Mydata.DataSource = nb.BuscarContacto(txtTextoBuscar.Text,idUser);
               
                DataGridViewColumn Columna = Mydata.Columns["ContactoId"];
                Columna.Visible = false;
                DataGridViewColumn Columna2 = Mydata.Columns["userID"];
                Columna2.Visible = false;
                DataGridViewColumn Columna3 = Mydata.Columns["UserAgenda"];
                Columna3.Visible = false;
            }
            
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            Actualizar();
            txtTextoBuscar.Text = string.Empty;
        }
    }
}
