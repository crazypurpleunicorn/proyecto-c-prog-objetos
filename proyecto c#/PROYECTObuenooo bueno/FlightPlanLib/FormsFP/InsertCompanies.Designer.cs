namespace MisFormularios
{
    partial class InsertCompanies
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
            this.namecomp = new System.Windows.Forms.TextBox();
            this.telefonotextbox = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pressinsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namecomp
            // 
            this.namecomp.Location = new System.Drawing.Point(12, 74);
            this.namecomp.Name = "namecomp";
            this.namecomp.Size = new System.Drawing.Size(100, 22);
            this.namecomp.TabIndex = 0;
            // 
            // telefonotextbox
            // 
            this.telefonotextbox.Location = new System.Drawing.Point(188, 74);
            this.telefonotextbox.Name = "telefonotextbox";
            this.telefonotextbox.Size = new System.Drawing.Size(100, 22);
            this.telefonotextbox.TabIndex = 1;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(357, 74);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(100, 22);
            this.emailtext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(210, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(387, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // pressinsert
            // 
            this.pressinsert.Location = new System.Drawing.Point(201, 204);
            this.pressinsert.Name = "pressinsert";
            this.pressinsert.Size = new System.Drawing.Size(75, 23);
            this.pressinsert.TabIndex = 6;
            this.pressinsert.Text = "Añadir";
            this.pressinsert.UseVisualStyleBackColor = true;
            this.pressinsert.Click += new System.EventHandler(this.pressinsert_Click);
            // 
            // InsertCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 253);
            this.Controls.Add(this.pressinsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.telefonotextbox);
            this.Controls.Add(this.namecomp);
            this.Name = "InsertCompanies";
            this.Text = "InsertCompanies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namecomp;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pressinsert;
        private System.Windows.Forms.TextBox telefonotextbox;
    }
}