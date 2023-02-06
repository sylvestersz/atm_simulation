namespace atm_offilne
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login lobin = new Login();
            lobin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deposit depo = new deposit();
            depo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            withdraw widraw = new withdraw();
            widraw.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fastcash fast = new fastcash();
            fast.Show();
            this.Hide();
        }
        //menampilkan accountnumber di form balance #2
        public static String AccountNumber;
        //

        private void home_Load(object sender, EventArgs e)
        {
            //mengambil account number dari form login #1
            lblaccnumber.Text = "Account Number : " + Login.AccNumber;
            //
            //mengambil nilai account number dari form login#2
            AccountNumber = Login.AccNumber;
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            balance balance = new balance();
            balance.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changepin changepin = new changepin();
            changepin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ministatement ministatement = new ministatement();
            ministatement.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
