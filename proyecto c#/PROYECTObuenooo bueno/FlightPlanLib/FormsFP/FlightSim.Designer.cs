namespace FormsFP
{
    partial class FlightSim
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
            this.Mapa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mover = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarVelocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adquirirNaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Automatico = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reiniciar = new System.Windows.Forms.Button();
            this.retroceder = new System.Windows.Forms.Button();
            this.Silenciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mapa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mapa
            // 
            this.Mapa.BackgroundColor = System.Drawing.Color.Black;
            this.Mapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mapa.Location = new System.Drawing.Point(272, 39);
            this.Mapa.Name = "Mapa";
            this.Mapa.Size = new System.Drawing.Size(799, 499);
            this.Mapa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1047, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "799";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "499";
            // 
            // Mover
            // 
            this.Mover.Location = new System.Drawing.Point(10, 102);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(75, 23);
            this.Mover.TabIndex = 5;
            this.Mover.Text = "Mover";
            this.Mover.UseVisualStyleBackColor = true;
            this.Mover.Click += new System.EventHandler(this.Mover_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 26);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosVueloToolStripMenuItem,
            this.cambiarVelocidadToolStripMenuItem,
            this.guardarPartidaToolStripMenuItem,
            this.cargarPartidaToolStripMenuItem,
            this.adquirirNaveToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // datosVueloToolStripMenuItem
            // 
            this.datosVueloToolStripMenuItem.Name = "datosVueloToolStripMenuItem";
            this.datosVueloToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.datosVueloToolStripMenuItem.Text = "Datos de vuelo";
            this.datosVueloToolStripMenuItem.Click += new System.EventHandler(this.datosVueloToolStripMenuItem_Click);
            // 
            // cambiarVelocidadToolStripMenuItem
            // 
            this.cambiarVelocidadToolStripMenuItem.Name = "cambiarVelocidadToolStripMenuItem";
            this.cambiarVelocidadToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cambiarVelocidadToolStripMenuItem.Text = "Cambiar velocidad";
            this.cambiarVelocidadToolStripMenuItem.Click += new System.EventHandler(this.cambiarVelocidadToolStripMenuItem_Click);
            // 
            // guardarPartidaToolStripMenuItem
            // 
            this.guardarPartidaToolStripMenuItem.Name = "guardarPartidaToolStripMenuItem";
            this.guardarPartidaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.guardarPartidaToolStripMenuItem.Text = "Guardar partida";
            this.guardarPartidaToolStripMenuItem.Click += new System.EventHandler(this.guardarPartidaToolStripMenuItem_Click);
            // 
            // cargarPartidaToolStripMenuItem
            // 
            this.cargarPartidaToolStripMenuItem.Name = "cargarPartidaToolStripMenuItem";
            this.cargarPartidaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cargarPartidaToolStripMenuItem.Text = "Cargar partida";
            this.cargarPartidaToolStripMenuItem.Click += new System.EventHandler(this.cargarPartidaToolStripMenuItem_Click);
            // 
            // adquirirNaveToolStripMenuItem
            // 
            this.adquirirNaveToolStripMenuItem.Name = "adquirirNaveToolStripMenuItem";
            this.adquirirNaveToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.adquirirNaveToolStripMenuItem.Text = "Adquirir nave";
            this.adquirirNaveToolStripMenuItem.Click += new System.EventHandler(this.adquirirNaveToolStripMenuItem_Click);
            // 
            // Automatico
            // 
            this.Automatico.Location = new System.Drawing.Point(171, 102);
            this.Automatico.Name = "Automatico";
            this.Automatico.Size = new System.Drawing.Size(75, 23);
            this.Automatico.TabIndex = 14;
            this.Automatico.Text = "Automático";
            this.Automatico.UseVisualStyleBackColor = true;
            this.Automatico.Click += new System.EventHandler(this.Automatico_Click);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(171, 139);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(75, 23);
            this.Parar.TabIndex = 15;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reiniciar
            // 
            this.Reiniciar.Location = new System.Drawing.Point(88, 258);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.Reiniciar.TabIndex = 16;
            this.Reiniciar.Text = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // retroceder
            // 
            this.retroceder.Location = new System.Drawing.Point(88, 209);
            this.retroceder.Name = "retroceder";
            this.retroceder.Size = new System.Drawing.Size(75, 23);
            this.retroceder.TabIndex = 17;
            this.retroceder.Text = "Retroceder";
            this.retroceder.UseVisualStyleBackColor = true;
            this.retroceder.Click += new System.EventHandler(this.retroceder_Click);
            // 
            // Silenciar
            // 
            this.Silenciar.AutoSize = true;
            this.Silenciar.Location = new System.Drawing.Point(88, 386);
            this.Silenciar.Name = "Silenciar";
            this.Silenciar.Size = new System.Drawing.Size(93, 23);
            this.Silenciar.TabIndex = 18;
            this.Silenciar.Text = "Musica: Off";
            this.Silenciar.UseVisualStyleBackColor = true;
            this.Silenciar.Click += new System.EventHandler(this.Silenciar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FlightSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Silenciar);
            this.Controls.Add(this.retroceder);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Automatico);
            this.Controls.Add(this.Mover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlightSim";
            this.Text = "FlightSim";
            this.Load += new System.EventHandler(this.FlightSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mapa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Mapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Mover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.Button Automatico;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.ToolStripMenuItem datosVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarVelocidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPartidaToolStripMenuItem;
        private System.Windows.Forms.Button retroceder;
        private System.Windows.Forms.Button Silenciar;
        private System.Windows.Forms.ToolStripMenuItem adquirirNaveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}