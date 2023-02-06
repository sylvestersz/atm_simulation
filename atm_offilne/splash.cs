namespace atm_offilne
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            progressBar1.Value = starting;
            lblpercent.Text = starting + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Random random1 = new Random();
            this.saya.ForeColor = System.Drawing.Color.FromArgb(random1.Next(0, 256), random1.Next(0, 256), random1.Next(0, 256));
        }
    }
}