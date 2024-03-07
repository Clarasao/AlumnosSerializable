using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace EjExamenFich
{
    public partial class Modificar : Form
    {

        private Form1 menu;
        private ArrayList alumnos;
        public Modificar(Form1 form1)
        {
            InitializeComponent();
            this.menu = form1;
        }
      
        private void Volverbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                modificarPass(DNImaskedTextBox.Text, ContraseniaNuevatextBox.Text);
                menu.serializarFichero(alumnos);
            }
        }
 
      
        public void modificarPass(string dni, string contrasenia)
        {
            Alumno alumno1 = null;
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.DNI1.Equals(dni)){
                    alumno1 = alumno;
                }
            }
            alumno1.setPass(contrasenia);
           DialogResult result = MessageBox.Show("¿Quieres activar al alumno?", "ACTIVAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (result == DialogResult.Yes)
              {
                alumno1.Activo1 = true;
                MessageBox.Show("Alumno " + alumno1.Nombre1 + " actualizado " + alumno1.Activo1 + " con contraseña " + alumno1.getPass());
              }
                
        }

        private void ContraseniatextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ContraseniatextBox.Text))
            {
                errorProvider.SetError(ContraseniatextBox, "No puede estar vacía");
                e.Cancel = true;
            }
            else if(string.IsNullOrWhiteSpace(ContraseniaNuevatextBox.Text))
            {
                errorProvider.SetError(ContraseniaNuevatextBox, "No puede estar vacía");
                e.Cancel = true;
            }else if (!ContraseniatextBox.Text.Equals(ContraseniaNuevatextBox.Text))
            {
                errorProvider.SetError(ContraseniaNuevatextBox, "las dos contraseñas no coinciden");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }
    
        private void DNImaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DNImaskedTextBox.Text))
            {
                errorProvider.SetError(DNImaskedTextBox,"El dni esta vacio");
                e.Cancel= true;
            }
            else
            {
                errorProvider.Clear();
            }

        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            alumnos = menu.pasarArrayList();
        }

      

        private void Ver_button_Click(object sender, EventArgs e)
        {
            if (ContraseniatextBox.PasswordChar.Equals('\0'))
            {
                ContraseniatextBox.PasswordChar = '*';
                ContraseniaNuevatextBox.PasswordChar = '*';

            }
            else
            {

                ContraseniatextBox.PasswordChar = '\0';
                ContraseniaNuevatextBox.PasswordChar = '\0';

            }
        }

        private void ContraseniatextBox_TextChanged(object sender, EventArgs e)
        {
            ContraseniatextBox.PasswordChar = '*';
        }

        private void ContraseniaNuevatextBox_TextChanged(object sender, EventArgs e)
        {
            ContraseniaNuevatextBox.PasswordChar = '*';
        }

        private void DNImaskedTextBox_Leave(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.DNI1.Equals(DNImaskedTextBox.Text))
                {
                    NombretextBox.Text = alumno.Nombre1;
                    DirecciontextBox.Text = alumno.Direccion1;
                    TelefonomaskedTextBox.Text = alumno.Telefono1;
                    EmailtextBox.Text = alumno.Email1;
                    ContraseniatextBox.Text = alumno.getPass();
                    ContraseniaNuevatextBox.Text = alumno.getPass();
                    ActivocheckBox.Checked = alumno.Activo1;
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("dni no encontrado");
            }
            
        }
    }
}
