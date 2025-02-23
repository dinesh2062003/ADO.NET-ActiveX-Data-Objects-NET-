using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace cr7
{
    public partial class bal : Form
    {
        string q = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CCC;Integrated Security=True;";
        public bal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            string a = textBox1.Text;
            SqlConnection conn = new SqlConnection(q);

            string query = "select Balance from coun WHERE AccountNumber = @AccountNumber";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@AccountNumber",a);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable balanceTable = new DataTable();
            balanceTable.Load(reader);
            dataGridView1.DataSource = balanceTable;
            
        }
    }
}
    

