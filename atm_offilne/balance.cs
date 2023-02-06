using System.Data;
using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }

        //mengambil value balance dari database #3
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetBalance()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select balance from AccountTbl where acc_num='" + lblaccnum.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lblbalance.Text = "Rp. " + dt.Rows[0][0].ToString();
            con.Close();
        }
        //

        private void balance_Load(object sender, EventArgs e)
        {
            //mengambil nilai account number dari form home #2
            lblaccnum.Text = home.AccountNumber;
            //
            //memanggil function GetBalance() diatas #3
            GetBalance();
            //
        }

        private void label4_Click(object sender, EventArgs e)
        {
            home hums = new home();
            hums.Show();
            this.Hide();
        }
    }
}
