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
    public partial class Add_Trainer : Form
    {
        public Add_Trainer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text;
            string gender = "";
            if(radioButton1.Checked)
            {
                gender = "Male";
            }
            if(radioButton2.Checked)
            {
                gender = "Female";
            }
            string address = textBoxaddress.Text;
            

            DateTime dob = datedob.Value;
            // string dob=dateTimePicker_dob.Text;
            int mob_no = int.Parse(textBoxmobileno.Text);
            DateTime join_date = joindate1.Value; 
            //string  join_date=dateTimePicker_joindate.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SS35PNP\\SQLEXPRESS;Initial Catalog=GYM_WindowsForm;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"insert into Add_Trainer values('{name}','{address}','{dob}',{mob_no},'{join_date}','{gender}');";
            cmd.CommandType = CommandType.Text;

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

        }
    }
}
