namespace EjExamenFich
{
    partial class ConsultaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DNI = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ActivocheckBox = new System.Windows.Forms.CheckBox();
            this.DNImaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(344, 66);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 1;
            this.DNI.Text = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(344, 116);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(344, 172);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 2;
            this.Direccion.Text = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(344, 228);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 3;
            this.Telefono.Text = "Telefono";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(344, 278);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // ActivocheckBox
            // 
            this.ActivocheckBox.AutoSize = true;
            this.ActivocheckBox.Enabled = false;
            this.ActivocheckBox.Location = new System.Drawing.Point(346, 327);
            this.ActivocheckBox.Name = "ActivocheckBox";
            this.ActivocheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActivocheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActivocheckBox.TabIndex = 5;
            this.ActivocheckBox.Text = "Activo";
            this.ActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // DNImaskedTextBox
            // 
            this.DNImaskedTextBox.Enabled = false;
            this.DNImaskedTextBox.Location = new System.Drawing.Point(425, 57);
            this.DNImaskedTextBox.Mask = "00000000-A";
            this.DNImaskedTextBox.Name = "DNImaskedTextBox";
            this.DNImaskedTextBox.Size = new System.Drawing.Size(154, 20);
            this.DNImaskedTextBox.TabIndex = 6;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(421, 107);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(158, 20);
            this.NombretextBox.TabIndex = 7;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Enabled = false;
            this.DirecciontextBox.Location = new System.Drawing.Point(421, 165);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(158, 20);
            this.DirecciontextBox.TabIndex = 8;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Enabled = false;
            this.EmailtextBox.Location = new System.Drawing.Point(421, 271);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(158, 20);
            this.EmailtextBox.TabIndex = 10;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Enabled = false;
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(421, 221);
            this.TelefonomaskedTextBox.Mask = "000000000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(157, 20);
            this.TelefonomaskedTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 106);
            this.button1.TabIndex = 12;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(35, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(237, 368);
            this.listBox.TabIndex = 13;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // ConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.DNImaskedTextBox);
            this.Controls.Add(this.ActivocheckBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DNI);
            this.Name = "ConsultaAlumno";
            this.Text = "Consulta Alumnos: ";
            this.Load += new System.EventHandler(this.ConsultaAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.CheckBox ActivocheckBox;
        private System.Windows.Forms.MaskedTextBox DNImaskedTextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox;
    }
}