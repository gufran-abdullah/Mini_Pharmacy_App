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

namespace Pharmacy
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSHN4BD;Initial Catalog=Pharmacy_DB;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(unametxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Please fill all mendatory fields..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from Employee_tbl where EmpUserName = '"+unametxt.Text+ "' and EmpPassword = '"+passtxt.Text+"'",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    MainHomeForm mhf = new MainHomeForm();
                    mhf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    unametxt.Text = "";
                    passtxt.Text = "";
                    unametxt.Focus();
                }
                con.Close();
            }
        }
    }
}
