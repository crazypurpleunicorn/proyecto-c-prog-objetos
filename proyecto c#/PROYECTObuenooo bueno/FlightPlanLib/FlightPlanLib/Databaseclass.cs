using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace FlightPlanLib
{
    public class Databaseclass
    {
        OleDbConnection cnx;

        public void OpenDatabase()
        {
            string nombre = "Database.sdf";
            string cnxStr = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5; Data Source=" + nombre + ";Persist Security Info=False";
            this.cnx = new OleDbConnection(cnxStr);
            this.cnx.Open();
        }

        public void CloseDatabase()
        {
            this.cnx.Close();

        }

        public DataTable Datatable()
        {
            DataTable res = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * FROM Login", cnx);
            adp.Fill(res);
            return res;
        }

        public int Insert(string a, string b)
        {
            string query = "insert into Login values ('" + a + "','" + b + "')";
            OleDbCommand comand = new OleDbCommand(query, cnx);
            int resultado = comand.ExecuteNonQuery();
            return resultado;
        }
        public DataTable Datatablecompanies()
        {
            DataTable res = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * FROM DataTableCompanies", cnx);
            adp.Fill(res);
            return res;

        }

        public DataTable Telefonoemail(string a)
        {
            DataTable res = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * FROM DataTableCompanies where Name= '" + a + "'", cnx);
            adp.Fill(res);
            return res;
        }


        public int Insertcompanie(string a, string b, string c)
        {
            string query = "insert into DataTableCompanies values ('" + a + "','" + b + "','" + c + "')";
            OleDbCommand comand = new OleDbCommand(query, cnx);
            int resultado = comand.ExecuteNonQuery();
            return resultado;

        }

        public int removecompanie(string a)
        {
            string operacion = "delete from DataTableCompanies where Name = '" + a + "'";
            OleDbCommand command = new OleDbCommand(operacion, cnx);
            int res = command.ExecuteNonQuery();
            return res;
        }
    }

}

    

