using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  GYM_WindowsForms;

namespace GYM_WindowsForms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void buttonadd_member_Click(object sender, EventArgs e)
        {
            Add_member am=new Add_member();
            am.Show();
            Close();
        }

        private void buttonadd_staff_member_Click(object sender, EventArgs e)
        {
            Add_Trainer ad=new Add_Trainer();
            ad.Show();
        }

        private void buttonadd_equipment_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
