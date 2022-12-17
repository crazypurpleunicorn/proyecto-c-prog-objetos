using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlightPlanLib;

namespace FormsFP
{
    public partial class Tiempo_y_distancia : Form
    {
        public Tiempo_y_distancia()
        {
            InitializeComponent();
        }
        double tiempo;
        double seg;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                seg = (Convert.ToDouble(dsbox.Text));
                tiempo=(Convert.ToDouble(tcbox.Text));
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error al introducir datos");
            }
            
        }

        public double returntiempo() {
            return tiempo;
        }

        public double returnseg()
        {
            return seg;
        }

        private void Predeterminado_Click(object sender, EventArgs e)
        {
            this.dsbox.Text = "20";
            this.tcbox.Text = "10";
        }
    }
}
