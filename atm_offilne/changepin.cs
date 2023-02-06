using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class changepin : Form
    {
        public changepin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void btchangepin_Click(object sender, EventArgs e)
        {
            if (tbnewpin.Text == "" || tbconfirmpin.Text == "")
            {
                MessageBox.Show("Enter new pin and confirm pin", "Failed Change Pin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbconfirmpin.Text != tbnewpin.Text)
            {
                MessageBox.Show("New pin and confirm pin is different", "Failed Change Pin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update AccountTbl set pin ='" + tbnewpin.Text + "' where acc_num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Change PIN Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Login home = new Login();
                    home.Show();
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
            this.Close();
            home home = new home();
            home.Show();
        }
    }
}
