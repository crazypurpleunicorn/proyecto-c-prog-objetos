using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanLib;

namespace MisFormularios
{
    public partial class Eliminarcompanies : Form
    {
        public Eliminarcompanies()
        {
            InitializeComponent();
        }
        bool aceptar = false;
        string name;
        private void presseliminate_Click(object sender, EventArgs e)
        {
            this.aceptar = true;
            this.name = namecomp.Text;
            Close();
        }
        public bool returnaceptar() {
            return this.aceptar;
        }

        public string TomaName() {
            return this.name;

        }
    }
}
