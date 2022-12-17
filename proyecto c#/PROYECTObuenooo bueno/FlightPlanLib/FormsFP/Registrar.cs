using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsFP
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrado = true;
            this.usuario = user.Text;
            this.password = pwd.Text;
            Close();
        }

        bool registrado = false;
        string usuario;
        string password;

        public bool reg()
        {
            return this.registrado;
        }
        public string TomaUsuario()
        {
            return this.usuario;
        }
        public string Tomapassword()
        {
            return this.password;
        }
    }
}
