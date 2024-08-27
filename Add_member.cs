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
    public partial class Add_member : Form
    {
        public Add_member()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashBoard db=new DashBoard();
            db.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text;
            string gender="";
            string address=textBoxaddress.Text;
            if(radioButton1.Checked)
            {
                gender = "Male";
            }
            if(radioButton2.Checked)
            {
                gender = "Female";
            }
            
            DateTime dob = dateTimePicker_dob.Value;
           // string dob=dateTimePicker_dob.Text;
            int mob_no = int.Parse(textBox_mobile_number.Text);
            DateTime join_date = dateTimePicker_joindate.Value;
            //string  join_date=dateTimePicker_joindate.Text;

            SqlConnection con=new SqlConnection("Data Source=DESKTOP-SS35PNP\\SQLEXPRESS;Initial Catalog=GYM_WindowsForm;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"insert into Add_Members values('{name}','{address}','{dob}',{mob_no},'{join_date}','{gender}');";
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
