using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace cr7
{
    public partial class CREATE : Form
    {
       
        public CREATE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CCC;Integrated Security=True;";
            string a = textBox1.Text;
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            string i = "INSERT INTO coun (Name, AccountNumber, Balance) VALUES (@Name, @AccountNumber, @Balance)";

            SqlConnection c1 = new SqlConnection(q);
            c1.Open();


            try
             {
               
                SqlCommand command = new SqlCommand(i, c1);
                

                    command.Parameters.AddWithValue("@Name", a);
                    command.Parameters.AddWithValue("@AccountNumber", b);
                    command.Parameters.AddWithValue("@Balance", c);


                    command.ExecuteNonQuery();
                


                MessageBox.Show("Account created successfully!");
             }
            catch (FormatException)
            {

                MessageBox.Show("re-enter in correct format");
            }
            c1.Close();
        }
            
    }
}
