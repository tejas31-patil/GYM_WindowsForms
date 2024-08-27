using GYM_WindowsForms;
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

namespace GYM_WindowsForms
{
    public partial class Login_Form :Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string pass = textBox2.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS35PNP\\SQLEXPRESS;Initial Catalog=GYM_WindowsForm;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Sign_up where   username = @username and password = @pass";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                MessageBox.Show("LoGiN SuCeSsFuLlIy\nWelcome...." + username);
               
                DashBoard obj = new DashBoard();
                obj.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid user id or password!!!");
            }

            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration_Form gf=new Registration_Form();
            gf.Show();
        }
    }
}
