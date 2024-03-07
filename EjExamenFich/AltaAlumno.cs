using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EjExamenFich
{
    public partial class AltaAlumno : Form
    {
        private static Alumno alumno;
        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void DNIMasked_Validating_1(object sender, CancelEventArgs e)
        {
            if (!Alumno.validarDNI(DNIMasked.Text.Replace("-", "")))
            {
                errorProvider.SetError(DNIMasked, "El DNI no es válido");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void NombretextBox_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "No puedes dejar el nombre vacio");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void DirecciontextBox_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox, "No puedes dejar la direccion vacia");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void FamiliaCombo_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FamiliaCombo.Text))
            {
                errorProvider.SetError(FamiliaCombo, "No puedes no seleccionar nada");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void TelefonomaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (TelefonomaskedTextBox.TextLength < 9 || !long.TryParse(TelefonomaskedTextBox.Text, out long result))
            {
                errorProvider.SetError(TelefonomaskedTextBox, "Debe ser un número y tener 9 caracteres");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void EmailtextBox_Validating_1(object sender, CancelEventArgs e)
        {
            if (!EmailtextBox.Text.Contains("@") || !EmailtextBox.Text.Contains(".com"))
            {

                errorProvider.SetError(EmailtextBox, "El email debe incluir @ y .com");
                e.Cancel = true;
            }
            else
            {
                errorProvider.Clear();
            }
        }



        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                 alumno = new Alumno(DNIMasked.Text,NombretextBox.Text,DirecciontextBox.Text,FamiliaCombo.Text, TelefonomaskedTextBox.Text,EmailtextBox.Text,"",false);
                this.DialogResult = DialogResult.OK;
            }
            
        }
      
        public Alumno getAlumno()
        {
            return alumno;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
