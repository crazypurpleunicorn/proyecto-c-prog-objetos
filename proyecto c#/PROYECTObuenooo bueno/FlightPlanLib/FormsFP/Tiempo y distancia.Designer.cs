namespace FormsFP
{
    partial class Tiempo_y_distancia
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcbox = new System.Windows.Forms.TextBox();
            this.dsbox = new System.Windows.Forms.TextBox();
            this.Predeterminado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo de ciclo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distancia de seguridad";
            // 
            // tcbox
            // 
            this.tcbox.Location = new System.Drawing.Point(156, 57);
            this.tcbox.Name = "tcbox";
            this.tcbox.Size = new System.Drawing.Size(100, 20);
            this.tcbox.TabIndex = 3;
            // 
            // dsbox
            // 
            this.dsbox.Location = new System.Drawing.Point(156, 132);
            this.dsbox.Name = "dsbox";
            this.dsbox.Size = new System.Drawing.Size(100, 20);
            this.dsbox.TabIndex = 4;
            // 
            // Predeterminado
            // 
            this.Predeterminado.AutoSize = true;
            this.Predeterminado.Location = new System.Drawing.Point(15, 226);
            this.Predeterminado.Name = "Predeterminado";
            this.Predeterminado.Size = new System.Drawing.Size(91, 23);
            this.Predeterminado.TabIndex = 5;
            this.Predeterminado.Text = "Predeterminado\r\n";
            this.Predeterminado.UseVisualStyleBackColor = true;
            this.Predeterminado.Click += new System.EventHandler(this.Predeterminado_Click);
            // 
            // Tiempo_y_distancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Predeterminado);
            this.Controls.Add(this.dsbox);
            this.Controls.Add(this.tcbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Tiempo_y_distancia";
            this.Text = "Tiempo_y_distancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcbox;
        private System.Windows.Forms.TextBox dsbox;
        private System.Windows.Forms.Button Predeterminado;
    }
}