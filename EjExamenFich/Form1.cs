using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace EjExamenFich
{
    public partial class Form1 : Form
    {
        private static ArrayList alumnos = new ArrayList();
        public static string ruta;
        public static Form1 instancia;
        private static FileStream archivo = null;

        public Form1()
        {
            InitializeComponent();
        }
     
        private void crearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            
            openFile.Filter = "Archivo de texto(.txt)|*.txt|Todos los archivos(*.*)|*.*";
            openFile.Title = "Abrir Archivo";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ruta = openFile.FileName;
                archivo = new FileStream(ruta, FileMode.Open);
                alumnos = deserializarFicheroC();
                alumnoToolStripMenuItem.Enabled = true;
                MessageBox.Show("Se ha abierto el fichero " + Path.GetFileName(ruta));
            }
            
          
        }
       
        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            AltaAlumno altaAlumno = new AltaAlumno();
            if (altaAlumno.ShowDialog() == DialogResult.OK)
            {
                
                if (alumnoRepetido(altaAlumno.getAlumno().DNI1))
                {
                    MessageBox.Show("El dni del alumno esta repetido");
                    alumnoToolStripMenuItem.Enabled = false;
                }
                else
                {
                    MessageBox.Show(altaAlumno.getAlumno().DNI1 + " " + altaAlumno.getAlumno().Nombre1);
                    alumnos.Add(altaAlumno.getAlumno()); 
                    serializarFichero(alumnos);
                    alumnoToolStripMenuItem.Enabled = false;
                    archivo.Close();
                    MessageBox.Show("Se ha añadido correctamente el alumno");
                }
                
            }
        }
      
        public static bool alumnoRepetido(string nif)
        {
            bool repetido = false;
            foreach(Alumno a in alumnos)
            {
                if (a.DNI1.Equals(nif))
                {
                    repetido = true;
                }
            }
            return repetido;
        }
        public static Form1 obtenerInstancia()
        {
            if(instancia == null)
            {
                 instancia = new Form1();
            }
            return instancia;
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Archivo de texto(.txt)|*.txt|Todos los archivos(*.*)|*.*";
            saveFile.Title = "Crear archivo";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ruta = saveFile.FileName;
                    archivo = new FileStream(ruta, FileMode.Create);
                    archivo.Close();
                    alumnoToolStripMenuItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivo.Close() ;
            ruta = null;
            alumnoToolStripMenuItem.Enabled = false;
        }
       


        public void serializarFichero(ArrayList al)
        {
            using (FileStream archivo = new FileStream(ruta, FileMode.Create))
            {
                // Crear un BinaryFormatter para la serialización binaria
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                // Serializar la lista y escribir en el archivo
                binaryFormatter.Serialize(archivo, al);

                Console.WriteLine("Datos escritos en el archivo correctamente.");
            }
        }


      /*  public void serializarFicheroArray(ArrayList al)
        {
            FileStream fs = new FileStream(archivo.Name, FileMode.Open, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                //Serializamos la información
                binaryFormatter.Serialize(fs, al);
                archivo.Close();
            }
            catch (SerializationException e1)
            {
                Console.WriteLine(e1.StackTrace);
            }
            finally
            {
                alumnoToolStripMenuItem.Enabled = false;
                archivo.Close();
            }
        }*/
        public ArrayList pasarArrayList()
        {
            return alumnos;
        }
       
        public static ArrayList deserializarFicheroC()
        {
            ArrayList alumnos = new ArrayList();
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                //Deserializamos la información
                alumnos = (ArrayList)binaryFormatter.Deserialize(archivo);
                
                archivo.Close();

            }
            catch (SerializationException e1)
            {
                Console.WriteLine(e1.StackTrace);
                alumnos = new ArrayList();
            }
            finally
            {
                archivo.Close();

            }
            return alumnos;
        }
    
        private void salirAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres salir?", "SALIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultaAlumno = new ConsultaAlumno(administrativoToolStripMenuItem.Text);
            consultaAlumno.ShowDialog();
            alumnoToolStripMenuItem.Enabled = false;
            archivo.Close();
        }

        private void comercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultaAlumno = new ConsultaAlumno(comercioToolStripMenuItem.Text);
            consultaAlumno.ShowDialog();
            alumnoToolStripMenuItem.Enabled = false;
        }

        private void informaticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultaAlumno = new ConsultaAlumno(informaticaToolStripMenuItem.Text);
            consultaAlumno.ShowDialog();
            alumnoToolStripMenuItem.Enabled = false;
        }

        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar(this);
            this.Hide();
            modificar.Show();
            alumnoToolStripMenuItem.Enabled = false;
        }
       public string getRuta()
        {
            return ruta;
        }
    }
}
