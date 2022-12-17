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
    public partial class Datosavion : Form
    {
        public Datosavion()
        {
            InitializeComponent();
        }
        ListaFlightPlan miLista = new ListaFlightPlan();
        int posicion;
        public void TomaLista(ListaFlightPlan lista)
        {
            this.miLista = lista;
        }

        public void Tomaposicion(int z)
        {
            this.posicion = z;

        }
        private void Datosavion_Load(object sender, EventArgs e)
        {
            vel.Text = Convert.ToString(miLista.Dame(posicion).GetVelocidad());
            id.Text = miLista.Dame(posicion).GetID();
            xi.Text = Convert.ToString(miLista.Dame(posicion).GetXorigen());
            yi.Text = Convert.ToString(miLista.Dame(posicion).GetYorigen());
            x.Text = Convert.ToString(Convert.ToInt32(miLista.Dame(posicion).GetIX()));
            y.Text = Convert.ToString(Convert.ToInt32(miLista.Dame(posicion).GetIY()));
            xf.Text = Convert.ToString(miLista.Dame(posicion).GetFX());
            yf.Text = Convert.ToString(miLista.Dame(posicion).GetFY());
        }
    }
}
