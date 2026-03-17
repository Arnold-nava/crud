namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // check if username or password is null or empty //

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter Username or Password", "error");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM student_account WHERE username=@username AND password=@password";
                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();

                if (count == 0)
                {
                    MessageBox.Show("Wrong username or password");
                    return;
                }
                else
                {
                    MessageBox.Show("Login Succesfully!");
                    new frmDashboard().Show();
                    this.Hide();
                }


            }
            catch
            {
                MessageBox.Show("Something went Wrong!", "Error");
            }
            finally
            {
                db.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
