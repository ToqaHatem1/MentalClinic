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

namespace WindowsFormsApp4
{
    public partial class PatientDashboard : Form
    {
        public PatientDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PatientDashboard Obj = new PatientDashboard();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Appointments Obj = new Appointments();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void PatNum_Click(object sender, EventArgs e)
        {
            /*try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\MASA\Documents\myclinic.mdf; Integrated Security = True; Connect Timeout = 30");
                SqlCommand cmd = new SqlCommand("SELECT COUNT(PatId) from PatTbl", conn);
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                //display data on the page
                PatNum.ForeColor = Color.White;
                PatNum.Text = "No of Patients: " + rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } */

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
