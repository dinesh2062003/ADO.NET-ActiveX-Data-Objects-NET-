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
    public partial class withdraw : Form
    {
        private string q = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CCC;Integrated Security=True;Encrypt=False;";
        public withdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string accountNumber = textBox2.Text;
                int withdrawAmount = int.Parse(textBox1.Text);

                SqlConnection conn = new SqlConnection(q);
                conn.Open();



                string q1 = "SELECT Balance FROM coun WHERE AccountNumber = @AccountNumber";
                SqlCommand Cmd = new SqlCommand(q1, conn);
                Cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                int currentBalance = (int)Cmd.ExecuteScalar();
                
                if (currentBalance >= withdrawAmount)
                {

                    string withdrawQuery = "UPDATE coun SET Balance = Balance - @WithdrawAmount WHERE AccountNumber = @AccountNumber";
                    SqlCommand withdrawCmd = new SqlCommand(withdrawQuery, conn);

                    withdrawCmd.Parameters.AddWithValue("@WithdrawAmount", withdrawAmount);
                    withdrawCmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    withdrawCmd.ExecuteNonQuery();

                    MessageBox.Show("Withdrawal successful!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Insufficient balance.");
                }
               
            }
            
            catch (InvalidOperationException)
            {
                MessageBox.Show("Connection error: ");
            }
            


        }

    }
}
    
