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
    public partial class Cambio_velocidad : Form
    {
        public Cambio_velocidad()
        {
            InitializeComponent();
        }

        ListaFlightPlan milistaFP = new ListaFlightPlan();

        public void SetLista(ListaFlightPlan lista)
        {
            this.milistaFP = lista;
        }

        private void Cambio_velocidad_Load(object sender, EventArgs e)
        {
            Tabla.RowCount = milistaFP.DameNum() + 1;
            Tabla.ColumnCount = 2;
            Tabla.Rows[0].Cells[0].Value = "ID";
            Tabla.Rows[0].Cells[1].Value = "Velocidad";
            

            for (int i = 1; i < milistaFP.DameNum() + 1; i++)
            {
                Tabla.Rows[i].Cells[0].Value = milistaFP.Dame(i - 1).GetID();
                Tabla.Rows[i].Cells[1].Value = milistaFP.Dame(i - 1).GetVelocidad();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < milistaFP.DameNum(); i++)
                {
                    milistaFP.Dame(i).SetVelocidad(Convert.ToDouble(Tabla.Rows[i + 1].Cells[1].Value));
                }
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error al introducir datos");
            }
        }

        public ListaFlightPlan cambiadas() {
            return this.milistaFP;
        }

        
    }
}
