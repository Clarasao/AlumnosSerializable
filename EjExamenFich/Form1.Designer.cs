namespace EjExamenFich
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.alumnoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirAppToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.abrirToolStripMenuItem.Text = "Archivo";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click_1);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Crear";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Cerrar";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirAppToolStripMenuItem
            // 
            this.salirAppToolStripMenuItem.Name = "salirAppToolStripMenuItem";
            this.salirAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirAppToolStripMenuItem.Text = "Salir App";
            this.salirAppToolStripMenuItem.Click += new System.EventHandler(this.salirAppToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaToolStripMenuItem,
            this.consultaAlumnoToolStripMenuItem,
            this.modificarContraseñaToolStripMenuItem});
            this.alumnoToolStripMenuItem.Enabled = false;
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // darDeAltaToolStripMenuItem
            // 
            this.darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            this.darDeAltaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.darDeAltaToolStripMenuItem.Text = "Dar de alta";
            this.darDeAltaToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaToolStripMenuItem_Click);
            // 
            // consultaAlumnoToolStripMenuItem
            // 
            this.consultaAlumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem,
            this.comercioToolStripMenuItem,
            this.informaticaToolStripMenuItem});
            this.consultaAlumnoToolStripMenuItem.Name = "consultaAlumnoToolStripMenuItem";
            this.consultaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultaAlumnoToolStripMenuItem.Text = "Consulta Alumno";
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            this.administrativoToolStripMenuItem.Click += new System.EventHandler(this.administrativoToolStripMenuItem_Click);
            // 
            // comercioToolStripMenuItem
            // 
            this.comercioToolStripMenuItem.Name = "comercioToolStripMenuItem";
            this.comercioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comercioToolStripMenuItem.Text = "Comercio";
            this.comercioToolStripMenuItem.Click += new System.EventHandler(this.comercioToolStripMenuItem_Click);
            // 
            // informaticaToolStripMenuItem
            // 
            this.informaticaToolStripMenuItem.Name = "informaticaToolStripMenuItem";
            this.informaticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informaticaToolStripMenuItem.Text = "Informatica";
            this.informaticaToolStripMenuItem.Click += new System.EventHandler(this.informaticaToolStripMenuItem_Click);
            // 
            // modificarContraseñaToolStripMenuItem
            // 
            this.modificarContraseñaToolStripMenuItem.Name = "modificarContraseñaToolStripMenuItem";
            this.modificarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modificarContraseñaToolStripMenuItem.Text = "Modificar Contraseña";
            this.modificarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.modificarContraseñaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem;
    }
}

