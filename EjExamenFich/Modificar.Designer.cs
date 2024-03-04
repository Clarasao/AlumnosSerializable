namespace EjExamenFich
{
    partial class Modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActivocheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DNImaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.ContraseniatextBox = new System.Windows.Forms.TextBox();
            this.ContraseniaNuevatextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Volverbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ver_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nueva Contraseña";
            // 
            // ActivocheckBox
            // 
            this.ActivocheckBox.AutoSize = true;
            this.ActivocheckBox.Enabled = false;
            this.ActivocheckBox.Location = new System.Drawing.Point(99, 363);
            this.ActivocheckBox.Name = "ActivocheckBox";
            this.ActivocheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActivocheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActivocheckBox.TabIndex = 6;
            this.ActivocheckBox.Text = "Activo";
            this.ActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DNI";
            // 
            // DNImaskedTextBox
            // 
            this.DNImaskedTextBox.Location = new System.Drawing.Point(187, 66);
            this.DNImaskedTextBox.Mask = "00000000-A";
            this.DNImaskedTextBox.Name = "DNImaskedTextBox";
            this.DNImaskedTextBox.Size = new System.Drawing.Size(160, 20);
            this.DNImaskedTextBox.TabIndex = 8;
            this.DNImaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DNImaskedTextBox_Validating);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(187, 106);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(159, 20);
            this.NombretextBox.TabIndex = 9;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Enabled = false;
            this.DirecciontextBox.Location = new System.Drawing.Point(187, 146);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(159, 20);
            this.DirecciontextBox.TabIndex = 10;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Enabled = false;
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(187, 187);
            this.TelefonomaskedTextBox.Mask = "000000000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(159, 20);
            this.TelefonomaskedTextBox.TabIndex = 11;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Enabled = false;
            this.EmailtextBox.Location = new System.Drawing.Point(187, 227);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(159, 20);
            this.EmailtextBox.TabIndex = 12;
            // 
            // ContraseniatextBox
            // 
            this.ContraseniatextBox.Location = new System.Drawing.Point(187, 274);
            this.ContraseniatextBox.Name = "ContraseniatextBox";
            this.ContraseniatextBox.Size = new System.Drawing.Size(159, 20);
            this.ContraseniatextBox.TabIndex = 13;
            this.ContraseniatextBox.TextChanged += new System.EventHandler(this.ContraseniatextBox_TextChanged);
            this.ContraseniatextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ContraseniatextBox_Validating);
            // 
            // ContraseniaNuevatextBox
            // 
            this.ContraseniaNuevatextBox.Location = new System.Drawing.Point(198, 315);
            this.ContraseniaNuevatextBox.Name = "ContraseniaNuevatextBox";
            this.ContraseniaNuevatextBox.Size = new System.Drawing.Size(148, 20);
            this.ContraseniaNuevatextBox.TabIndex = 14;
            this.ContraseniaNuevatextBox.TextChanged += new System.EventHandler(this.ContraseniaNuevatextBox_TextChanged);
            this.ContraseniaNuevatextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ContraseniaNuevatextBox_Validating);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(438, 207);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(126, 50);
            this.Aceptarbutton.TabIndex = 15;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Volverbutton
            // 
            this.Volverbutton.Location = new System.Drawing.Point(438, 315);
            this.Volverbutton.Name = "Volverbutton";
            this.Volverbutton.Size = new System.Drawing.Size(126, 50);
            this.Volverbutton.TabIndex = 16;
            this.Volverbutton.Text = "Volver";
            this.Volverbutton.UseVisualStyleBackColor = true;
            this.Volverbutton.Click += new System.EventHandler(this.Volverbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Ver_button
            // 
            this.Ver_button.Location = new System.Drawing.Point(357, 294);
            this.Ver_button.Name = "Ver_button";
            this.Ver_button.Size = new System.Drawing.Size(42, 21);
            this.Ver_button.TabIndex = 17;
            this.Ver_button.Text = "Ver";
            this.Ver_button.UseVisualStyleBackColor = true;
            this.Ver_button.Click += new System.EventHandler(this.Ver_button_Click);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 415);
            this.Controls.Add(this.Ver_button);
            this.Controls.Add(this.Volverbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.ContraseniaNuevatextBox);
            this.Controls.Add(this.ContraseniatextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.DNImaskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificar";
            this.Text = "Resetear Contraseña";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ActivocheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox DNImaskedTextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox ContraseniatextBox;
        private System.Windows.Forms.TextBox ContraseniaNuevatextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Volverbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Ver_button;
    }
}