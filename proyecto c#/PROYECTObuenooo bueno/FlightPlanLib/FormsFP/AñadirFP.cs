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
    public partial class AñadirFP : Form
    {
        FlightPlan FP = new FlightPlan();
        ListaFlightPlan listaFP = new ListaFlightPlan();
        bool nuevo = false;
        public AñadirFP()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            try
            {
                FP.SetID(idbox.Text);
                FP.SetCompañia(compbox.Text);
                FP.SetVelocidad(Convert.ToDouble(velbox.Text));
                FP.SetIX(Convert.ToDouble(XIbox.Text));
                FP.SetIY(Convert.ToDouble(YIbox.Text));
                FP.SetFX(Convert.ToDouble(XFbox.Text));
                FP.SetFY(Convert.ToDouble(YFbox.Text));

                FP.SetXorigen(Convert.ToDouble(XIbox.Text));
                FP.SetYorigen(Convert.ToDouble(YIbox.Text));
            }
            catch (Exception es) {
                MessageBox.Show(es.Message);
            }
            Close();

        }

        public FlightPlan DameFP()
        {
            return (this.FP);
        }
        

        private void p1_Click(object sender, EventArgs e)
        {
            this.idbox.Text = "B747";
            this.compbox.Text = "Boeing";
            this.velbox.Text = "50";
            this.XIbox.Text = "50";
            this.YIbox.Text = "50";
            this.XFbox.Text = "400";
            this.YFbox.Text = "400";


        }

        private void p2_Click(object sender, EventArgs e)
        {
            this.idbox.Text = "A380";
            this.compbox.Text = "Airbus";
            this.velbox.Text = "50";
            this.XIbox.Text = "400";
            this.YIbox.Text = "50";
            this.XFbox.Text = "50";
            this.YFbox.Text = "400";
        }

        public bool aceptar() {
            return nuevo;
        }

        
    }
}
