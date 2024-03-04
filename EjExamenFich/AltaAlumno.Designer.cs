namespace EjExamenFich
{
    partial class AltaAlumno
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
            this.components = new System.ComponentModel.Container();
            this.DNILabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.FamiliaLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DNIMasked = new System.Windows.Forms.MaskedTextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.FamiliaCombo = new System.Windows.Forms.ComboBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DNILabel
            // 
            this.DNILabel.AutoSize = true;
            this.DNILabel.Location = new System.Drawing.Point(54, 65);
            this.DNILabel.Name = "DNILabel";
            this.DNILabel.Size = new System.Drawing.Size(26, 13);
            this.DNILabel.TabIndex = 0;
            this.DNILabel.Text = "DNI";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(54, 112);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Location = new System.Drawing.Point(54, 159);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(52, 13);
            this.DireccionLabel.TabIndex = 2;
            this.DireccionLabel.Text = "Dirección";
            // 
            // FamiliaLabel
            // 
            this.FamiliaLabel.AutoSize = true;
            this.FamiliaLabel.Location = new System.Drawing.Point(54, 206);
            this.FamiliaLabel.Name = "FamiliaLabel";
            this.FamiliaLabel.Size = new System.Drawing.Size(39, 13);
            this.FamiliaLabel.TabIndex = 3;
            this.FamiliaLabel.Text = "Familia";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Location = new System.Drawing.Point(54, 255);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLabel.TabIndex = 4;
            this.TelefonoLabel.Text = "Teléfono";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(54, 304);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // DNIMasked
            // 
            this.DNIMasked.Location = new System.Drawing.Point(134, 58);
            this.DNIMasked.Mask = "00000000-A";
            this.DNIMasked.Name = "DNIMasked";
            this.DNIMasked.Size = new System.Drawing.Size(146, 20);
            this.DNIMasked.TabIndex = 6;
            this.DNIMasked.Validating += new System.ComponentModel.CancelEventHandler(this.DNIMasked_Validating_1);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(134, 105);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(146, 20);
            this.NombretextBox.TabIndex = 7;
            this.NombretextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NombretextBox_Validating_1);
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(134, 152);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(146, 20);
            this.DirecciontextBox.TabIndex = 8;
            this.DirecciontextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DirecciontextBox_Validating_1);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(134, 301);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(146, 20);
            this.EmailtextBox.TabIndex = 10;
            this.EmailtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailtextBox_Validating_1);
            // 
            // FamiliaCombo
            // 
            this.FamiliaCombo.FormattingEnabled = true;
            this.FamiliaCombo.Items.AddRange(new object[] {
            "Administrativo",
            "Comercio",
            "Informatica"});
            this.FamiliaCombo.Location = new System.Drawing.Point(136, 195);
            this.FamiliaCombo.Name = "FamiliaCombo";
            this.FamiliaCombo.Size = new System.Drawing.Size(143, 21);
            this.FamiliaCombo.TabIndex = 11;
            this.FamiliaCombo.Validating += new System.ComponentModel.CancelEventHandler(this.FamiliaCombo_Validating_1);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(374, 155);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(131, 63);
            this.AceptarButton.TabIndex = 12;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(374, 258);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(131, 63);
            this.CancelarButton.TabIndex = 13;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(137, 248);
            this.TelefonomaskedTextBox.Mask = "000000000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.TelefonomaskedTextBox.TabIndex = 14;
            this.TelefonomaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonomaskedTextBox_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(545, 352);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.FamiliaCombo);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.DNIMasked);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.FamiliaLabel);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.DNILabel);
            this.MaximizeBox = false;
            this.Name = "AltaAlumno";
            this.Text = "Alta Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DNILabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label FamiliaLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.MaskedTextBox DNIMasked;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.ComboBox FamiliaCombo;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}