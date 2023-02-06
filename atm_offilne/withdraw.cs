using System.Data;
using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = Login.AccNumber;
        int bal;

        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + tbamount.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetBalance()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select balance from AccountTbl where acc_num='" + acc + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblavailanlebalance.Text = "Balance : Rp. " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void withdraw_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        int newbalance;
        private void btwithdraw_Click(object sender, EventArgs e)
        {
            if (tbamount.Text == "")
            {
                MessageBox.Show("Please enter amount", "Failed Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(tbamount.Text) <= 0)
            {
                MessageBox.Show("Please enter amount", "Failed Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(tbamount.Text) > bal)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(tbamount.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        addtransaction();
                        home home = new home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
