using System.Data;
using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class fastcash : Form
    {
        public fastcash()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = Login.AccNumber;
        int bal;
        int amt50 = 50000, amt100 = 100000, amt200 = 200000, amt30 = 300000, amt1000 = 1000000, amt10000 = 10000000;

        private void addtransaction1()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + 50000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction2()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + 100000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction3()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + 200000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction4()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + 300000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction5()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + 1000000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction6()
        {
            string TrType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + acc + "', '" + TrType + "','" + 10000000 + "','" + DateTime.Today.Date.ToString() + "')";
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
            lblbalance.Text = "Balance Rp. " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void fastcash_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void tb50_Click(object sender, EventArgs e)
        {
            if (bal < 50000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                int newbalance = bal - 50000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    addtransaction1();
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb100_Click(object sender, EventArgs e)
        {
            if (bal < 100000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                int newbalance = bal - 100000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    addtransaction2();
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb200_Click(object sender, EventArgs e)
        {
            if (bal < 200000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                int newbalance = bal - 200000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    addtransaction3();
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb300_Click(object sender, EventArgs e)
        {
            if (bal < 300000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                int newbalance = bal - 300000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    addtransaction4();
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb1000_Click(object sender, EventArgs e)
        {
            if (bal < 1000000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                int newbalance = bal - 1000000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    addtransaction5();
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb10000_Click(object sender, EventArgs e)
        {
            if (bal < 10000000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                int newbalance = bal - 10000000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    addtransaction6();
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
