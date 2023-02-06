using System.Data;
using System.Data.SqlClient;

namespace atm_offilne
{
    public partial class ministatement : Form
    {
        public ministatement()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\ATMdb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        private void populate()
        {
            con.Open();
            string query = "select * from TransactionTbl where acc_num ='" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ministatementDGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Show();
        }

        private void ministatement_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
