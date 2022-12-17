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
    public partial class Distanciasaviones : Form
    {
        public Distanciasaviones()
        {
            InitializeComponent();
        }

        ListaFlightPlan lista = new ListaFlightPlan();
        int avion_id;

        public void Tomalista(ListaFlightPlan z)
        {
            this.lista = z;
        }
        public void Tomaindex(int index)
        {
            this.avion_id = index;
        }

        private void Distanciasaviones_Load(object sender, EventArgs e)
        {
            try
            {
                if (lista.DameNum() > 0)
                {
                    id.Text = lista.Dame(this.avion_id).GetID();
                    distancias.RowCount = 2;
                    distancias.RowHeadersVisible = false;
                    distancias.ColumnHeadersVisible = false;


                    distancias.ColumnCount = lista.DameNum();

                    distancias.Rows[0].Cells[0].Value = "ID";
                    distancias.Rows[1].Cells[0].Value = "Distancia";
                    int cont = distancias.RowCount - 1; ;
                    for (int i = 0; i < lista.DameNum() && cont >= 0; i++)
                    {

                        if (this.avion_id != i)
                        {
                            distancias.Rows[0].Cells[distancias.RowCount  - cont].Value = lista.Dame(i).GetID();
                            
                            distancias.Rows[1].Cells[distancias.RowCount  - cont].Value = Convert.ToInt32(lista.Dame(i).distancia(lista.Dame(this.avion_id)));
                            cont--;
                        }

                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
