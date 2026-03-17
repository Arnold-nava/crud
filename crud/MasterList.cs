using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class MasterList : Form
    {
        public MasterList()
        {
            InitializeComponent();
        }

        private void MasterList_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();

            string course = cmbCourse.Text;
            string section = cmbSection.Text;

            string age = txtAge.Text.Trim();

            if (id == "" || firstname == "" || lastname == "" || course == "" || section == "" || age == "")
            {

                MessageBox.Show("Please Insert the Missing Data to continue!", "Error!");
            }
            if(!int.TryParse(age, out int numAge))
            {
                MessageBox.Show("Age must be a number!", "Error!");
                return;
            }
            else if (numAge <= 0)
            {
                MessageBox.Show("Age must be greater than 0!", "Error!");
                return;
            }


                DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "UPDATE student_list SET " +
                        "firstname=@firstname, " +
                        "lastname=@lastname, " +
                        "course=@course, " +
                        "section=@section, " +
                        "age=@age " +
                        "WHERE id=@id";
                MySql.Data.MySqlClient.MySqlCommand cmd =
                   new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);

                
               cmd.ExecuteNonQuery();

               

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
    }
 }