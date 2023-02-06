using System.Data;
using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;

        //membuat history #4
        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "','" + tbamount.Text + "','" + DateTime.Today.Date.ToString() + "')";
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
        //
        private void tbdeposit_Click(object sender, EventArgs e)
        {
            if (tbamount.Text == "" || int.Parse(tbamount.Text) <= 0)
            {
                MessageBox.Show("Enter the amount to deposit", "Empty Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(tbamount.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTbl set balance ='" + newbalance + "' where acc_num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    //memanggil fungsi history #4
                    addtransaction();
                    //
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

        int oldbalance, newbalance;

        private void deposit_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            home home = new home();
            home.Show();
        }

        private void GetBalance()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select balance from AccountTbl where acc_num='" + Acc + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
    }
}
