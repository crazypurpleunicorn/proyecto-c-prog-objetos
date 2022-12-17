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
    public partial class DatosdeVuelo : Form
    {
        ListaFlightPlan milistaFP = new ListaFlightPlan();
        public DatosdeVuelo()
        {
            InitializeComponent();
        }

        public void SetLista(ListaFlightPlan lista)
        {
            this.milistaFP = lista;
        }

        private void DatosVuelo_Load(object sender, EventArgs e)
        {
            Tabla.RowCount = milistaFP.DameNum()+1;
            Tabla.ColumnCount = 9;
            Tabla.Rows[0].Cells[0].Value = "ID";
            Tabla.Rows[0].Cells[1].Value = "Compañia";
            Tabla.Rows[0].Cells[2].Value = "Velocidad";
            Tabla.Rows[0].Cells[3].Value = "Xi";
            Tabla.Rows[0].Cells[4].Value = "Yi";
            Tabla.Rows[0].Cells[5].Value = "X";
            Tabla.Rows[0].Cells[6].Value = "Y";
            Tabla.Rows[0].Cells[7].Value = "Xf";
            Tabla.Rows[0].Cells[8].Value = "Yf";

            for (int i = 1; i < milistaFP.DameNum()+1; i++)
            {
                Tabla.Rows[i].Cells[0].Value = milistaFP.Dame(i-1).GetID();
                Tabla.Rows[i].Cells[1].Value = milistaFP.Dame(i-1).GetCompañia();
                Tabla.Rows[i].Cells[2].Value = milistaFP.Dame(i-1).GetVelocidad();
                Tabla.Rows[i].Cells[3].Value = milistaFP.Dame(i-1).GetXorigen();
                Tabla.Rows[i].Cells[4].Value = milistaFP.Dame(i-1).GetYorigen();
                Tabla.Rows[i].Cells[5].Value = Convert.ToInt32(milistaFP.Dame(i-1).GetIX());
                Tabla.Rows[i].Cells[6].Value = Convert.ToInt32(milistaFP.Dame(i-1).GetIY());
                Tabla.Rows[i].Cells[7].Value = milistaFP.Dame(i-1).GetFX();
                Tabla.Rows[i].Cells[8].Value = milistaFP.Dame(i-1).GetFY();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void Tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex - 1;
            Distanciasaviones form = new Distanciasaviones();
            form.Tomalista(this.milistaFP);
            form.Tomaindex(index);
            form.ShowDialog();
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        


    }
}
