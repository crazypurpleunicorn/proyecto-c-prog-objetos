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
    public partial class CambioAutomaticodeVelocidad : Form
    {
        bool Si = false;
        ListaFlightPlan concambios = new ListaFlightPlan();
        List<double> velocidadescambiadas = new List<double>();

        public CambioAutomaticodeVelocidad()
        {
            InitializeComponent();
        }

        public void Concambios(ListaFlightPlan a) {
            this.concambios = a;
        }

        public void Sincambios(List<double> b)
        {
            this.velocidadescambiadas = b;
        }

        private void si_Click(object sender, EventArgs e)
        {
            Si = true;
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool Cambiar()
        {
            return Si;
        }

        private void CambioAutomaticodeVelocidad_Load(object sender, EventArgs e)
        {
            try
            {
                if (concambios.DameNum() > 0)
                {
                    cambiosvel.RowCount = concambios.DameNum() + 1;
                    cambiosvel.RowHeadersVisible = false;
                    cambiosvel.ColumnHeadersVisible = false;


                    cambiosvel.ColumnCount = 3;

                    cambiosvel.Rows[0].Cells[0].Value = "ID";
                    cambiosvel.Rows[0].Cells[1].Value = "Velocidad(después)";
                    cambiosvel.Rows[0].Cells[2].Value = "Velocidad(antes)";


                    for (int i = 1; i < concambios.DameNum() + 1; i++)
                    {
                        cambiosvel.Rows[i].Cells[0].Value = concambios.Dame(i - 1).GetID();
                        cambiosvel.Rows[i].Cells[1].Value = Convert.ToInt32(this.concambios.Dame(i - 1).GetVelocidad());
                        cambiosvel.Rows[i].Cells[2].Value = Convert.ToInt32(this.velocidadescambiadas[i - 1]);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
