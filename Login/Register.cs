using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Register : Form
    {
        //edit regel 17 naar eigen database.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\LoginForm.mdf;Integrated Security=True;Connect Timeout=30";
        public Register()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (RegUser.Text == "" || RegPass.Text == "")
                MessageBox.Show("Check of je alle velden hebt ingevuld!");
            else if (RegPass.Text != RegConfirm.Text)
                MessageBox.Show("Je wachtwoorden komen niet overeen!");
            else
            {
                //edit regel 49 t/m 54 naar eigen database.
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", RegUser.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", RegPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registratie is gelukt, log nu in met jouw account!");
                    Clear();
                }
            }
        }

        void Clear()
        {
            RegPass.Text = RegPass.Text
                =LabelConfirm.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
