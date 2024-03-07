using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExamenFich
{
    [Serializable]
    public class Alumno
    {
        private string DNI;
        private string Nombre;
        private string Direccion;
        private string Ensenianza;
        private string Telefono;
        private string Email;
        private string Pass;
        private bool Activo;

        public Alumno(string dNI, string nombre, string direccion, string ensenianza, string telefono, string email, string pass, bool activo)
        {
            DNI = dNI;
            Nombre = nombre;
            Direccion = direccion;
            Ensenianza = ensenianza;
            Telefono = telefono;
            Email = email;
            Pass = "";
            Activo = false;
        }

        public string DNI1 { get => DNI; set => DNI = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Ensenianza1 { get => Ensenianza; set => Ensenianza = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string getPass()
        {
            return Pass;
        }
        public string setPass(string passN)
        {
            Pass = passN;
            return Pass;
        }
        public bool Activo1 { get => Activo; set => Activo = value; }
        public static bool validarDNI(string nif)
        {
            const string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            int numero = 0;
            char letra, letra2;
            letra = Convert.ToChar(nif.Substring(nif.Length - 1));
            bool validacion = false;
            if ((nif.Length != 9) || !int.TryParse(nif.Substring(0, 8), out numero))
            {
                validacion = false;
            }
            letra2 = cadena[numero % 23];
            if (letra == letra2)
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }

            return validacion;
        }
    }
}
