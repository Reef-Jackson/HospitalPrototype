using System.Data;
using System.Data.SQLite;    

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public string dir = "Data Source = C:\\Users\\reefl\\Desktop\\HospitalPrototype - Copy(2)\\Hospital\\database.db";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(dir); 
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT COUNT(*) FROM users WHERE user_email='" + tbEmail.Text + "' AND user_pass='" + tbPass.Text + "'", conn);
            
            DataTable dt = new DataTable();   
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Main obj = new Main();
                obj.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Invalid Login"); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != "" && tbPass.Text "")
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else { MessageBox.Show("Error, invalid information."); }
        } 
    }
}