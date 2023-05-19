using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SignUpUser : Form
    {
        public SignUpUser()
        {
            InitializeComponent();
        }

        private void SignUpUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MUVOJ1E\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        int userID = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            // Delete rows from BookCopy where Condition is 'Damaged'
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MUVOJ1E\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Insert into User (USERID, FIRSTNAME, LASTNAME, EMAILADDRESS, PASSWORD, PHONENUMBER) Valuse ('"+userID+"''" + textBox1.Text+"','"+textBox2.Text+ "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            userID++;
            // Show success message or update UI as needed
            MessageBox.Show("User is signed up successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // displays the user table
        }

        int adminID = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete rows from BookCopy where Condition is 'Damaged'
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MUVOJ1E\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Insert into User (USERID, FIRSTNAME, LASTNAME, EMAILADDRESS, PASSWORD, PHONENUMBER) Valuse ('" + adminID + "''" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            adminID++;
            // Show success message or update UI as needed
            MessageBox.Show("Admin is signed up successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteBooks form1 = new DeleteBooks();
            form1.Show();
            this.Hide();
        }
    }
}
