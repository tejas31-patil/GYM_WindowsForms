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

namespace GYM_WindowsForms
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            string name=textBoxuname.Text;
            string pass=textBoxpassword.Text;
            string role="";
            if(radioButton1.Checked)
            {
                role = "Trainer";
            }
            if(radioButton2.Checked)
            {
                role = "Member";
            }

            SqlConnection con=new SqlConnection("Data Source=DESKTOP-SS35PNP\\SQLEXPRESS;Initial Catalog=GYM_WindowsForm;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"insert into Sign_up values('{name}','{pass}','{role}')";
            cmd.CommandType = new CommandType();


            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("inserted succesfully..");
                }
                else
                {
                    MessageBox.Show("record not inserted...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
