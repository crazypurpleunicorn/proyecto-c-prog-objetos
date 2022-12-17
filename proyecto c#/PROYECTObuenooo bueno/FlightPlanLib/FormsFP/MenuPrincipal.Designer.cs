namespace FormsFP
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFicheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPlanDeVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comenzarToolStripMenuItem
            // 
            this.comenzarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarFicheroToolStripMenuItem,
            this.agregarPlanDeVueloToolStripMenuItem,
            this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem,
            this.simularToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.comenzarToolStripMenuItem.Name = "comenzarToolStripMenuItem";
            this.comenzarToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.comenzarToolStripMenuItem.Text = "Comenzar";
            // 
            // cargarFicheroToolStripMenuItem
            // 
            this.cargarFicheroToolStripMenuItem.Name = "cargarFicheroToolStripMenuItem";
            this.cargarFicheroToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.cargarFicheroToolStripMenuItem.Text = "Cargar fichero";
            this.cargarFicheroToolStripMenuItem.Click += new System.EventHandler(this.cargarFicheroToolStripMenuItem_Click);
            // 
            // agregarPlanDeVueloToolStripMenuItem
            // 
            this.agregarPlanDeVueloToolStripMenuItem.Name = "agregarPlanDeVueloToolStripMenuItem";
            this.agregarPlanDeVueloToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.agregarPlanDeVueloToolStripMenuItem.Text = "Agregar plan de vuelo";
            this.agregarPlanDeVueloToolStripMenuItem.Click += new System.EventHandler(this.agregarPlanDeVueloToolStripMenuItem_Click);
            // 
            // agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem
            // 
            this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem.Name = "agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem";
            this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem.Text = "Agregar tiempo de ciclo y distancia de seguridad";
            this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem_Click);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Musica: Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPlanDeVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTiempoDeCicloYDistanciaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFicheroToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}