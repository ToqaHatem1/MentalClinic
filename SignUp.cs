using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_Enter(object sender, EventArgs e)
        {
            if (textFirstName.Text == "First Name")
            {
                textFirstName.Text = "";
                textFirstName.ForeColor = Color.Black;

            }
        }

        private void textFirstName_Leave(object sender, EventArgs e)
        {
            if (textFirstName.Text == "")
            {
                textFirstName.Text = "First Name";
                textFirstName.ForeColor = Color.Silver;

            }
        }

        private void txtMiddle_Enter(object sender, EventArgs e)
        {
            if (txtMiddle.Text == "Middle Name")
            {
                txtMiddle.Text = "";
                txtMiddle.ForeColor = Color.Black;

            }
        }

        private void txtMiddle_Leave(object sender, EventArgs e)
        {
            if (txtMiddle.Text == "")
            {
                txtMiddle.Text = "Middle Name";
                txtMiddle.ForeColor = Color.Silver;

            }
        }

        private void txtLast_Enter(object sender, EventArgs e)
        {
            if (txtLast.Text == "Last Name")
            {
                txtLast.Text = "";
                txtLast.ForeColor = Color.Black;

            }
        }

        private void txtLast_Leave(object sender, EventArgs e)
        {
            if (txtLast.Text == "")
            {
                txtLast.Text = "Last Name";
                txtLast.ForeColor = Color.Silver;

            }
        }

        private void txtDay_Enter(object sender, EventArgs e)
        {
            if (txtDay.Text == "Day")
            {
                txtDay.Text = "";
                txtDay.ForeColor = Color.Black;

            }
        }

        private void txtDay_Leave(object sender, EventArgs e)
        {
            if (txtDay.Text == "")
            {
                txtDay.Text = "Day";
                txtDay.ForeColor = Color.Silver;

            }
        }

        private void txtMonth_Enter(object sender, EventArgs e)
        {
            if (txtMonth.Text == "Month")
            {
                txtMonth.Text = "";
                txtMonth.ForeColor = Color.Black;

            }
        }

        private void txtMonth_Leave(object sender, EventArgs e)
        {
            if (txtMonth.Text == "")
            {
                txtMonth.Text = "Month";
                txtMonth.ForeColor = Color.Silver;

            }
        }

        private void txtYear_Enter(object sender, EventArgs e)
        {
            if (txtYear.Text == "Year")
            {
                txtYear.Text = "";
                txtYear.ForeColor = Color.Black;

            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                txtYear.Text = "Year";
                txtYear.ForeColor = Color.Silver;

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Your Account is created succesfully");
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }
    }
}
