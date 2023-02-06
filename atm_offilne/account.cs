using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btregister_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if (tbaccnum.Text == "" || tbname.Text == "" || tbfname.Text == "" || tbphone.Text == "" || tbaddress.Text == "" || tboccupation.Text == "" || tbpin.Text == "")
            {
                MessageBox.Show("Data is empty\nPlease insert your data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into AccountTbl values('" + tbaccnum.Text + "', '" + tbname.Text + "','" + tbfname.Text + "','" + dtpdob.Value.Date + "','" + tbphone.Text + "','" + tbaddress.Text + "', '" + cbeducation.SelectedItem.ToString() + "','" + tboccupation.Text + "','" + tbpin.Text + "','" + balance + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
