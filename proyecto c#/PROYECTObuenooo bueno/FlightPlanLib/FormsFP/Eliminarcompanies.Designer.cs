namespace MisFormularios
{
    partial class Eliminarcompanies
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
            this.presseliminate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namecomp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // presseliminate
            // 
            this.presseliminate.Location = new System.Drawing.Point(79, 163);
            this.presseliminate.Name = "presseliminate";
            this.presseliminate.Size = new System.Drawing.Size(75, 23);
            this.presseliminate.TabIndex = 9;
            this.presseliminate.Text = "Eliminar";
            this.presseliminate.UseVisualStyleBackColor = true;
            this.presseliminate.Click += new System.EventHandler(this.presseliminate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(94, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // namecomp
            // 
            this.namecomp.Location = new System.Drawing.Point(71, 60);
            this.namecomp.Name = "namecomp";
            this.namecomp.Size = new System.Drawing.Size(100, 22);
            this.namecomp.TabIndex = 7;
            // 
            // Eliminarcompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 209);
            this.Controls.Add(this.presseliminate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namecomp);
            this.Name = "Eliminarcompanies";
            this.Text = "Eliminarcompanies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button presseliminate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namecomp;
    }
}