using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace EjExamenFich
{
    public partial class ConsultaAlumno : Form
    {
        private Form1 menu = Form1.obtenerInstancia();
        private static ArrayList alumnos = new ArrayList();
        private string familia;
        public ConsultaAlumno(string familia)
        {
            InitializeComponent();
            this.familia = familia;
        }

        private void ConsultaAlumno_Load(object sender, EventArgs e)
        {
            alumnos = menu.pasarArrayList();
            if (familia.Equals("Administrativo"))
            {
                this.Text = "Consulta: Administrativo";
                listBox.Items.Clear();
                foreach (Alumno a in alumnos)
                {
                    if (a.Ensenianza1.Equals("Administrativo"))
                    {
                        listBox.Items.Add(a.DNI1);
                    }
                }
            }
            else if (familia.Equals("Comercio"))
            {
                this.Text = "Consulta: Comercio";
                listBox.Items.Clear();
                foreach (Alumno a in alumnos)
                {
                    if (a.Ensenianza1.Equals("Comercio"))
                    {
                        listBox.Items.Add(a.DNI1);
                    }
                }

            }
            else if (familia.Equals("Informatica"))
            {
                this.Text = "Consulta: Informática";
                listBox.Items.Clear();
                foreach (Alumno a in alumnos)
                {
                    if (a.Ensenianza1.Equals("Informatica"))
                    {
                        listBox.Items.Add(a.DNI1);
                    }
                }

            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Alumno a in alumnos)
            {
                if (listBox.SelectedItem != null)
                {
                    if (listBox.SelectedItem.Equals(a.DNI1))
                    {
                        DNImaskedTextBox.Text = a.DNI1;
                        NombretextBox.Text = a.Nombre1;
                        DirecciontextBox.Text = a.Direccion1;
                        TelefonomaskedTextBox.Text = a.Telefono1;
                        EmailtextBox.Text = a.Email1;
                        ActivocheckBox.Checked = a.Activo1;
                    }
                }
            }
        }
    }
}
