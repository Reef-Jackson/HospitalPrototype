using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Hospital
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source = C:\\Users\\reefl\\Desktop\\HospitalPrototype - Copy(2)\\Hospital\\database.db";

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridFill dataGridFill = new DataGridFill();
            dataGridFill.FillDataGridView(dgvPatientInfo, connectionString);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PatientLoader patientLoader = new PatientLoader(connectionString);
            patientLoader.LoadPatientNames(lbPatientNames);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
    }
}

