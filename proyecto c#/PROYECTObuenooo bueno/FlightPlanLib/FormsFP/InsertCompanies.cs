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
    public partial class InsertCompanies : Form
    {
        public InsertCompanies()
        {
            InitializeComponent();
        }
        string name;
        string email;
        string telefono;
        bool aceptar = false;


        private void pressinsert_Click(object sender, EventArgs e)
        {
            this.name = namecomp.Text;
            this.email = emailtext.Text;
            this.telefono = telefonotextbox.Text;
            this.aceptar = true;
            Close();
        }

        public bool returnaceptar() {
            return this.aceptar;
        }

        public string TomaName() {
            return this.name;
        }
        public string Tomatelf() {
            return this.telefono;
            
        }

        public string Tomaemail() {
            return this.email;
        }
    }
}
