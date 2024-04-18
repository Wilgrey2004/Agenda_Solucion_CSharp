using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Negocio;
using C_Vista;

namespace C_Vista
{
    public partial class Loging : Form
    {
       
        Negocio_Get ng = new Negocio_Get();

        public Loging()
        {
            InitializeComponent();
        }
        
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();

            form1.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
             var guardar= ng.GetUser(txtEmail.Text,txtPass.Text);
                
            if (guardar.Item1 != 0)
            {
                Agenda agenda = new Agenda();
               
                agenda.idUser = guardar.Item1;
                agenda.userNametxt = guardar.Item2;
                agenda.userEmailtxt = guardar.Item3;

                agenda.ShowDialog();
                return;
            }

            MessageBox.Show("Usuario no registrado");
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }
    }
}
