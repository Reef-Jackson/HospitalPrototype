using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Hospital
{
    internal class PatientLoader
    {
        private readonly SQLiteConnection conn;
        public PatientLoader(string connectionString)
        {
            conn = new SQLiteConnection(connectionString);
        }

        public void LoadPatientNames(ListBox lbPatientNames)
        {
            lbPatientNames.Items.Clear();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select patient_name from patients", conn);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lbPatientNames.Items.Add(dr["patient_name"]);
            }
        }
    }

    internal class DataGridFill
    {
        public void FillDataGridView(DataGridView dgv, string connectionString)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * from janet_info";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                dgv.DataSource = dt;

                conn.Close();
            }
        }
    }


}