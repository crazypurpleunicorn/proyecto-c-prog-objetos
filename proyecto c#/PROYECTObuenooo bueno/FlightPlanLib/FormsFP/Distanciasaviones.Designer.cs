namespace FormsFP
{
    partial class Distanciasaviones
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
            this.title = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.distancias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.distancias)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title.Location = new System.Drawing.Point(192, 64);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(239, 19);
            this.title.TabIndex = 22;
            this.title.Text = "Distancias respecto al avión con ID: ";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.id.Location = new System.Drawing.Point(481, 64);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 19);
            this.id.TabIndex = 21;
            this.id.Text = "?";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(348, 361);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 20;
            this.close.Text = "Cerrar";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // distancias
            // 
            this.distancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distancias.Location = new System.Drawing.Point(27, 117);
            this.distancias.Name = "distancias";
            this.distancias.RowTemplate.Height = 24;
            this.distancias.Size = new System.Drawing.Size(733, 225);
            this.distancias.TabIndex = 19;
            // 
            // Distanciasaviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 448);
            this.Controls.Add(this.title);
            this.Controls.Add(this.id);
            this.Controls.Add(this.close);
            this.Controls.Add(this.distancias);
            this.Name = "Distanciasaviones";
            this.Text = "Distanciasaviones";
            this.Load += new System.EventHandler(this.Distanciasaviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView distancias;
    }
}