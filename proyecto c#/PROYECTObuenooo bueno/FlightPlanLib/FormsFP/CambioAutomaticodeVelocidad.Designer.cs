namespace FormsFP
{
    partial class CambioAutomaticodeVelocidad
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
            this.no = new System.Windows.Forms.Button();
            this.si = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cambiosvel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cambiosvel)).BeginInit();
            this.SuspendLayout();
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(301, 392);
            this.no.Margin = new System.Windows.Forms.Padding(4);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(100, 28);
            this.no.TabIndex = 0;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // si
            // 
            this.si.Location = new System.Drawing.Point(97, 392);
            this.si.Margin = new System.Windows.Forms.Padding(4);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(100, 28);
            this.si.TabIndex = 1;
            this.si.Text = "Si";
            this.si.UseVisualStyleBackColor = true;
            this.si.Click += new System.EventHandler(this.si_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Desea que el programa solucione \r\n  el conflicto automáticamente?\r\n";
            // 
            // cambiosvel
            // 
            this.cambiosvel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cambiosvel.Location = new System.Drawing.Point(12, 77);
            this.cambiosvel.Name = "cambiosvel";
            this.cambiosvel.RowTemplate.Height = 24;
            this.cambiosvel.Size = new System.Drawing.Size(478, 292);
            this.cambiosvel.TabIndex = 3;
            // 
            // CambioAutomaticodeVelocidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 445);
            this.Controls.Add(this.cambiosvel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.si);
            this.Controls.Add(this.no);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CambioAutomaticodeVelocidad";
            this.Text = "CambioAutomaticodeVelocidad";
            this.Load += new System.EventHandler(this.CambioAutomaticodeVelocidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cambiosvel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Button si;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cambiosvel;
    }
}