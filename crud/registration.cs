using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace crud
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;

            string course = cmbCourse.Text;
            string section = cmbSection.Text;

            string age = txtAge.Text;


            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "INSERT INTO student_list (id, firstname, lastname, course, section, age) " +
                "VALUES (NULL, @firstname, @lastname, @course, @section, @age)";
                MySql.Data.MySqlClient.MySqlCommand cmd =
                   new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);


                cmd.ExecuteNonQuery();
                

                if (firstname == "" || lastname == "" || course == "" || section == "" || age == "")
                {

                    MessageBox.Show("Please Insert the Missing Data to continue!", "Error!");

                    if (age == "0")
                    {
                        MessageBox.Show("Age can't be 0!", "Error!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Succesfully Added to the list", "Success!");
                    new MasterList().Show();
                    this.Close();
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

        private void cmbSectoin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
