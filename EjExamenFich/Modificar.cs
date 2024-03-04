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
                serializarFichero();
            }
        }
        public void serializarFichero()
        {
            using (FileStream archivo = new FileStream(menu.getRuta(), FileMode.Create))
            {
                // Crear un BinaryFormatter para la serialización binaria
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                // Serializar la lista y escribir en el archivo
                binaryFormatter.Serialize(archivo, alumnos);

                Console.WriteLine("Datos escritos en el archivo correctamente.");
            }
        }
      
        public void modificarPass(string dni, string contrasenia)
        {
            foreach (Alumno a in alumnos)
            {
                if (a.DNI1.Equals(dni))
                {
                    a.setPass(contrasenia);
                    DialogResult result = MessageBox.Show("¿Quieres activar al alumno?", "ACTIVAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        a.Activo1 = true;
                        MessageBox.Show("Alumno " + a.Nombre1 + " actualizado " + a.Activo1 + " con contraseña " + a.getPass());
                    }
                }
            }
        }

        private void ContraseniatextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ContraseniatextBox.Text))
            {
                errorProvider.SetError(ContraseniatextBox, "No puede estar vacía");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }
        public bool encontrarAlumno(string nif)
        {
            bool encontrado = false;
            foreach (Alumno a in alumnos)
            {
                if (a.DNI1.Equals(nif))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
      
        private void DNImaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!this.encontrarAlumno(DNImaskedTextBox.Text))
            {
                errorProvider.SetError(DNImaskedTextBox, "El DNI no existe");
                e.Cancel = true;

            }
            else
            {
                errorProvider.Clear();
                foreach (Alumno a in alumnos)
                {
                    if (a.DNI1.Equals(DNImaskedTextBox.Text))
                    {
                        NombretextBox.Text = a.Nombre1;
                        DirecciontextBox.Text = a.Direccion1;
                        TelefonomaskedTextBox.Text = a.Telefono1;
                        EmailtextBox.Text = a.Email1;
                        ContraseniatextBox.Text = a.getPass();
                        ContraseniaNuevatextBox.Text = a.getPass();
                        ActivocheckBox.Checked = a.Activo1;
                    }
                }


            }
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            alumnos = menu.pasarArrayList();
        }

        private void ContraseniaNuevatextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ContraseniatextBox.Text.Equals(ContraseniaNuevatextBox.Text))
            {
                errorProvider.SetError(ContraseniaNuevatextBox, "Las contraseñas no coinciden");
                e.Cancel = true;
            }
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
    }
}
