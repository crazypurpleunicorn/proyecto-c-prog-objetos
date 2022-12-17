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
    public partial class CargarArchivo : Form
    {
        public CargarArchivo()
        {
            InitializeComponent();
        }
        string fichero;
        bool ok = false;

        public string getfichero()
        {
            return this.fichero;
        }

        public bool returnaceptar() {
            return this.ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fichero = textBox1.Text;
            this.ok = true;
            Close();
        }

        private void CargarArchivo_Load(object sender, EventArgs e)
        {

        }
    }
}
