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
    public partial class Compañiasver : Form
    {
        public Compañiasver()
        {
            InitializeComponent();
        }
        Databaseclass dbase = new Databaseclass();
        private void Compañiasver_Load(object sender, EventArgs e)
        {
            try
            {
                dbase.OpenDatabase();
                DataTable res = dbase.Datatablecompanies();
                dataGridView1.RowCount = res.Rows.Count+1;
                dataGridView1.ColumnCount = res.Columns.Count;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersVisible = false;
                

                dataGridView1.Rows[0].Cells[0].Value = "Compañia";
                dataGridView1.Rows[0].Cells[1].Value = "Telefono";
                dataGridView1.Rows[0].Cells[2].Value = "E-mail";
                int cont = 1;
                while (cont < res.Rows.Count+1) {
                    dataGridView1.Rows[cont].Cells[0].Value = Convert.ToString(res.Rows[cont-1]["Companies"]);
                    dataGridView1.Rows[cont].Cells[1].Value = Convert.ToString(res.Rows[cont-1]["Tlf"]);
                    dataGridView1.Rows[cont].Cells[2].Value = Convert.ToString(res.Rows[cont-1]["Mail"]);
                    cont++;
                
                }
                dbase.CloseDatabase();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertCompanies form = new InsertCompanies();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eliminarcompanies form = new Eliminarcompanies();
            form.ShowDialog();
        }
    }
}
